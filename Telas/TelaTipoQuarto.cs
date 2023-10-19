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
        public void ConfigurarDgvTipoQuarto()
        {
            //Criação de colunas no DvgRegistro
            DgvRegistroTipoQuarto.Columns.Add("Id", "Numero de registro");
            DgvRegistroTipoQuarto.Columns.Add("Capacidade", "Capacidade");
            DgvRegistroTipoQuarto.Columns.Add("Descricao", "Descrição");
            DgvRegistroTipoQuarto.Columns.Add("TipoQuarto", "Tipo de quarto");
            DgvRegistroTipoQuarto.Columns.Add("Ativo", "Ativo");
            DgvRegistroTipoQuarto.Columns.Add("QdtCamaSimples", "Quantidade de cama simples");
            DgvRegistroTipoQuarto.Columns.Add("QtdCamaDupla", "Quantidade de cama dupla");
         

            //Configuração dos alinhamentos de cada coluna do DgvRegistro
            DgvRegistroTipoQuarto.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistroTipoQuarto.Columns["Capacidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistroTipoQuarto.Columns["Descricao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistroTipoQuarto.Columns["TipoQuarto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistroTipoQuarto.Columns["Ativo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistroTipoQuarto.Columns["QdtCamaSimples"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRegistroTipoQuarto.Columns["QtdCamaDupla"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            //Configuração dos tamanhos de cada coluna do DgvRegistro

            DgvRegistroTipoQuarto.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvRegistroTipoQuarto.Columns["Capacidade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvRegistroTipoQuarto.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvRegistroTipoQuarto.Columns["TipoQuarto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvRegistroTipoQuarto.Columns["Ativo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvRegistroTipoQuarto.Columns["QdtCamaSimples"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvRegistroTipoQuarto.Columns["QtdCamaDupla"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
   

            //Configurar tamanho em altura de colunas e linhas
            DgvRegistroTipoQuarto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DgvRegistroTipoQuarto.ColumnHeadersHeight = 35;
            DgvRegistroTipoQuarto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //Definindo uma cor para intercalar linhas
            DgvRegistroTipoQuarto.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }
        private void CarregarDgvTipoQuarto(List<TipoQuarto> tipoQuartos = null)
        {
            //Método para carregar o DvgUsuarios com os dados da List

            DgvRegistroTipoQuarto.Rows.Clear();

            foreach (TipoQuarto tipoQuarto in tipoQuartos ?? _tipoQuartos)
            {
                DgvRegistroTipoQuarto.Rows.Add(tipoQuarto.Id, tipoQuarto.Capacidade, tipoQuarto.Descricao, tipoQuarto.TipoQuartos,tipoQuarto.Ativo, tipoQuarto.QtdCamaSimples, tipoQuarto.QdtCamaDupla);
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
            DgvRegistroTipoQuarto.ClearSelection();
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
                CarregarDgvTipoQuarto();
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
                ConfigurarDgvTipoQuarto();
                CarregarDgvTipoQuarto();
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
                _TipoQuartosSelecionado.QdtCamaDupla = Convert.ToInt32(TxtQtdCamaDupla.Text);

                _TipoQuartosSelecionado.AlterarTipoQuarto();
                CarregarDgvTipoQuarto();
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
                    _tipoQuartos.RemoveAt(_tipoQuartos.FindIndex(a => a.Id == (int)DgvRegistroTipoQuarto.SelectedRows[0].Cells[0].Value));
                    CarregarDgvTipoQuarto();
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

        private void DgvRegistroTipoQuarto_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvRegistroTipoQuarto.Rows.Count < 1 || DgvRegistroTipoQuarto.SelectedRows.Count < 1)
                return;

            try
            {
                _TipoQuartosSelecionado = _tipoQuartos.Find(a => a.Id == (int)DgvRegistroTipoQuarto.SelectedRows[0].Cells[0].Value);
                LblId.Text = _TipoQuartosSelecionado.Id.ToString();
                TxtCapacidade.Text = _TipoQuartosSelecionado.Capacidade.ToString();
                TxtDescricao.Text = _TipoQuartosSelecionado.Descricao;
                TxtTipoQuarto.Text = _TipoQuartosSelecionado.TipoQuartos;
                CbxAtivo.Text = _TipoQuartosSelecionado.Ativo.ToString();
                TxtQdtCamaSimples.Text = _TipoQuartosSelecionado.QtdCamaSimples.ToString();
                TxtQtdCamaDupla.Text = _TipoQuartosSelecionado.QdtCamaDupla.ToString();

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
