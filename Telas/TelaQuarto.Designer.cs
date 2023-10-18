namespace InovaTechSquadHotel.Telas
{
    partial class TelaQuarto
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbxTipoQuarto = new System.Windows.Forms.ComboBox();
            this.LblIdQuarto = new System.Windows.Forms.Label();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.LblInfoValorDiaria = new System.Windows.Forms.Label();
            this.LblInfoNAndar = new System.Windows.Forms.Label();
            this.LblInfoNquarto = new System.Windows.Forms.Label();
            this.TxtValorDiaria = new System.Windows.Forms.TextBox();
            this.TxtNAndar = new System.Windows.Forms.TextBox();
            this.TxtNquarto = new System.Windows.Forms.TextBox();
            this.DgvRegistro = new System.Windows.Forms.DataGridView();
            this.tipoQuartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoQuartoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbxTipoQuarto);
            this.groupBox1.Controls.Add(this.LblIdQuarto);
            this.groupBox1.Controls.Add(this.BtnNovo);
            this.groupBox1.Controls.Add(this.BtnAlterar);
            this.groupBox1.Controls.Add(this.BtnExcluir);
            this.groupBox1.Controls.Add(this.BtnFechar);
            this.groupBox1.Controls.Add(this.BtnCadastrar);
            this.groupBox1.Controls.Add(this.LblInfoValorDiaria);
            this.groupBox1.Controls.Add(this.LblInfoNAndar);
            this.groupBox1.Controls.Add(this.LblInfoNquarto);
            this.groupBox1.Controls.Add(this.TxtValorDiaria);
            this.groupBox1.Controls.Add(this.TxtNAndar);
            this.groupBox1.Controls.Add(this.TxtNquarto);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // CbxTipoQuarto
            // 
            this.CbxTipoQuarto.DataSource = this.tipoQuartoBindingSource;
            this.CbxTipoQuarto.DisplayMember = "Descricao";
            this.CbxTipoQuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTipoQuarto.FormattingEnabled = true;
            this.CbxTipoQuarto.Location = new System.Drawing.Point(408, 101);
            this.CbxTipoQuarto.Name = "CbxTipoQuarto";
            this.CbxTipoQuarto.Size = new System.Drawing.Size(121, 21);
            this.CbxTipoQuarto.TabIndex = 12;
            // 
            // LblIdQuarto
            // 
            this.LblIdQuarto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblIdQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdQuarto.Location = new System.Drawing.Point(30, 101);
            this.LblIdQuarto.Name = "LblIdQuarto";
            this.LblIdQuarto.Size = new System.Drawing.Size(100, 24);
            this.LblIdQuarto.TabIndex = 11;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(276, 102);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 23);
            this.BtnNovo.TabIndex = 10;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(183, 102);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 9;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(183, 155);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 8;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(478, 155);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 7;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(276, 155);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 6;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // LblInfoValorDiaria
            // 
            this.LblInfoValorDiaria.AutoSize = true;
            this.LblInfoValorDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoValorDiaria.Location = new System.Drawing.Point(404, 20);
            this.LblInfoValorDiaria.Name = "LblInfoValorDiaria";
            this.LblInfoValorDiaria.Size = new System.Drawing.Size(130, 24);
            this.LblInfoValorDiaria.TabIndex = 5;
            this.LblInfoValorDiaria.Text = "Valor da diaria";
            // 
            // LblInfoNAndar
            // 
            this.LblInfoNAndar.AutoSize = true;
            this.LblInfoNAndar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoNAndar.Location = new System.Drawing.Point(218, 20);
            this.LblInfoNAndar.Name = "LblInfoNAndar";
            this.LblInfoNAndar.Size = new System.Drawing.Size(88, 24);
            this.LblInfoNAndar.TabIndex = 4;
            this.LblInfoNAndar.Text = "N° andar:";
            // 
            // LblInfoNquarto
            // 
            this.LblInfoNquarto.AutoSize = true;
            this.LblInfoNquarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoNquarto.Location = new System.Drawing.Point(37, 20);
            this.LblInfoNquarto.Name = "LblInfoNquarto";
            this.LblInfoNquarto.Size = new System.Drawing.Size(93, 24);
            this.LblInfoNquarto.TabIndex = 3;
            this.LblInfoNquarto.Text = "N° quarto:";
            // 
            // TxtValorDiaria
            // 
            this.TxtValorDiaria.Location = new System.Drawing.Point(408, 59);
            this.TxtValorDiaria.Name = "TxtValorDiaria";
            this.TxtValorDiaria.Size = new System.Drawing.Size(100, 20);
            this.TxtValorDiaria.TabIndex = 2;
            // 
            // TxtNAndar
            // 
            this.TxtNAndar.Location = new System.Drawing.Point(222, 59);
            this.TxtNAndar.Name = "TxtNAndar";
            this.TxtNAndar.Size = new System.Drawing.Size(100, 20);
            this.TxtNAndar.TabIndex = 1;
            // 
            // TxtNquarto
            // 
            this.TxtNquarto.Location = new System.Drawing.Point(30, 59);
            this.TxtNquarto.Name = "TxtNquarto";
            this.TxtNquarto.Size = new System.Drawing.Size(100, 20);
            this.TxtNquarto.TabIndex = 0;
            // 
            // DgvRegistro
            // 
            this.DgvRegistro.AllowUserToAddRows = false;
            this.DgvRegistro.AllowUserToDeleteRows = false;
            this.DgvRegistro.AllowUserToResizeRows = false;
            this.DgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRegistro.Location = new System.Drawing.Point(12, 219);
            this.DgvRegistro.MultiSelect = false;
            this.DgvRegistro.Name = "DgvRegistro";
            this.DgvRegistro.ReadOnly = true;
            this.DgvRegistro.RowHeadersVisible = false;
            this.DgvRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRegistro.Size = new System.Drawing.Size(559, 219);
            this.DgvRegistro.TabIndex = 7;
            this.DgvRegistro.SelectionChanged += new System.EventHandler(this.DgvRegistro_SelectionChanged);
            // 
            // tipoQuartoBindingSource
            // 
            this.tipoQuartoBindingSource.DataSource = typeof(InovaTechSquadHotel.Classes.TipoQuarto);
            // 
            // TelaQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 450);
            this.Controls.Add(this.DgvRegistro);
            this.Controls.Add(this.groupBox1);
            this.Name = "TelaQuarto";
            this.Text = "TelaQuartos";
            this.Load += new System.EventHandler(this.TelaQuartos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoQuartoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblInfoValorDiaria;
        private System.Windows.Forms.Label LblInfoNAndar;
        private System.Windows.Forms.Label LblInfoNquarto;
        private System.Windows.Forms.TextBox TxtValorDiaria;
        private System.Windows.Forms.TextBox TxtNAndar;
        private System.Windows.Forms.TextBox TxtNquarto;
        private System.Windows.Forms.DataGridView DgvRegistro;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Label LblIdQuarto;
        private System.Windows.Forms.ComboBox CbxTipoQuarto;
        private System.Windows.Forms.BindingSource tipoQuartoBindingSource;
    }
}