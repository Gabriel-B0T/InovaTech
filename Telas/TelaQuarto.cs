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
            DgvRegistro.Columns.Add("TipoQuartoId", "Tipo de quarto");
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
                DgvRegistro.Rows.Add(quarto.Id, quarto.NumQuarto, quarto.NumAndar, quarto.ValorDiaria);
            }
        }

        private void LimparCampos()
        {
            LblIdQuarto.Text = string.Empty;
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
                Quarto quarto = new Quarto(0,(int)CbxTipoQuarto.SelectedValue ,Convert.ToInt32(TxtNquarto.Text), Convert.ToInt32(TxtNAndar.Text), Convert.ToInt32(TxtValorDiaria.Text));
                quarto.CadastrarQuarto(_quartos);
                //CarregarDgv();
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
    }
}