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
    public partial class TelaTipoQuarto : Form
    {
        private Funcionario _userLogado;
        private List<TipoQuarto> _tipoQuartos;
        private TipoQuarto _TipoQuartosSelecionado;
        public TelaTipoQuarto(Funcionario funcionarioLogado)
        {
            InitializeComponent();
            _userLogado = funcionarioLogado;

            try
            {
                _tipoQuartos = TipoQuarto.BuscarTipoQuarto().ConvertAll(u => (TipoQuarto)u);
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
            DgvRegistro.Columns.Add("Capacidade", "Capacidade");
            DgvRegistro.Columns.Add("Descricao", "Descrição");
            DgvRegistro.Columns.Add("TipoQuarto", "Tipo de quarto");
            DgvRegistro.Columns.Add("Ativo", "Ativo");
            DgvRegistro.Columns.Add("QdtCamaSimples", "Quantidade de cama simples");
            DgvRegistro.Columns.Add("QtdCamaDupla", "Quantidade de cama dupla");
         

            //Configuração dos alinhamentos de cada coluna do DgvRegistro
            DgvRegistro.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistro.Columns["Capacidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistro.Columns["Descricao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistro.Columns["TipoQuarto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistro.Columns["Ativo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistro.Columns["QdtCamaSimples"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistro.Columns["QtdCamaDupla"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            //Configuração dos tamanhos de cada coluna do DgvRegistro

            DgvRegistro.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvRegistro.Columns["Capacidade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvRegistro.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvRegistro.Columns["TipoQuarto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvRegistro.Columns["Ativo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvRegistro.Columns["QdtCamaSimples"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvRegistro.Columns["QtdCamaDupla"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
   

            //Configurar tamanho em altura de colunas e linhas
            DgvRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DgvRegistro.ColumnHeadersHeight = 35;
            DgvRegistro.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //Definindo uma cor para intercalar linhas
            DgvRegistro.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }
        private void CarregarDgv(List<TipoQuarto> tipoQuartos = null)
        {
            //Método para carregar o DvgUsuarios com os dados da List

            DgvRegistro.Rows.Clear();

            foreach (TipoQuarto tipoQuarto in tipoQuartos ?? _tipoQuartos)
            {
                DgvRegistro.Rows.Add(tipoQuarto.Id, tipoQuarto.Capacidade, tipoQuarto.Descricao, tipoQuarto.TipoQuartos,tipoQuarto.Ativo, tipoQuarto.QtdCamaSimples, tipoQuarto.QtdCamaDupla);
            }
        }
        private void LimparCampos()
        {
            LblId.Text = "";
            TxtCapacidade.Clear();
            TxtDescricao.Clear();
            TxtTipoQuarto.Clear();
            TxtQdtCamaSimples.Clear();
            TxtQtdCamaDupla.Clear();
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
                TipoQuarto tipoQuarto = new TipoQuarto(0, Convert.ToInt32(TxtCapacidade.Text), TxtDescricao.Text, TxtTipoQuarto.Text, true, Convert.ToInt32(TxtQdtCamaSimples.Text), Convert.ToInt32(TxtQtdCamaDupla.Text));
                tipoQuarto.CadastrarTipoQuarto(_tipoQuartos);
                CarregarDgv();
                LimparCampos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void TelaTipoQuarto_Load(object sender, EventArgs e)
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

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                _TipoQuartosSelecionado.Capacidade = Convert.ToInt32(TxtCapacidade.Text);
                _TipoQuartosSelecionado.Descricao = TxtDescricao.Text;
                _TipoQuartosSelecionado.TipoQuartos = TxtTipoQuarto.Text;
                _TipoQuartosSelecionado.Ativo = Convert.ToBoolean(CbxAtivo.Checked);
                _TipoQuartosSelecionado.QtdCamaSimples = Convert.ToInt32(TxtQdtCamaSimples.Text);
                _TipoQuartosSelecionado.QtdCamaDupla = Convert.ToInt32(TxtQtdCamaDupla.Text);

                _TipoQuartosSelecionado.AlterarTipoQuarto();
                CarregarDgv();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show($"Você realmente deseja exluir {_TipoQuartosSelecionado}?", "Excluir tipo quarto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    _TipoQuartosSelecionado.ExcluirTipoQuarto();
                    _tipoQuartos.RemoveAt(_tipoQuartos.FindIndex(a => a.Id == (int)DgvRegistro.SelectedRows[0].Cells[0].Value));
                    CarregarDgv();
                }
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

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DgvRegistro_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvRegistro.Rows.Count < 1 || DgvRegistro.SelectedRows.Count < 1)
                return;

            try
            {
                _TipoQuartosSelecionado = _tipoQuartos.Find(a => a.Id == (int)DgvRegistro.SelectedRows[0].Cells[0].Value);
                LblId.Text = _TipoQuartosSelecionado.Id.ToString();
                TxtCapacidade.Text = _TipoQuartosSelecionado.Capacidade.ToString();
                TxtDescricao.Text = _TipoQuartosSelecionado.Descricao;
                TxtTipoQuarto.Text = _TipoQuartosSelecionado.TipoQuartos;
                CbxAtivo.Text = _TipoQuartosSelecionado.Ativo.ToString();
                TxtQdtCamaSimples.Text = _TipoQuartosSelecionado.QtdCamaSimples.ToString();
                TxtQtdCamaDupla.Text = _TipoQuartosSelecionado.QtdCamaDupla.ToString();

                BtnCadastrar.Enabled = false;
                BtnAlterar.Enabled = true;
                BtnExcluir.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
