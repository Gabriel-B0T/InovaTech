using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovaTechSquadHotel.Classes
{
    internal class Hospede
    {
        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Endereco { get; set; }

        #endregion

        #region Construtores
        public Hospede()
        {

        }

        public Hospede(int id, string nome, string cPF, string email,  string telefone, DateTime dtNascimento, string endereco)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            Email = email;
            DtNascimento = dtNascimento;
            Telefone = telefone;
            Endereco = endereco;
        }
        #endregion

        #region Metodos

        public void CadastrarHospede(List<Hospede> hospedes)
        {
            string query = string.Format($"INSERT INTO Hospede (Nome,CPF,Email,Telefone,DtNascimento,Endereco) VALUES ('{Nome}','{CPF}','{Email}','{Telefone}','{DtNascimento}','{Endereco}')");
            query += "; SELECT SCOPE_IDENTITY()";
            ConexaoSQL cn = new ConexaoSQL(query);  
            
            try
            {
                cn.AbriConexao();
                Id = Convert.ToInt32(cn.comando.ExecuteScalar());
                hospedes.Add(this);
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
        public static List<Hospede> BuscarHospede()
        {
            string query = string.Format($"SELECT * FROM Hospede");
            ConexaoSQL cn = new ConexaoSQL(query);

            List<Hospede> hospedes = new List<Hospede>();

            try
            {
                cn.AbriConexao();
                cn.dr = cn.comando.ExecuteReader();

                while (cn.dr.Read())
                {
                    hospedes.Add(new Hospede()
                    {
                        Id = Convert.ToInt32(cn.dr[0]),
                        Nome = cn.dr[1].ToString(),
                        CPF = cn.dr[2].ToString(),
                        Email = cn.dr[3].ToString(),
                        Telefone = cn.dr[4].ToString(),
                        DtNascimento = Convert.ToDateTime(cn.dr[5]),
                        Endereco = cn.dr[6].ToString(),

                    });
                }
                return hospedes;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ExcluirHospede()
        {
            string query = string.Format($"DELETE FROM Hospede WHERE Id = {Id}");
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
        public void Alterar()
        {
            string query = string.Format($"UPDATE Hospede SET  Nome = '{Nome}',CPF='{CPF}',Email = '{Email}',Telefone = '{Telefone}', DtNascimento = '{DtNascimento}',Endereco = '{Endereco}'");
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
