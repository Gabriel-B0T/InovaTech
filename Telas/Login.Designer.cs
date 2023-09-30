namespace InovaTechSquadHotel
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblSenha = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblTxt = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtSenha);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.LblSenha);
            this.groupBox1.Controls.Add(this.BtnSair);
            this.groupBox1.Controls.Add(this.BtnEntrar);
            this.groupBox1.Controls.Add(this.LblEmail);
            this.groupBox1.Controls.Add(this.LblTxt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(195, 203);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(265, 29);
            this.TxtSenha.TabIndex = 6;
            this.TxtSenha.Text = "1";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(195, 131);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(265, 29);
            this.TxtEmail.TabIndex = 5;
            this.TxtEmail.Text = "gabriel";
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Location = new System.Drawing.Point(56, 203);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(70, 24);
            this.LblSenha.TabIndex = 4;
            this.LblSenha.Text = "Senha";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(113, 297);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(123, 33);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Location = new System.Drawing.Point(371, 297);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(123, 33);
            this.BtnEntrar.TabIndex = 2;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = true;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(56, 134);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(62, 24);
            this.LblEmail.TabIndex = 1;
            this.LblEmail.Text = "Email";
            // 
            // LblTxt
            // 
            this.LblTxt.AutoSize = true;
            this.LblTxt.Location = new System.Drawing.Point(196, 24);
            this.LblTxt.Name = "LblTxt";
            this.LblTxt.Size = new System.Drawing.Size(208, 24);
            this.LblTxt.TabIndex = 0;
            this.LblTxt.Text = "Acesso Golden Hotel";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 403);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Tela Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblTxt;
    }
}

