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
        public void BuscarTipoQuarto(List<TipoQuarto> tipoQuartos)
        {
            string query = string.Format($"INSERT INTO TipoQuartos (Capacidade,Descricao,Ativo,QtdCamaSimples,QtdCamaDupla) VALUES ('{Capacidade}','{Descricao}','{TipoQuartos}','{Ativo}','{QtdCamaSimples}','{QtdCamaDupla})");
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




            #endregion

        }
    }
}
