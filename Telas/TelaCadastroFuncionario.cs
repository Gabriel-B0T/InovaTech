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
    public partial class TelaCadastroFuncionario : Form
    {
        private Funcionario _userLogado;
        private List<Funcionario> _funcionarios;
        private Funcionario _funcionarioSelecionado;

        public TelaCadastroFuncionario(Funcionario funcionarioLogado)
        {
            InitializeComponent();
            _userLogado = funcionarioLogado;

            try
            {
                _funcionarios = Funcionario.BuscarFuncionario().ConvertAll(u => (Funcionario)u);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigurarDgv()
        {
            //Criação de colunas no DvgRegistro
            DgvRegistro.Columns.Add("Id", "Numero de registro");
            DgvRegistro.Columns.Add("Nome", "Nome");
            DgvRegistro.Columns.Add("CPF", "CPF");
            DgvRegistro.Columns.Add("Email", "E-mail");
            DgvRegistro.Columns.Add("Senha", "Senha");
            DgvRegistro.Columns.Add("Telefone", "Telefone");
            DgvRegistro.Columns.Add("Cargo", "Cargo");
            DgvRegistro.Columns.Add("Ativo", "Ativo");


            //Configuração dos alinhamentos de cada coluna do DgvRegistro
            DgvRegistro.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistro.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistro.Columns["CPF"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistro.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistro.Columns["Senha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistro.Columns["Telefone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistro.Columns["Cargo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistro.Columns["Ativo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Configuração dos tamanhos de cada coluna do DgvRegistro

            DgvRegistro.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvRegistro.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvRegistro.Columns["CPF"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvRegistro.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvRegistro.Columns["Senha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvRegistro.Columns["Telefone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvRegistro.Columns["Cargo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvRegistro.Columns["Ativo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            //Configurar tamanho em altura de colunas e linhas
            DgvRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DgvRegistro.ColumnHeadersHeight = 35;
            DgvRegistro.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //Definindo uma cor para intercalar linhas
            DgvRegistro.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }
        private void CarregarDgv(List<Funcionario> funcionarios = null)
        {
            //Método para carregar o DvgUsuarios com os dados da List

            DgvRegistro.Rows.Clear();

            foreach (Funcionario funcionario in funcionarios == null ? _funcionarios : funcionarios)
            {
                DgvRegistro.Rows.Add(funcionario.Id, funcionario.Nome, funcionario.CPF, funcionario.Email, funcionario.Telefone, funcionario.Cargo, funcionario.Ativo);
            }
        }
        private void LimparCampos()
        {
            LblId.Text = "";
            TxtNome.Clear();
            TxtCPF.Clear();
            TxtEmail.Clear();
            TxtTelefone.Clear();
            TxtCargo.Clear();
            CbxAtivo.Checked = false;
            DgvRegistro.ClearSelection();
            BtnCadastrar.Enabled = true;
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario funcionario = new Funcionario(0,TxtNome.Text,TxtCPF.Text,TxtEmail.Text,"123",TxtTelefone.Text,TxtCargo.Text,true);
                funcionario.CadastrarFuncionario(_funcionarios);
                CarregarDgv();
                LimparCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Golden Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TelaCadastroFuncionario_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarDgv();
                CarregarDgv();
                LimparCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Golden Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show($"Você realmente deseja exluir {_funcionarioSelecionado}?", "Excluir funcionario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    _funcionarioSelecionado.ExcluirFuncionario();
                    _funcionarios.RemoveAt(_funcionarios.FindIndex(a => a.Id == (int)DgvRegistro.SelectedRows[0].Cells[0].Value));
                    CarregarDgv();                   
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void DgvRegistro_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvRegistro.Rows.Count < 1 || DgvRegistro.SelectedRows.Count < 1)
                return;

            try
            {
                _funcionarioSelecionado = _funcionarios.Find(a => a.Id == (int)DgvRegistro.SelectedRows[0].Cells[0].Value);
                LblId.Text = _funcionarioSelecionado.Id.ToString();
                TxtNome.Text = _funcionarioSelecionado.Nome;
                TxtCPF.Text = _funcionarioSelecionado.CPF;
                TxtEmail.Text = _funcionarioSelecionado.Email;
                TxtTelefone.Text = _funcionarioSelecionado.Telefone;
                TxtCargo.Text = _funcionarioSelecionado.Cargo;
                CbxAtivo.Checked = _funcionarioSelecionado.Ativo;

                BtnCadastrar.Enabled = false;
                BtnAlterar.Enabled = true;
                BtnExcluir.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
