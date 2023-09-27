using InovaTechSquadHotel.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InovaTechSquadHotel.Telas
{
    public partial class TelaReserva : Form
    {
        private Funcionario _userLogado;
        private List<Hospede> _hospedes;
        private Hospede _hospedeSelecionado;

        public TelaReserva(Funcionario funcionarioLogado)
        {
            InitializeComponent();
            _userLogado = funcionarioLogado;
        }

    }
}
