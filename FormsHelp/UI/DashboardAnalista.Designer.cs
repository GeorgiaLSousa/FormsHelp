namespace FormsHelp.UI 
{ 
    partial class DashboardAnalista : Form
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
            pictureBox1 = new PictureBox();
            lblUsuario = new Label();
            lblTituloSistema = new Label();
            picLogo = new PictureBox();
            lblTituloPagina = new Label();
            cmbStatus = new ComboBox();
            cmbAtendimento = new ComboBox();
            flowChamados = new FlowLayoutPanel();
            cardChamado1 = new CardChamado();
            cardChamado2 = new CardChamado();
            cardChamado3 = new CardChamado();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            flowChamados.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(11, 22, 51);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(lblUsuario);
            panelHeader.Controls.Add(lblTituloSistema);
            panelHeader.Controls.Add(picLogo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1195, 105);
            panelHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Location = new Point(1117, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(1034, 50);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(86, 17);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Geórgia Ligia";
            // 
            // lblTituloSistema
            // 
            lblTituloSistema.AutoSize = true;
            lblTituloSistema.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloSistema.ForeColor = Color.White;
            lblTituloSistema.Location = new Point(200, 38);
            lblTituloSistema.Name = "lblTituloSistema";
            lblTituloSistema.Size = new Size(248, 32);
            lblTituloSistema.TabIndex = 1;
            lblTituloSistema.Text = " HelpDesk Pro System";
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Left;
            picLogo.Location = new Point(0, 0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(120, 105);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblTituloPagina
            // 
            lblTituloPagina.AutoSize = true;
            lblTituloPagina.BackColor = Color.Transparent;
            lblTituloPagina.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloPagina.ForeColor = Color.FromArgb(30, 30, 30);
            lblTituloPagina.Location = new Point(35, 135);
            lblTituloPagina.Name = "lblTituloPagina";
            lblTituloPagina.Size = new Size(133, 32);
            lblTituloPagina.TabIndex = 4;
            lblTituloPagina.Text = " Chamados";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Todos os status", "Aberto", "Em progresso", "Fechado" });
            cmbStatus.Location = new Point(35, 180);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(160, 25);
            cmbStatus.TabIndex = 5;
            // 
            // cmbAtendimento
            // 
            cmbAtendimento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAtendimento.FlatStyle = FlatStyle.Flat;
            cmbAtendimento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAtendimento.FormattingEnabled = true;
            cmbAtendimento.Items.AddRange(new object[] { "Todos", "Meus atendimento" });
            cmbAtendimento.Location = new Point(215, 180);
            cmbAtendimento.Name = "cmbAtendimento";
            cmbAtendimento.Size = new Size(170, 25);
            cmbAtendimento.TabIndex = 6;
            // 
            // flowChamados
            // 
            flowChamados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowChamados.AutoScroll = true;
            flowChamados.Controls.Add(cardChamado1);
            flowChamados.Controls.Add(cardChamado2);
            flowChamados.Controls.Add(cardChamado3);
            flowChamados.FlowDirection = FlowDirection.TopDown;
            flowChamados.Location = new Point(35, 211);
            flowChamados.Name = "flowChamados";
            flowChamados.Size = new Size(1123, 366);
            flowChamados.TabIndex = 7;
            flowChamados.WrapContents = false;
            // 
            // cardChamado1
            // 
            cardChamado1.BackColor = Color.FromArgb(17, 27, 58);
            cardChamado1.Location = new Point(0, 0);
            cardChamado1.Margin = new Padding(0, 0, 0, 8);
            cardChamado1.Name = "cardChamado1";
            cardChamado1.Size = new Size(1120, 116);
            cardChamado1.TabIndex = 0;
            // 
            // cardChamado2
            // 
            cardChamado2.BackColor = Color.FromArgb(17, 27, 58);
            cardChamado2.Location = new Point(0, 124);
            cardChamado2.Margin = new Padding(0, 0, 0, 8);
            cardChamado2.Name = "cardChamado2";
            cardChamado2.Size = new Size(1120, 116);
            cardChamado2.TabIndex = 1;
            cardChamado2.Load += CardChamado2_Load;
            // 
            // cardChamado3
            // 
            cardChamado3.BackColor = Color.FromArgb(17, 27, 58);
            cardChamado3.Location = new Point(0, 248);
            cardChamado3.Margin = new Padding(0, 0, 0, 8);
            cardChamado3.Name = "cardChamado3";
            cardChamado3.Size = new Size(1120, 116);
            cardChamado3.TabIndex = 2;
            // 
            // DashboardAnalista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 576);
            Controls.Add(flowChamados);
            Controls.Add(cmbAtendimento);
            Controls.Add(cmbStatus);
            Controls.Add(lblTituloPagina);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "DashboardAnalista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardAnalista";
            WindowState = FormWindowState.Maximized;
            Load += DashboardAnalista_Load;
            Resize += DashboardAnalista_Resize;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
//            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            flowChamados.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private PictureBox pictureBox1;
        private Label lblUsuario;
        private Label lblTituloSistema;
        private PictureBox picLogo;
        private Label lblTituloPagina;
        private ComboBox cmbStatus;
        private ComboBox cmbAtendimento;
        private FlowLayoutPanel flowChamados;
        private CardChamado cardChamado1;
        private CardChamado cardChamado2;
        private CardChamado cardChamado3;
    }
}
