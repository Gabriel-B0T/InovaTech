using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovaTechSquadHotel.Classes
{
    internal class Reserva
    {
        #region Propriedades

        public int Id { get; set; }
        public int FuncionarioId { get; set; }
        public int HospedeId { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public DateTime DtInicioReserva { get; set; }
        public DateTime DtFimReserva { get; set; }
        public int QdtDiaria { get; set; }
        public string Avaliacao { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DtReserva { get; set; }
        public List<Quarto> Quartos { get; set; }
        #endregion

        #region Construtores
        public Reserva()
        {
            
        }

        public Reserva(int id, DateTime dtInicioReserva, DateTime dtFimReserva, int qdtDiaria)
        {
            Id = id;
            DtInicioReserva = dtInicioReserva;
            DtFimReserva = dtFimReserva;
            QdtDiaria = qdtDiaria;          
        }
        #endregion

        #region Métodos

        public void AdicionarReserva(List<Reserva> reservas)
        {
            string query = string.Format($"INSERT INTO Reserva (Checkin, Checkout,DtInicioReserva,DtFimReserva,QtdDiaria,ValorTotal) VALUES ('{DtInicioReserva}','{DtFimReserva}','{QdtDiaria}'");
            query += "; SELECT SCOPE_IDENTITY()";
            ConexaoSQL cn = new ConexaoSQL(query);

            try
            {
                cn.AbriConexao();
                Id = Convert.ToInt32(cn.comando.ExecuteScalar());
                reservas.Add(this);
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
