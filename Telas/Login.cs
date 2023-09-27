using InovaTechSquadHotel.Classes;
using InovaTechSquadHotel.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InovaTechSquadHotel
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario funcionarioLogado = Funcionario.RealizarLogin(TxtEmail.Text, TxtSenha.Text);

                TelaPrincipal tlPrincipal = new TelaPrincipal(funcionarioLogado);
                this.Hide();
                tlPrincipal.ShowDialog();
                this.Show();
                TxtSenha.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Golden Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
