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
            btnAbertos = new Button();
            btnMeusAtendimentos = new Button();
            flowChamados = new FlowLayoutPanel();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
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
            panelHeader.Paint += panelHeader_Paint;
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
            lblUsuario.Location = new Point(1001, 50);
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
            picLogo.Image = Properties.Resources._2;
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
            // btnAbertos
            // 
            btnAbertos.BackColor = Color.FromArgb(17, 27, 58);
            btnAbertos.Cursor = Cursors.Hand;
            btnAbertos.FlatAppearance.BorderColor = Color.FromArgb(220, 225, 235);
            btnAbertos.FlatStyle = FlatStyle.Flat;
            btnAbertos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAbertos.ForeColor = Color.White;
            btnAbertos.Location = new Point(35, 180);
            btnAbertos.Name = "btnAbertos";
            btnAbertos.Size = new Size(160, 30);
            btnAbertos.TabIndex = 5;
            btnAbertos.Text = "Abertos";
            btnAbertos.UseVisualStyleBackColor = false;
            btnAbertos.Click += btnAbertos_Click;
            // 
            // btnMeusAtendimentos
            // 
            btnMeusAtendimentos.BackColor = Color.FromArgb(17, 27, 58);
            btnMeusAtendimentos.Cursor = Cursors.Hand;
            btnMeusAtendimentos.FlatAppearance.BorderColor = Color.FromArgb(220, 225, 235);
            btnMeusAtendimentos.FlatStyle = FlatStyle.Flat;
            btnMeusAtendimentos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMeusAtendimentos.ForeColor = Color.White;
            btnMeusAtendimentos.Location = new Point(211, 180);
            btnMeusAtendimentos.Name = "btnMeusAtendimentos";
            btnMeusAtendimentos.Size = new Size(170, 30);
            btnMeusAtendimentos.TabIndex = 6;
            btnMeusAtendimentos.Text = "Meus Atendimentos";
            btnMeusAtendimentos.UseVisualStyleBackColor = false;
            btnMeusAtendimentos.Click += btnMeusAtendimentos_Click;
            // 
            // flowChamados
            // 
            flowChamados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowChamados.AutoScroll = true;
            flowChamados.FlowDirection = FlowDirection.TopDown;
            flowChamados.Location = new Point(35, 225);
            flowChamados.Name = "flowChamados";
            flowChamados.Size = new Size(1123, 352);
            flowChamados.TabIndex = 7;
            flowChamados.WrapContents = false;
            // 
            // DashboardAnalista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 600);
            Controls.Add(flowChamados);
            Controls.Add(btnMeusAtendimentos);
            Controls.Add(btnAbertos);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
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
        private Button btnAbertos;
        private Button btnMeusAtendimentos;
        private FlowLayoutPanel flowChamados;
    }
}