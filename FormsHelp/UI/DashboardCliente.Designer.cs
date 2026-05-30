namespace FormsHelp.UI
{
    partial class DashboardCliente : Form
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
            PB_IconeUsuario = new PictureBox();
            lbNomeUsuario = new Label();
            lbTituloSistema = new Label();
            PB_Logo = new PictureBox();
            lbTituloPagina = new Label();
            cmbStatus = new ComboBox();
            btNovoChamado = new Button();
            flowChamados = new FlowLayoutPanel();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_IconeUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_Logo).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(11, 22, 51);
            panelHeader.Controls.Add(PB_IconeUsuario);
            panelHeader.Controls.Add(lbNomeUsuario);
            panelHeader.Controls.Add(lbTituloSistema);
            panelHeader.Controls.Add(PB_Logo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1195, 105);
            panelHeader.TabIndex = 0;
            // 
            // PB_IconeUsuario
            // 
            PB_IconeUsuario.BackColor = Color.Transparent;
            PB_IconeUsuario.Dock = DockStyle.Right;
            PB_IconeUsuario.Location = new Point(1118, 0);
            PB_IconeUsuario.Name = "PB_IconeUsuario";
            PB_IconeUsuario.Size = new Size(77, 105);
            PB_IconeUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            PB_IconeUsuario.TabIndex = 3;
            PB_IconeUsuario.TabStop = false;
            // 
            // lbNomeUsuario
            // 
            lbNomeUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbNomeUsuario.AutoSize = true;
            lbNomeUsuario.BackColor = Color.Transparent;
            lbNomeUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNomeUsuario.ForeColor = Color.White;
            lbNomeUsuario.Location = new Point(1065, 44);
            lbNomeUsuario.Name = "lbNomeUsuario";
            lbNomeUsuario.Size = new Size(47, 20);
            lbNomeUsuario.TabIndex = 2;
            lbNomeUsuario.Text = "Maria";
            // 
            // lbTituloSistema
            // 
            lbTituloSistema.AutoSize = true;
            lbTituloSistema.BackColor = Color.Transparent;
            lbTituloSistema.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTituloSistema.ForeColor = Color.White;
            lbTituloSistema.Location = new Point(170, 34);
            lbTituloSistema.Name = "lbTituloSistema";
            lbTituloSistema.Size = new Size(241, 32);
            lbTituloSistema.TabIndex = 1;
            lbTituloSistema.Text = "HelpDesk Pro System";
            lbTituloSistema.Click += lbTituloSistema_Click;
            // 
            // PB_Logo
            // 
            PB_Logo.BackColor = Color.Transparent;
            PB_Logo.Dock = DockStyle.Left;
            PB_Logo.Image = Properties.Resources._2;
            PB_Logo.Location = new Point(0, 0);
            PB_Logo.Name = "PB_Logo";
            PB_Logo.Size = new Size(102, 105);
            PB_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            PB_Logo.TabIndex = 0;
            PB_Logo.TabStop = false;
            // 
            // lbTituloPagina
            // 
            lbTituloPagina.BackColor = Color.Transparent;
            lbTituloPagina.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTituloPagina.ForeColor = Color.FromArgb(30, 30, 30);
            lbTituloPagina.Location = new Point(35, 123);
            lbTituloPagina.Name = "lbTituloPagina";
            lbTituloPagina.Size = new Size(497, 34);
            lbTituloPagina.TabIndex = 1;
            lbTituloPagina.Text = "Acompanhar os meus chamados";
            lbTituloPagina.Click += lbTituloPagina_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Todos os status" });
            cmbStatus.Location = new Point(35, 159);
            cmbStatus.Margin = new Padding(3, 2, 3, 2);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(160, 27);
            cmbStatus.TabIndex = 2;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // btNovoChamado
            // 
            btNovoChamado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btNovoChamado.BackColor = Color.FromArgb(190, 190, 190);
            btNovoChamado.Cursor = Cursors.Hand;
            btNovoChamado.FlatAppearance.BorderSize = 0;
            btNovoChamado.FlatStyle = FlatStyle.Flat;
            btNovoChamado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btNovoChamado.ForeColor = Color.FromArgb(40, 40, 40);
            btNovoChamado.Location = new Point(968, 159);
            btNovoChamado.Margin = new Padding(3, 2, 3, 2);
            btNovoChamado.Name = "btNovoChamado";
            btNovoChamado.Size = new Size(175, 30);
            btNovoChamado.TabIndex = 3;
            btNovoChamado.Text = "+ Novo Chamado";
            btNovoChamado.UseVisualStyleBackColor = false;
            btNovoChamado.Click += btNovoChamado_Click;
            // 
            // flowChamados
            // 
            flowChamados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowChamados.AutoScroll = true;
            flowChamados.BackColor = Color.Transparent;
            flowChamados.FlowDirection = FlowDirection.TopDown;
            flowChamados.Location = new Point(35, 200);
            flowChamados.Margin = new Padding(3, 2, 3, 2);
            flowChamados.Name = "flowChamados";
            flowChamados.Size = new Size(1108, 371);
            flowChamados.TabIndex = 4;
            flowChamados.WrapContents = false;
            flowChamados.Paint += flowChamados_Paint;
            // 
            // DashboardCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 235);
            ClientSize = new Size(1195, 576);
            Controls.Add(flowChamados);
            Controls.Add(btNovoChamado);
            Controls.Add(cmbStatus);
            Controls.Add(lbTituloPagina);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardCliente";
            Text = "DashboardCliente";
            WindowState = FormWindowState.Maximized;
            Load += DashboardCliente_Load;
            Resize += DashboardCliente_Resize;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB_IconeUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private PictureBox PB_Logo;
        private Label lbNomeUsuario;
        private Label lbTituloSistema;
        private PictureBox PB_IconeUsuario;
        private Label lbTituloPagina;
        private ComboBox cmbStatus;
        private Button btNovoChamado;
        private FlowLayoutPanel flowChamados;
        private CardChamado cardChamado1;
        private CardChamado cardChamado2;
        private CardChamado cardChamado3;
    }
}
