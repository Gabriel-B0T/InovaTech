using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovaTechSquadHotel.Classes
{
    internal class Quarto
    {
        #region Propriedades

        public int Id { get; set; }
        public int TipoQuartoId { get; set; }
        public TipoQuarto TipoQuarto { get; set; }
        public int NumQuarto { get; set; }
        public int NumAndar { get; set; }
        public decimal ValorDiaria { get; set; }
        public List<Hospede> Hospedes { get; set; }
        #endregion

        #region Construtores

        public Quarto()
        {
        }
        public Quarto(int id, int tipoQuarto, int numQuarto, int numAndar, decimal valorDiaria)
        {
            Id = id;
            TipoQuartoId = tipoQuarto;
            NumQuarto = numQuarto;
            NumAndar = numAndar;
            ValorDiaria = valorDiaria;
        }
        #endregion

        #region Métodos
        public void CadastrarQuarto(List<Quarto> quartos)
        {
            string query = string.Format($"INSERT INTO Quarto (TipoQuartoId,NumQuarto,NumAndar,ValorDiaria) VALUES ('{TipoQuartoId}','{NumQuarto}','{NumAndar}','{ValorDiaria}')");
            query += "; SELECT SCOPE_IDENTITY()";
            ConexaoSQL cn = new ConexaoSQL(query);

            try
            {
                cn.AbriConexao();
                Id = Convert.ToInt32(cn.comando.ExecuteScalar());
                quartos.Add(this);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.FecharConexao();
            }

        }
        public static List<Quarto> BuscarQuartos()
        {
            string query = string.Format($"SELECT * FROM Quarto");
            ConexaoSQL cn = new ConexaoSQL(query);

            List<Quarto> quartos = new List<Quarto>();

            try
            {
                cn.AbriConexao();
                cn.dr = cn.comando.ExecuteReader();
                while (cn.dr.Read())
                {
                    quartos.Add(new Quarto()
                    {
                        Id = Convert.ToInt32(cn.dr[0]),
                        NumQuarto = Convert.ToInt32(cn.dr[1]),
                        NumAndar = Convert.ToInt32(cn.dr[2]),
                        ValorDiaria = Convert.ToDecimal(cn.dr[3]),
                    });
                }
                return quartos;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ExcluirQuarto()
        {
            string query = string.Format($"DELETE FROM Quarto WHERE Id = {Id}");
            ConexaoSQL cn = new ConexaoSQL(query);

            try
            {
                cn.AbriConexao();
                cn.comando.ExecuteNonQuery();
              
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.FecharConexao();
            }
        }
        public void AlterarQuarto()
        {
            string query = string.Format($"UPDATE Quarto SET NumQuarto = '{NumQuarto}', NumAndar = '{NumAndar}', ValorDiaria = '{ValorDiaria}'");
            ConexaoSQL cn = new ConexaoSQL(query);

            try
            {
                cn.AbriConexao();
                cn.comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.FecharConexao();
            }
        }
        #endregion
    }
}
