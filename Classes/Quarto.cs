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
        public int NumQuarto { get; set; }
        public int NumAndar { get; set; }
        public decimal ValorDiaria { get; set; }
        #endregion

        #region Construtores

        public Quarto()
        {
        }
        public Quarto(int id, int numQuarto, int numAndar, decimal valorDiaria)
        {
            Id = id;
            NumQuarto = numQuarto;
            NumAndar = numAndar;
            ValorDiaria = valorDiaria;
        }
        #endregion

        #region Métodos
        public void CadastrarQuarto(List<Quarto> quartos)
        {
            string query = string.Format($"INSERT INTO Quarto (NumQuarto,NumAndar,ValorDiaria) VALUES ('{NumQuarto}','{NumAndar}','{ValorDiaria}')");
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
            string query = string.Format($"SELECT * FROM Quartos");
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
        #endregion
    }
}
