using InovaTechSquadHotel.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InovaTechSquadHotel.Telas
{
    public partial class TelaQuarto : Form
    {
        private Funcionario _userLogado;
        private List<Quarto> _quartos;
        private Quarto _quartoSelecionado;
        public TelaQuarto(Funcionario funcionarioLogado)
        {
            InitializeComponent();
            _userLogado = funcionarioLogado;

            try
            {
                _quartos = Quarto.BuscarQuartos().ConvertAll(u => (Quarto)u);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDgv()
        {
            //Criação de colunas no DvgRegistro
            DgvRegistro.Columns.Add("Id", " Id");
            DgvRegistro.Columns.Add("TipoQuartoId", "Id Tipo de quarto");
            DgvRegistro.Columns.Add("NumQuarto", "Numero do quarto");
            DgvRegistro.Columns.Add("NumAndar", "Numero do andar");
            DgvRegistro.Columns.Add("ValorDiaria", "Valor da diaria");



            //Configuração dos alinhamentos de cada coluna do DgvRegistro
            DgvRegistro.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistro.Columns["TipoQuartoId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistro.Columns["NumQuarto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistro.Columns["NumAndar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistro.Columns["ValorDiaria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Configuração dos tamanhos de cada coluna do DgvRegistro

            DgvRegistro.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvRegistro.Columns["TipoQuartoId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvRegistro.Columns["NumQuarto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvRegistro.Columns["NumAndar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvRegistro.Columns["ValorDiaria"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            //Configurar tamanho em altura de colunas e linhas
            DgvRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DgvRegistro.ColumnHeadersHeight = 35;
            DgvRegistro.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //Definindo uma cor para intercalar linhas
            DgvRegistro.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void CarregarDgv(List<Quarto> quartos = null)
        {
            //Método para carregar o DvgUsuarios com os dados da List

            DgvRegistro.Rows.Clear();

            foreach (Quarto quarto in quartos ?? _quartos)
            {
                DgvRegistro.Rows.Add(quarto.Id,quarto.TipoQuartoId, quarto.NumQuarto, quarto.NumAndar, quarto.ValorDiaria);
            }
        }

        private void LimparCampos()
        {
            LblIdTipoQuarto.Text = string.Empty;
            TxtNquarto.Clear();
            TxtNAndar.Clear();
            TxtValorDiaria.Clear();
            DgvRegistro.ClearSelection();
            BtnCadastrar.Enabled = true;
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Quarto quarto = new Quarto(0, (int)CbxTipoQuarto.SelectedValue, Convert.ToInt32(TxtNquarto.Text), Convert.ToInt32(TxtNAndar.Text), Convert.ToInt32(TxtValorDiaria.Text));
                quarto.CadastrarQuarto(_quartos);
                CarregarDgv();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TelaQuartos_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarDgv();
                CarregarDgv();
                LimparCampos();

                List<TipoQuarto> tipoQuartos = TipoQuarto.BuscarTipoQuarto(); // Use o método BuscarTipoQuarto da classe TipoQuarto
                CbxTipoQuarto.DataSource = tipoQuartos;
                CbxTipoQuarto.DisplayMember = "Descricao"; // Exibe a descrição do tipoQuarto
                CbxTipoQuarto.ValueMember = "Id"; // Armazena o ID do tipoQuarto
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
                DialogResult dr = MessageBox.Show($"Você realmente deseja exluir {_quartoSelecionado}?", "Excluir o quarto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    _quartoSelecionado.ExcluirQuarto();
                    _quartos.RemoveAt(_quartos.FindIndex(a => a.Id == (int)DgvRegistro.SelectedRows[0].Cells[0].Value));
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
                _quartoSelecionado = _quartos.Find(a => a.Id == (int)DgvRegistro.SelectedRows[0].Cells[0].Value);
                LblIdQuarto.Text = _quartoSelecionado.Id.ToString();
                LblIdTipoQuarto.Text = _quartoSelecionado.TipoQuartoId.ToString();               
                TxtNquarto.Text = _quartoSelecionado.NumQuarto.ToString();
                TxtNAndar.Text = _quartoSelecionado.NumAndar.ToString();
                TxtValorDiaria.Text = _quartoSelecionado.ValorDiaria.ToString();

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

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                _quartoSelecionado.NumQuarto = Convert.ToInt32(TxtNquarto.Text);
                _quartoSelecionado.NumAndar = Convert.ToInt32(TxtNAndar.Text);
                _quartoSelecionado.ValorDiaria = Convert.ToInt32(TxtValorDiaria.Text);


                _quartoSelecionado.AlterarQuarto();
                CarregarDgv();
            }
            catch (Exception)
            {

                throw;
            }
        }
               
    }
}