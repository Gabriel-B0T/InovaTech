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
    public partial class TelaCadastrarHospede : Form
    {
        private Funcionario _userLogado;
        private List<Hospede> _hospedes;
        private Hospede _hospedeSelecionado;
        public TelaCadastrarHospede(Funcionario funcionarioLogado)
        {
            InitializeComponent();
            _userLogado = funcionarioLogado;

            try
            {
                _hospedes = Hospede.BuscarHospede().ConvertAll(u => (Hospede)u);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            ConfigurarDgv();
            CarregarDgv();
        }

        private void ConfigurarDgv()
        {
            //Criação de colunas no DvgRegistro
            DgvRegistro.Columns.Add("Id","Numero de registro");
            DgvRegistro.Columns.Add("Nome","Nome");
            DgvRegistro.Columns.Add("CPF", "CPF");
            DgvRegistro.Columns.Add("Email", "E-mail");
            DgvRegistro.Columns.Add("Telefone", "Telefone");
            DgvRegistro.Columns.Add("DtNascimento", "Data de Nascimento");
            DgvRegistro.Columns.Add("Endereco", "Endereço");


            //Configuração dos alinhamentos de cada coluna do DgvRegistro
            DgvRegistro.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistro.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistro.Columns["CPF"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistro.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistro.Columns["Telefone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistro.Columns["DtNascimento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistro.Columns["Endereco"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Configuração dos tamanhos de cada coluna do DgvRegistro

            DgvRegistro.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvRegistro.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvRegistro.Columns["CPF"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvRegistro.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvRegistro.Columns["Telefone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvRegistro.Columns["DtNascimento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvRegistro.Columns["Endereco"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //Configurar tamanho em altura de colunas e linhas
            DgvRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DgvRegistro.ColumnHeadersHeight = 35;
            DgvRegistro.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //Definindo uma cor para intercalar linhas
            DgvRegistro.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }
        private void CarregarDgv(List<Hospede> hospedes = null)
        {
            //Método para carregar o DvgUsuarios com os dados da List

            DgvRegistro.Rows.Clear();

            foreach(Hospede hospede in hospedes ==  null ? _hospedes : hospedes)
            {
                DgvRegistro.Rows.Add(hospede.Id, hospede.Nome,hospede.CPF,hospede.Email,hospede.Telefone,hospede.DtNascimento.ToString("dd/MM/yyyy"), hospede.Endereco);
            }
        }
        private void LimparCampos()
        {
            LblId.Text = "";
            TxtNome.Clear();
            TxtCPF.Clear();
            DtpDtNascimento.Value = new DateTime(1990, 01, 01);
            TxtEmail.Clear();
            TxtEndereco.Clear();
            TxtTelefone.Clear();
            DgvRegistro.ClearSelection();
            BtnCadastrar.Enabled = true;
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
        
            
        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Hospede hospede = new Hospede(0, TxtNome.Text, TxtCPF.Text, TxtEmail.Text, TxtTelefone.Text, DtpDtNascimento.Value,  TxtEndereco.Text);
                hospede.CadastrarHospede(_hospedes);
                CarregarDgv();
                LimparCampos();
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Golden Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TelaCadastrarHospede_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarDgv();
                CarregarDgv();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {           
            try
            {
                DialogResult dr = MessageBox.Show($"Você realmente deseja exluir {_hospedeSelecionado.Nome}?", "Excluir hospede", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    _hospedeSelecionado.ExcluirHospede();
                    _hospedes.RemoveAt(_hospedes.FindIndex(a => a.Id == (int)DgvRegistro.SelectedRows[0].Cells[0].Value));
                    CarregarDgv();
                    //DgvRegistro.Rows.RemoveAt(DgvRegistro.SelectedRows[0].Index); /fica na memoria ainda.
                    //_hospedes = Hospede.BuscarHospede().ConvertAll(u => (Hospede)u);
                    //CarregarDgv();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }                    

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                _hospedeSelecionado.Nome = TxtNome.Text;
                _hospedeSelecionado.CPF = TxtCPF.Text;
                _hospedeSelecionado.Email = TxtEmail.Text;
                _hospedeSelecionado.Telefone = TxtTelefone.Text;
                _hospedeSelecionado.DtNascimento = DtpDtNascimento.Value;
                _hospedeSelecionado.Endereco = TxtEndereco.Text;

                _hospedeSelecionado.Alterar();
                CarregarDgv();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void DgvRegistro_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvRegistro.Rows.Count < 1 || DgvRegistro.SelectedRows.Count < 1)
                return;

            try
            {
                _hospedeSelecionado = _hospedes.Find(a => a.Id == (int)DgvRegistro.SelectedRows[0].Cells[0].Value);
                LblId.Text = _hospedeSelecionado.Id.ToString();
                TxtNome.Text = _hospedeSelecionado.Nome;
                TxtCPF.Text = _hospedeSelecionado.CPF;
                TxtEmail.Text = _hospedeSelecionado.Email;
                TxtTelefone.Text = _hospedeSelecionado.Telefone;
                DtpDtNascimento.Value = _hospedeSelecionado.DtNascimento;

                BtnCadastrar.Enabled = false;
                BtnAlterar.Enabled = true;
                BtnExcluir.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
