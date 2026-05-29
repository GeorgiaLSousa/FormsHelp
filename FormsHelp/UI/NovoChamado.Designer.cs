namespace FormsHelp.UI
{
    partial class NovoChamado
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
            panelHeader = new Panel();
            lbSistema = new Label();
            pctLogo = new PictureBox();
            panel1 = new Panel();
            picAjuda = new PictureBox();
            lbAjuda = new Label();
            panelConteudo = new Panel();
            panelForm = new Panel();
            btnConfirmar = new Button();
            cmbCategoria = new ComboBox();
            cmbPrioridade = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txbDescricao = new TextBox();
            lbDescricao = new Label();
            txbTitulo = new TextBox();
            lbTitulo = new Label();
            lbAbraChamado = new Label();
            lbVoltar = new Label();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctLogo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAjuda).BeginInit();
            panelConteudo.SuspendLayout();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(17, 27, 58);
            panelHeader.Controls.Add(lbSistema);
            panelHeader.Controls.Add(pctLogo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1180, 49);
            panelHeader.TabIndex = 0;
            // 
            // lbSistema
            // 
            lbSistema.BackColor = Color.Transparent;
            lbSistema.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSistema.ForeColor = Color.White;
            lbSistema.Location = new Point(132, 9);
            lbSistema.Name = "lbSistema";
            lbSistema.Size = new Size(184, 27);
            lbSistema.TabIndex = 1;
            lbSistema.Text = "HelpDesk Pro System";
            // 
            // pctLogo
            // 
            pctLogo.Dock = DockStyle.Left;
            pctLogo.Location = new Point(0, 0);
            pctLogo.Margin = new Padding(3, 2, 3, 2);
            pctLogo.Name = "pctLogo";
            pctLogo.Size = new Size(96, 49);
            pctLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pctLogo.TabIndex = 0;
            pctLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 27, 58);
            panel1.Controls.Add(picAjuda);
            panel1.Controls.Add(lbAjuda);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 49);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 492);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // picAjuda
            // 
            picAjuda.Location = new Point(66, 135);
            picAjuda.Margin = new Padding(3, 2, 3, 2);
            picAjuda.Name = "picAjuda";
            picAjuda.Size = new Size(263, 151);
            picAjuda.SizeMode = PictureBoxSizeMode.Zoom;
            picAjuda.TabIndex = 3;
            picAjuda.TabStop = false;
            // 
            // lbAjuda
            // 
            lbAjuda.AutoSize = true;
            lbAjuda.BackColor = Color.Transparent;
            lbAjuda.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAjuda.ForeColor = Color.White;
            lbAjuda.Location = new Point(101, 75);
            lbAjuda.Name = "lbAjuda";
            lbAjuda.Size = new Size(192, 25);
            lbAjuda.TabIndex = 2;
            lbAjuda.Text = "Precisando de ajuda?";
            // 
            // panelConteudo
            // 
            panelConteudo.Controls.Add(panelForm);
            panelConteudo.Controls.Add(lbVoltar);
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(376, 49);
            panelConteudo.Margin = new Padding(3, 2, 3, 2);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(804, 492);
            panelConteudo.TabIndex = 2;
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.FromArgb(17, 27, 58);
            panelForm.Controls.Add(btnConfirmar);
            panelForm.Controls.Add(cmbCategoria);
            panelForm.Controls.Add(cmbPrioridade);
            panelForm.Controls.Add(label3);
            panelForm.Controls.Add(label2);
            panelForm.Controls.Add(txbDescricao);
            panelForm.Controls.Add(lbDescricao);
            panelForm.Controls.Add(txbTitulo);
            panelForm.Controls.Add(lbTitulo);
            panelForm.Controls.Add(lbAbraChamado);
            panelForm.Location = new Point(178, 18);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(449, 439);
            panelForm.TabIndex = 2;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(0, 80, 160);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(202, 387);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(100, 30);
            btnConfirmar.TabIndex = 13;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Sistema", "Hardware", "Rede", "Software", "Acesso", "Outro" });
            cmbCategoria.Location = new Point(65, 303);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(351, 23);
            cmbCategoria.TabIndex = 12;
            // 
            // cmbPrioridade
            // 
            cmbPrioridade.FormattingEnabled = true;
            cmbPrioridade.Items.AddRange(new object[] { "Baixa", "Média", "Alta", "Urgente" });
            cmbPrioridade.Location = new Point(65, 233);
            cmbPrioridade.Name = "cmbPrioridade";
            cmbPrioridade.Size = new Size(351, 23);
            cmbPrioridade.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(65, 283);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 10;
            label3.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(65, 213);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 8;
            label2.Text = "Prioridade";
            // 
            // txbDescricao
            // 
            txbDescricao.Location = new Point(65, 162);
            txbDescricao.Name = "txbDescricao";
            txbDescricao.Size = new Size(351, 23);
            txbDescricao.TabIndex = 7;
            // 
            // lbDescricao
            // 
            lbDescricao.AutoSize = true;
            lbDescricao.BackColor = Color.Transparent;
            lbDescricao.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDescricao.ForeColor = Color.White;
            lbDescricao.Location = new Point(65, 142);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(143, 17);
            lbDescricao.TabIndex = 6;
            lbDescricao.Text = "Descrição do chamado";
            // 
            // txbTitulo
            // 
            txbTitulo.Location = new Point(65, 96);
            txbTitulo.Name = "txbTitulo";
            txbTitulo.Size = new Size(351, 23);
            txbTitulo.TabIndex = 5;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.BackColor = Color.Transparent;
            lbTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Location = new Point(65, 76);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(40, 17);
            lbTitulo.TabIndex = 4;
            lbTitulo.Text = "Título";
            // 
            // lbAbraChamado
            // 
            lbAbraChamado.AutoSize = true;
            lbAbraChamado.BackColor = Color.Transparent;
            lbAbraChamado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAbraChamado.ForeColor = Color.White;
            lbAbraChamado.Location = new Point(148, 19);
            lbAbraChamado.Name = "lbAbraChamado";
            lbAbraChamado.Size = new Size(139, 21);
            lbAbraChamado.TabIndex = 3;
            lbAbraChamado.Text = "Abra seu chamado";
            // 
            // lbVoltar
            // 
            lbVoltar.AutoSize = true;
            lbVoltar.Cursor = Cursors.Hand;
            lbVoltar.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbVoltar.Location = new Point(54, 18);
            lbVoltar.Name = "lbVoltar";
            lbVoltar.Size = new Size(48, 45);
            lbVoltar.TabIndex = 0;
            lbVoltar.Text = "←";
            lbVoltar.Click += lbVoltar_Click_1;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // NovoChamado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 541);
            Controls.Add(panelConteudo);
            Controls.Add(panel1);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "NovoChamado";
            Text = "NovoChamado";
            WindowState = FormWindowState.Maximized;
            Load += NovoChamado_Load;
            Resize += NovoChamado_Resize;
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAjuda).EndInit();
            panelConteudo.ResumeLayout(false);
            panelConteudo.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private PictureBox pctLogo;
        private Label lbSistema;
        private Panel panel1;
        private PictureBox picAjuda;
        private Label lbAjuda;
        private Panel panelConteudo;
        private Label lbVoltar;
        private Panel panelForm;
        private Button btnConfirmar;
        private ComboBox cmbCategoria;
        private ComboBox cmbPrioridade;
        private Label label3;
        private Label label2;
        private TextBox txbDescricao;
        private Label lbDescricao;
        private TextBox txbTitulo;
        private Label lbTitulo;
        private Label lbAbraChamado;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
    }
}
