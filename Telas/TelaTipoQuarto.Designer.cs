namespace InovaTechSquadHotel.Telas
{
    partial class TelaTipoQuarto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbxAtivo = new System.Windows.Forms.CheckBox();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.LblInfoId = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.LblInfoDescricao = new System.Windows.Forms.Label();
            this.TxtQtdCamaDupla = new System.Windows.Forms.TextBox();
            this.LblInfoCamaDupla = new System.Windows.Forms.Label();
            this.TxtQdtCamaSimples = new System.Windows.Forms.TextBox();
            this.LblInfoCamaSimples = new System.Windows.Forms.Label();
            this.TxtTipoQuarto = new System.Windows.Forms.TextBox();
            this.LblInfoTipoDeQuarto = new System.Windows.Forms.Label();
            this.TxtCapacidade = new System.Windows.Forms.TextBox();
            this.LblInfoCapacidade = new System.Windows.Forms.Label();
            this.DgvRegistro = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CbxAtivo);
            this.groupBox1.Controls.Add(this.BtnFechar);
            this.groupBox1.Controls.Add(this.BtnNovo);
            this.groupBox1.Controls.Add(this.BtnExcluir);
            this.groupBox1.Controls.Add(this.BtnAlterar);
            this.groupBox1.Controls.Add(this.BtnCadastrar);
            this.groupBox1.Controls.Add(this.TxtDescricao);
            this.groupBox1.Controls.Add(this.LblInfoId);
            this.groupBox1.Controls.Add(this.LblId);
            this.groupBox1.Controls.Add(this.LblInfoDescricao);
            this.groupBox1.Controls.Add(this.TxtQtdCamaDupla);
            this.groupBox1.Controls.Add(this.LblInfoCamaDupla);
            this.groupBox1.Controls.Add(this.TxtQdtCamaSimples);
            this.groupBox1.Controls.Add(this.LblInfoCamaSimples);
            this.groupBox1.Controls.Add(this.TxtTipoQuarto);
            this.groupBox1.Controls.Add(this.LblInfoTipoDeQuarto);
            this.groupBox1.Controls.Add(this.TxtCapacidade);
            this.groupBox1.Controls.Add(this.LblInfoCapacidade);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // CbxAtivo
            // 
            this.CbxAtivo.AutoSize = true;
            this.CbxAtivo.Checked = true;
            this.CbxAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbxAtivo.Location = new System.Drawing.Point(506, 19);
            this.CbxAtivo.Name = "CbxAtivo";
            this.CbxAtivo.Size = new System.Drawing.Size(50, 17);
            this.CbxAtivo.TabIndex = 26;
            this.CbxAtivo.Text = "Ativo";
            this.CbxAtivo.UseVisualStyleBackColor = true;
            // 
            // BtnFechar
            // 
            this.BtnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFechar.Location = new System.Drawing.Point(615, 182);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(112, 24);
            this.BtnFechar.TabIndex = 25;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.Location = new System.Drawing.Point(615, 62);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(112, 24);
            this.BtnNovo.TabIndex = 24;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(615, 152);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(112, 24);
            this.BtnExcluir.TabIndex = 23;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterar.Location = new System.Drawing.Point(615, 122);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(112, 24);
            this.BtnAlterar.TabIndex = 22;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.Location = new System.Drawing.Point(615, 92);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(112, 24);
            this.BtnCadastrar.TabIndex = 21;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(358, 137);
            this.TxtDescricao.Multiline = true;
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(198, 21);
            this.TxtDescricao.TabIndex = 12;
            // 
            // LblInfoId
            // 
            this.LblInfoId.AutoSize = true;
            this.LblInfoId.Location = new System.Drawing.Point(71, 81);
            this.LblInfoId.Name = "LblInfoId";
            this.LblInfoId.Size = new System.Drawing.Size(16, 13);
            this.LblInfoId.TabIndex = 11;
            this.LblInfoId.Text = "Id";
            // 
            // LblId
            // 
            this.LblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblId.Location = new System.Drawing.Point(156, 68);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(100, 20);
            this.LblId.TabIndex = 10;
            // 
            // LblInfoDescricao
            // 
            this.LblInfoDescricao.AutoSize = true;
            this.LblInfoDescricao.Location = new System.Drawing.Point(296, 140);
            this.LblInfoDescricao.Name = "LblInfoDescricao";
            this.LblInfoDescricao.Size = new System.Drawing.Size(55, 13);
            this.LblInfoDescricao.TabIndex = 8;
            this.LblInfoDescricao.Text = "Descrição";
            // 
            // TxtQtdCamaDupla
            // 
            this.TxtQtdCamaDupla.Location = new System.Drawing.Point(456, 103);
            this.TxtQtdCamaDupla.Name = "TxtQtdCamaDupla";
            this.TxtQtdCamaDupla.Size = new System.Drawing.Size(100, 20);
            this.TxtQtdCamaDupla.TabIndex = 7;
            // 
            // LblInfoCamaDupla
            // 
            this.LblInfoCamaDupla.AutoSize = true;
            this.LblInfoCamaDupla.Location = new System.Drawing.Point(296, 110);
            this.LblInfoCamaDupla.Name = "LblInfoCamaDupla";
            this.LblInfoCamaDupla.Size = new System.Drawing.Size(135, 13);
            this.LblInfoCamaDupla.TabIndex = 6;
            this.LblInfoCamaDupla.Text = "Quantidade de cama dupla";
            // 
            // TxtQdtCamaSimples
            // 
            this.TxtQdtCamaSimples.Location = new System.Drawing.Point(456, 68);
            this.TxtQdtCamaSimples.Name = "TxtQdtCamaSimples";
            this.TxtQdtCamaSimples.Size = new System.Drawing.Size(100, 20);
            this.TxtQdtCamaSimples.TabIndex = 5;
            // 
            // LblInfoCamaSimples
            // 
            this.LblInfoCamaSimples.AutoSize = true;
            this.LblInfoCamaSimples.Location = new System.Drawing.Point(296, 75);
            this.LblInfoCamaSimples.Name = "LblInfoCamaSimples";
            this.LblInfoCamaSimples.Size = new System.Drawing.Size(138, 13);
            this.LblInfoCamaSimples.TabIndex = 4;
            this.LblInfoCamaSimples.Text = "Quantidae de Cama simples";
            // 
            // TxtTipoQuarto
            // 
            this.TxtTipoQuarto.Location = new System.Drawing.Point(156, 133);
            this.TxtTipoQuarto.Name = "TxtTipoQuarto";
            this.TxtTipoQuarto.Size = new System.Drawing.Size(100, 20);
            this.TxtTipoQuarto.TabIndex = 3;
            // 
            // LblInfoTipoDeQuarto
            // 
            this.LblInfoTipoDeQuarto.AutoSize = true;
            this.LblInfoTipoDeQuarto.Location = new System.Drawing.Point(71, 140);
            this.LblInfoTipoDeQuarto.Name = "LblInfoTipoDeQuarto";
            this.LblInfoTipoDeQuarto.Size = new System.Drawing.Size(76, 13);
            this.LblInfoTipoDeQuarto.TabIndex = 2;
            this.LblInfoTipoDeQuarto.Text = "Tipo de quarto";
            // 
            // TxtCapacidade
            // 
            this.TxtCapacidade.Location = new System.Drawing.Point(156, 103);
            this.TxtCapacidade.Name = "TxtCapacidade";
            this.TxtCapacidade.Size = new System.Drawing.Size(100, 20);
            this.TxtCapacidade.TabIndex = 1;
            // 
            // LblInfoCapacidade
            // 
            this.LblInfoCapacidade.AutoSize = true;
            this.LblInfoCapacidade.Location = new System.Drawing.Point(71, 110);
            this.LblInfoCapacidade.Name = "LblInfoCapacidade";
            this.LblInfoCapacidade.Size = new System.Drawing.Size(64, 13);
            this.LblInfoCapacidade.TabIndex = 0;
            this.LblInfoCapacidade.Text = "Capacidade";
            // 
            // DgvRegistro
            // 
            this.DgvRegistro.AllowUserToAddRows = false;
            this.DgvRegistro.AllowUserToDeleteRows = false;
            this.DgvRegistro.AllowUserToResizeRows = false;
            this.DgvRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRegistro.Location = new System.Drawing.Point(12, 271);
            this.DgvRegistro.MultiSelect = false;
            this.DgvRegistro.Name = "DgvRegistro";
            this.DgvRegistro.ReadOnly = true;
            this.DgvRegistro.RowHeadersVisible = false;
            this.DgvRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRegistro.Size = new System.Drawing.Size(776, 167);
            this.DgvRegistro.TabIndex = 8;
            this.DgvRegistro.SelectionChanged += new System.EventHandler(this.DgvRegistro_SelectionChanged);
            // 
            // TelaTipoQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvRegistro);
            this.Controls.Add(this.groupBox1);
            this.Name = "TelaTipoQuarto";
            this.Text = "TelaTipoQuarto";
            this.Load += new System.EventHandler(this.TelaTipoQuarto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtQdtCamaSimples;
        private System.Windows.Forms.Label LblInfoCamaSimples;
        private System.Windows.Forms.TextBox TxtTipoQuarto;
        private System.Windows.Forms.Label LblInfoTipoDeQuarto;
        private System.Windows.Forms.TextBox TxtCapacidade;
        private System.Windows.Forms.Label LblInfoCapacidade;
        private System.Windows.Forms.DataGridView DgvRegistro;
        private System.Windows.Forms.Label LblInfoDescricao;
        private System.Windows.Forms.TextBox TxtQtdCamaDupla;
        private System.Windows.Forms.Label LblInfoCamaDupla;
        private System.Windows.Forms.Label LblInfoId;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.CheckBox CbxAtivo;
    }
}