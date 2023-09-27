using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovaTechSquadHotel.Classes
{
    public class Funcionario
    {
        #region Propriedades

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public string Cargo { get; set; }
        public bool Ativo { get; set; }



        #endregion

        #region Construtores

        public Funcionario()
        {

        }

        public Funcionario(int id, string nome, string cpf, string email, string senha,string telefone, string cargo, bool ativo)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Email = email;
            Senha = senha;
            Telefone = telefone;
            Cargo = cargo;
            Ativo = ativo;
        }

        #endregion

        #region Métodos

        public static Funcionario RealizarLogin(string email, string senha)
        {
           
                string query = string.Format($"SELECT * FROM Funcionario WHERE Email = '{email}'");
                ConexaoSQL cn = new ConexaoSQL(query);

                Funcionario funcionario = new Funcionario();

                try
                {
                    cn.AbriConexao();
                    cn.dr = cn.comando.ExecuteReader();

                    if (cn.dr.HasRows)
                    {
                        while (cn.dr.Read())
                        {
                            funcionario.Id = Convert.ToInt32(cn.dr[0]);
                            funcionario.Nome = cn.dr[1].ToString();
                            funcionario.CPF = cn.dr[2].ToString();
                            funcionario.Email = cn.dr[3].ToString();
                            funcionario.Senha = cn.dr[4].ToString();
                            funcionario.Telefone = cn.dr[5].ToString();
                            funcionario.Cargo = cn.dr[6].ToString();
                            funcionario.Ativo = Convert.ToBoolean(cn.dr[7]);
                        }
                        if (funcionario.Senha == Crypto.Sha256(senha))
                        {
                            if (funcionario.Ativo)
                            {
                                return funcionario;
                            }
                            else
                            {
                                throw new Exception("Usuário bloquado");
                            }
                        }
                        else
                        {
                            throw new Exception("Senha incorreta");
                        }
                    }
                    else
                    {
                        throw new Exception("Email inexistente");
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            #endregion
        }
        public static List<Funcionario> BuscarFuncionario() 
        {
            string query = string.Format($"SELECT * FROM Funcionario");
            ConexaoSQL cn = new ConexaoSQL(query);

            List<Funcionario> funcionarios = new List<Funcionario>();

            try
            {
                cn.AbriConexao();
                cn.dr = cn.comando.ExecuteReader();
                
                while (cn.dr.Read())
                {
                    funcionarios.Add(new Funcionario()
                    {
                        Id = Convert.ToInt32(cn.dr[0]),
                        Nome = cn.dr[1].ToString(),
                        CPF = cn.dr[2].ToString(),
                        Email = cn.dr[3].ToString(),
                        Senha = cn.dr[4].ToString(),
                        Telefone = cn.dr[5].ToString(),
                        Cargo = cn.dr[5].ToString(),
                        Ativo = Convert.ToBoolean(cn.dr[6]),
                    });
                }
                return funcionarios;
            }
            catch (Exception)
            {

                throw;
            }
        }      
        public void CadastrarFuncionario(List<Funcionario> funcionarios)
        {
            string query = string.Format($"INSERT INTO Hospede (Nome,CPF,Email,Senha,Telefone,Cargo,Ativo) VALUES ('{Nome}','{CPF}','{Email}','{Senha}','{Telefone}','{Cargo}',1)");
            query += "; SELECT SCOPE_IDENTITY()";
            ConexaoSQL cn = new ConexaoSQL(query);

            try
            {
                cn.AbriConexao();
                Id = Convert.ToInt32(cn.comando.ExecuteScalar());
                funcionarios.Add(this);
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
        public void ExcluirFuncionario()
        {
            string query = string.Format($"DELETE FROM Funcionario WHERE Id = {Id}");
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
        public void AlterarFuncionario()
        {
            string query = string.Format($"UPDATE Funcionario SET  Nome = '{Nome}',CPF='{CPF}',Email = '{Email}',Senha = '{Senha}', Telefone = '{Telefone}',Cargo = '{Cargo}',Ativo = '{Ativo}'");
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
        public void ReativarFuncionario()
        {
            try
            {
                string query = string.Format($"UPDATE Funcionario SET Ativo = 1 WHERE Id = {Id}");
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
            catch (Exception)
            {

                throw;
            }
        }
    }
}
