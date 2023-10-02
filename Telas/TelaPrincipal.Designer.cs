namespace InovaTechSquadHotel.Telas
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSobre = new System.Windows.Forms.Button();
            this.BtnQuarto = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnReserva = new System.Windows.Forms.Button();
            this.BtnFuncionario = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TslUsuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TslEmailLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TslCargoLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.TslDataHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.TrmRelogio = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.BtnSobre);
            this.panel1.Controls.Add(this.BtnQuarto);
            this.panel1.Controls.Add(this.BtnSair);
            this.panel1.Controls.Add(this.BtnReserva);
            this.panel1.Controls.Add(this.BtnFuncionario);
            this.panel1.Controls.Add(this.BtnCliente);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 797);
            this.panel1.TabIndex = 0;
            // 
            // BtnSobre
            // 
            this.BtnSobre.BackColor = System.Drawing.Color.Transparent;
            this.BtnSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSobre.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSobre.FlatAppearance.BorderSize = 0;
            this.BtnSobre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnSobre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSobre.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnSobre.Image = ((System.Drawing.Image)(resources.GetObject("BtnSobre.Image")));
            this.BtnSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSobre.Location = new System.Drawing.Point(-6, 593);
            this.BtnSobre.Name = "BtnSobre";
            this.BtnSobre.Size = new System.Drawing.Size(221, 69);
            this.BtnSobre.TabIndex = 6;
            this.BtnSobre.Text = "Sobre";
            this.BtnSobre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSobre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSobre.UseVisualStyleBackColor = false;
            // 
            // BtnQuarto
            // 
            this.BtnQuarto.BackColor = System.Drawing.Color.Transparent;
            this.BtnQuarto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnQuarto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnQuarto.FlatAppearance.BorderSize = 0;
            this.BtnQuarto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnQuarto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuarto.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnQuarto.Image = ((System.Drawing.Image)(resources.GetObject("BtnQuarto.Image")));
            this.BtnQuarto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnQuarto.Location = new System.Drawing.Point(-6, 439);
            this.BtnQuarto.Name = "BtnQuarto";
            this.BtnQuarto.Size = new System.Drawing.Size(221, 71);
            this.BtnQuarto.TabIndex = 4;
            this.BtnQuarto.Text = "Quarto";
            this.BtnQuarto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnQuarto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnQuarto.UseVisualStyleBackColor = false;
            this.BtnQuarto.Click += new System.EventHandler(this.BtnQuarto_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.Transparent;
            this.BtnSair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSair.Location = new System.Drawing.Point(-3, 668);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(224, 74);
            this.BtnSair.TabIndex = 7;
            this.BtnSair.Text = "Sair";
            this.BtnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnReserva
            // 
            this.BtnReserva.BackColor = System.Drawing.Color.Transparent;
            this.BtnReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReserva.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnReserva.FlatAppearance.BorderSize = 0;
            this.BtnReserva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReserva.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnReserva.Image = ((System.Drawing.Image)(resources.GetObject("BtnReserva.Image")));
            this.BtnReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReserva.Location = new System.Drawing.Point(-3, 358);
            this.BtnReserva.Name = "BtnReserva";
            this.BtnReserva.Size = new System.Drawing.Size(221, 75);
            this.BtnReserva.TabIndex = 3;
            this.BtnReserva.Text = "Reserva";
            this.BtnReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReserva.UseVisualStyleBackColor = false;
            this.BtnReserva.Click += new System.EventHandler(this.BtnReserva_Click);
            // 
            // BtnFuncionario
            // 
            this.BtnFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.BtnFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFuncionario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnFuncionario.FlatAppearance.BorderSize = 0;
            this.BtnFuncionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFuncionario.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("BtnFuncionario.Image")));
            this.BtnFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFuncionario.Location = new System.Drawing.Point(0, 279);
            this.BtnFuncionario.Name = "BtnFuncionario";
            this.BtnFuncionario.Size = new System.Drawing.Size(218, 73);
            this.BtnFuncionario.TabIndex = 2;
            this.BtnFuncionario.Text = "Funcionário";
            this.BtnFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFuncionario.UseVisualStyleBackColor = false;
            this.BtnFuncionario.Click += new System.EventHandler(this.BtnFuncionario_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.BackColor = System.Drawing.Color.Transparent;
            this.BtnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCliente.FlatAppearance.BorderSize = 0;
            this.BtnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnCliente.Image")));
            this.BtnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCliente.Location = new System.Drawing.Point(-3, 200);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(218, 73);
            this.BtnCliente.TabIndex = 1;
            this.BtnCliente.Text = "Hospede";
            this.BtnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCliente.UseVisualStyleBackColor = false;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 194);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-17, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.TslUsuarioLogado,
            this.toolStripStatusLabel2,
            this.TslEmailLogado,
            this.toolStripStatusLabel3,
            this.TslCargoLogado,
            this.TslDataHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 775);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Usuário:";
            // 
            // TslUsuarioLogado
            // 
            this.TslUsuarioLogado.Name = "TslUsuarioLogado";
            this.TslUsuarioLogado.Size = new System.Drawing.Size(16, 17);
            this.TslUsuarioLogado.Text = "...";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel2.Text = "| E-mail:";
            // 
            // TslEmailLogado
            // 
            this.TslEmailLogado.Name = "TslEmailLogado";
            this.TslEmailLogado.Size = new System.Drawing.Size(16, 17);
            this.TslEmailLogado.Text = "...";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel3.Text = "| Cargo:";
            // 
            // TslCargoLogado
            // 
            this.TslCargoLogado.Name = "TslCargoLogado";
            this.TslCargoLogado.Size = new System.Drawing.Size(16, 17);
            this.TslCargoLogado.Text = "...";
            // 
            // TslDataHora
            // 
            this.TslDataHora.Name = "TslDataHora";
            this.TslDataHora.Size = new System.Drawing.Size(973, 17);
            this.TslDataHora.Spring = true;
            this.TslDataHora.Text = "10/10/2010 10:10:50";
            this.TslDataHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TrmRelogio
            // 
            this.TrmRelogio.Enabled = true;
            this.TrmRelogio.Tick += new System.EventHandler(this.TrmRelogio_Tick);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 797);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnReserva;
        private System.Windows.Forms.Button BtnFuncionario;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel TslUsuarioLogado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel TslEmailLogado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel TslCargoLogado;
        private System.Windows.Forms.ToolStripStatusLabel TslDataHora;
        private System.Windows.Forms.Timer TrmRelogio;
        private System.Windows.Forms.Button BtnQuarto;
        private System.Windows.Forms.Button BtnSobre;
    }
}