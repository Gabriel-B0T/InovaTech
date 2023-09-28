using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovaTechSquadHotel.Classes
{
    internal class ConexaoSQL
    {
        #region Variáveis

        //String de conexão                                                         Informações Chumbadas - HardCode
        private static readonly string _strConexao = @"Data Source = VPR0687139W10-1; Initial Catalog = Hotel; Integrated Security = True";

        // Variáveis de uso (podem ou não serem usadas ao decorrrer do projeto)
        public SqlConnection conexao = new SqlConnection(_strConexao);

        public SqlCommand comando; // Armazenar a query

        public SqlDataAdapter da; // Adaptador para alguns componentes

        public SqlDataReader dr; // Recebe os select's

        public DataSet ds; // Trabalha com multiplas tabelas


        #endregion

        #region Construtores

        public ConexaoSQL(string query)
        {
            comando = new SqlCommand(query, conexao); // Comando montado
            da = new SqlDataAdapter(query, conexao); // Caso necessário, está pronto
            ds = new DataSet();// Se necessário
        }

        #endregion

        #region Métodods
        //Um método para abrir a conexão com o banco de dados

        public void AbriConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
            conexao.Open();
        }

        public void FecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        #endregion
    }
}
