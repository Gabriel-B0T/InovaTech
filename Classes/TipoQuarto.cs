using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovaTechSquadHotel.Classes
{
    internal class TipoQuarto
    {
        #region Proriedades
        public int Id { get; set; }
        public int Capacidade { get; set; }
        public string Descricao { get; set; }
        public string TipoQuartos { get; set; }
        public bool Ativo { get; set; }
        public int QtdCamaSimples { get; set; }
        public int QtdCamaDupla { get; set; }


        #endregion

        #region Construtores
        public TipoQuarto()
        {

        }

        public TipoQuarto(int id, int capacidade, string descricao, string tipoQuartos, bool ativo, int qtdCamaSimples, int qtdCamaDupla)
        {
            Id = id;
            Capacidade = capacidade;
            Descricao = descricao;
            TipoQuartos = tipoQuartos;
            Ativo = ativo;
            QtdCamaSimples = qtdCamaSimples;
            QtdCamaDupla = qtdCamaDupla;
        }

        #endregion

        #region Metodos
        public void CadastrarTipoQuarto(List<TipoQuarto> tipoQuartos)
        {
            string query = string.Format($"INSERT INTO TipoQuarto (Capacidade,Descricao,TipoQuarto,Ativo,QdtCamaSimples,QdtCamaDupla) VALUES ('{Capacidade}','{Descricao}','{TipoQuartos}','{Ativo}','{QtdCamaSimples}','{QtdCamaDupla}')");
            query += "; SELECT SCOPE_IDENTITY()";
            ConexaoSQL cn = new ConexaoSQL(query);

            try
            {
                cn.AbriConexao();
                Id = Convert.ToInt32(cn.comando.ExecuteScalar());
                tipoQuartos.Add(this);
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
        public static List<TipoQuarto> BuscarTipoQuarto()
        {
            string query = string.Format($"SELECT * FROM TipoQuarto");
            ConexaoSQL cn = new ConexaoSQL(query);

            List<TipoQuarto> tipoQuartos = new List<TipoQuarto>();

            try
            {
                cn.AbriConexao();
                cn.dr = cn.comando.ExecuteReader();

                while (cn.dr.Read())
                {
                    tipoQuartos.Add(new TipoQuarto()
                    {
                        Id = Convert.ToInt32(cn.dr[0]),
                        Capacidade = Convert.ToInt32(cn.dr[1]),
                        Descricao = cn.dr[2].ToString(),
                        TipoQuartos = cn.dr[3].ToString(),
                        Ativo = Convert.ToBoolean(cn.dr[4]),
                        QtdCamaSimples = Convert.ToInt32(cn.dr[5]),
                        QtdCamaDupla = Convert.ToInt32(cn.dr[6]),
                    });
                }
                return tipoQuartos;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ExcluirTipoQuarto()
        {
            string query = string.Format($"DELETE FROM TipoQuarto WHERE Id = {Id}");
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
        public void AlterarTipoQuarto()
        {
            string query = string.Format($"UPDATE TipoQuarto SET Capacidade = '{Capacidade}',Descricao = '{Descricao}',Ativo = '{Ativo}',QdtCamaSimples = '{QtdCamaSimples}',QtdCamaDupla = '{QtdCamaDupla}'");
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
