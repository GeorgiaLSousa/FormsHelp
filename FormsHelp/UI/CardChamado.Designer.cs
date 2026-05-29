namespace FormsHelp.UI
{
    partial class CardChamado
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lbTitulo = new Label();
            lblDescricao = new Label();
            lblInfo = new Label();
            lblStatus = new Label();
            lblPrioridade = new Label();
            btnVerDetalhes = new Button();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lbTitulo
            // 
            lbTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Location = new Point(13, 11);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(840, 23);
            lbTitulo.TabIndex = 1;
            lbTitulo.Text = "Problema no sistema de login";
            // 
            // lblDescricao
            // 
            lblDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDescricao.BackColor = Color.Transparent;
            lblDescricao.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao.ForeColor = Color.White;
            lblDescricao.Location = new Point(13, 38);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(840, 38);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Usuários estão relatando dificuldade para acessar o sistema...";
            lblDescricao.Click += lblDescricao_Click;
            // 
            // lblInfo
            // 
            lblInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(13, 82);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(438, 17);
            lblInfo.TabIndex = 3;
            lblInfo.Text = "Maria     01/04/2026     Sistema";
            lblInfo.Click += lblInfo_Click;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatus.BackColor = Color.White;
            lblStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Blue;
            lblStatus.Location = new Point(998, 15);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(79, 22);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Aberto";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrioridade
            // 
            lblPrioridade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPrioridade.BackColor = Color.White;
            lblPrioridade.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrioridade.ForeColor = Color.Red;
            lblPrioridade.Location = new Point(998, 44);
            lblPrioridade.Name = "lblPrioridade";
            lblPrioridade.Size = new Size(79, 22);
            lblPrioridade.TabIndex = 5;
            lblPrioridade.Text = "Alta";
            lblPrioridade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVerDetalhes
            // 
            btnVerDetalhes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVerDetalhes.BackColor = Color.FromArgb(17, 27, 58);
            btnVerDetalhes.Cursor = Cursors.Hand;
            btnVerDetalhes.FlatAppearance.BorderColor = Color.FromArgb(220, 225, 235);
            btnVerDetalhes.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 40, 76);
            btnVerDetalhes.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 36, 70);
            btnVerDetalhes.FlatStyle = FlatStyle.Flat;
            btnVerDetalhes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerDetalhes.ForeColor = Color.White;
            btnVerDetalhes.Location = new Point(986, 77);
            btnVerDetalhes.Name = "btnVerDetalhes";
            btnVerDetalhes.Size = new Size(91, 26);
            btnVerDetalhes.TabIndex = 6;
            btnVerDetalhes.Text = "Detalhes";
            btnVerDetalhes.UseVisualStyleBackColor = false;
            btnVerDetalhes.Click += btnVerDetalhes_Click;
            // 
            // CardChamado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 27, 58);
            Controls.Add(btnVerDetalhes);
            Controls.Add(lblPrioridade);
            Controls.Add(lblStatus);
            Controls.Add(lblInfo);
            Controls.Add(lblDescricao);
            Controls.Add(lbTitulo);
            Margin = new Padding(0, 0, 0, 8);
            Name = "CardChamado";
            Size = new Size(1120, 116);
            Load += cardChamado_Load;
            Resize += CardChamado_Resize;
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Label lbTitulo;
        private Label lblDescricao;
        private Label lblInfo;
        private Label lblStatus;
        private Label lblPrioridade;
        private Button btnVerDetalhes;
    }
}
