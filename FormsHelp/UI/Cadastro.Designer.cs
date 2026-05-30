namespace FormsHelp.UI
{

    partial class Cadastro : Form
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            TB_Nome = new TextBox();
            TB_Email = new TextBox();
            TB_CPF = new TextBox();
            TB_Senha = new TextBox();
            BT_Cadastrar = new Button();
            panel4 = new Panel();
            PerfilLabel = new Label();
            CMB_Perfil = new ComboBox();
            Nome = new Label();
            Senha = new Label();
            CPF = new Label();
            Email = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 25, 47);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1195, 54);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(135, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(205, 20);
            label1.TabIndex = 2;
            label1.Text = "HelpDesk Pro System";
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 73);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(296, 290);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2;
            pictureBox1.Location = new Point(-16, 1);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // TB_Nome
            // 
            TB_Nome.Font = new Font("Microsoft Sans Serif", 12F);
            TB_Nome.Location = new Point(140, 112);
            TB_Nome.Margin = new Padding(2, 1, 2, 1);
            TB_Nome.Name = "TB_Nome";
            TB_Nome.Size = new Size(368, 26);
            TB_Nome.TabIndex = 0;
            TB_Nome.TextChanged += TB_Nome_TextChanged;
            // 
            // TB_Email
            // 
            TB_Email.Font = new Font("Microsoft Sans Serif", 12F);
            TB_Email.Location = new Point(140, 176);
            TB_Email.Margin = new Padding(2, 1, 2, 1);
            TB_Email.Name = "TB_Email";
            TB_Email.Size = new Size(368, 26);
            TB_Email.TabIndex = 1;
            // 
            // TB_CPF
            // 
            TB_CPF.Font = new Font("Microsoft Sans Serif", 12F);
            TB_CPF.Location = new Point(140, 240);
            TB_CPF.Margin = new Padding(2, 1, 2, 1);
            TB_CPF.Name = "TB_CPF";
            TB_CPF.Size = new Size(368, 26);
            TB_CPF.TabIndex = 2;
            // 
            // TB_Senha
            // 
            TB_Senha.Font = new Font("Microsoft Sans Serif", 12F);
            TB_Senha.Location = new Point(140, 304);
            TB_Senha.Margin = new Padding(2, 1, 2, 1);
            TB_Senha.Name = "TB_Senha";
            TB_Senha.Size = new Size(368, 26);
            TB_Senha.TabIndex = 3;
            // 
            // BT_Cadastrar
            // 
            BT_Cadastrar.BackColor = Color.FromArgb(18, 25, 47);
            BT_Cadastrar.FlatStyle = FlatStyle.Popup;
            BT_Cadastrar.Font = new Font("Microsoft Sans Serif", 12F);
            BT_Cadastrar.ForeColor = Color.White;
            BT_Cadastrar.Location = new Point(254, 432);
            BT_Cadastrar.Margin = new Padding(2, 1, 2, 1);
            BT_Cadastrar.Name = "BT_Cadastrar";
            BT_Cadastrar.Size = new Size(131, 32);
            BT_Cadastrar.TabIndex = 5;
            BT_Cadastrar.Text = "Cadastrar";
            BT_Cadastrar.UseVisualStyleBackColor = false;
            BT_Cadastrar.Click += BT_Cadastrar_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(PerfilLabel);
            panel4.Controls.Add(CMB_Perfil);
            panel4.Controls.Add(Nome);
            panel4.Controls.Add(BT_Cadastrar);
            panel4.Controls.Add(Senha);
            panel4.Controls.Add(CPF);
            panel4.Controls.Add(Email);
            panel4.Controls.Add(TB_Senha);
            panel4.Controls.Add(TB_CPF);
            panel4.Controls.Add(TB_Email);
            panel4.Controls.Add(TB_Nome);
            panel4.Font = new Font("Microsoft Sans Serif", 9F);
            panel4.Location = new Point(472, 54);
            panel4.Margin = new Padding(2, 1, 2, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(723, 522);
            panel4.TabIndex = 2;
            // 
            // PerfilLabel
            // 
            PerfilLabel.AutoSize = true;
            PerfilLabel.Font = new Font("Microsoft Sans Serif", 13F);
            PerfilLabel.Location = new Point(140, 342);
            PerfilLabel.Margin = new Padding(2, 0, 2, 0);
            PerfilLabel.Name = "PerfilLabel";
            PerfilLabel.Size = new Size(51, 22);
            PerfilLabel.TabIndex = 11;
            PerfilLabel.Text = "Perfil";
            // 
            // CMB_Perfil
            // 
            CMB_Perfil.DropDownStyle = ComboBoxStyle.DropDownList;
            CMB_Perfil.Font = new Font("Microsoft Sans Serif", 12F);
            CMB_Perfil.FormattingEnabled = true;
            CMB_Perfil.Items.AddRange(new object[] { "Cliente", "Analista" });
            CMB_Perfil.Location = new Point(140, 368);
            CMB_Perfil.Margin = new Padding(2, 1, 2, 1);
            CMB_Perfil.Name = "CMB_Perfil";
            CMB_Perfil.Size = new Size(368, 28);
            CMB_Perfil.TabIndex = 4;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Font = new Font("Microsoft Sans Serif", 13F);
            Nome.Location = new Point(140, 88);
            Nome.Margin = new Padding(2, 0, 2, 0);
            Nome.Name = "Nome";
            Nome.Size = new Size(57, 22);
            Nome.TabIndex = 9;
            Nome.Text = "Nome";
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Font = new Font("Microsoft Sans Serif", 13F);
            Senha.Location = new Point(140, 279);
            Senha.Margin = new Padding(2, 0, 2, 0);
            Senha.Name = "Senha";
            Senha.Size = new Size(62, 22);
            Senha.TabIndex = 6;
            Senha.Text = "Senha";
            // 
            // CPF
            // 
            CPF.AutoSize = true;
            CPF.Font = new Font("Microsoft Sans Serif", 13F);
            CPF.Location = new Point(140, 216);
            CPF.Margin = new Padding(2, 0, 2, 0);
            CPF.Name = "CPF";
            CPF.Size = new Size(46, 22);
            CPF.TabIndex = 5;
            CPF.Text = "CPF";
            CPF.Click += CPF_Click;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Microsoft Sans Serif", 13F);
            Email.Location = new Point(140, 152);
            Email.Margin = new Padding(2, 0, 2, 0);
            Email.Name = "Email";
            Email.Size = new Size(54, 22);
            Email.TabIndex = 4;
            Email.Text = "Email";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._1;
            pictureBox2.Location = new Point(83, 184);
            pictureBox2.Margin = new Padding(2, 1, 2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(306, 165);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(18, 25, 47);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(0, 54);
            panel3.Margin = new Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(472, 522);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(130, 120);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(247, 36);
            label2.TabIndex = 3;
            label2.Text = "Crie sua conta !!";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(98, 375);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(297, 20);
            label3.TabIndex = 2;
            label3.Text = "Preencha os dados abaixo para começar";
            label3.Click += label3_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 576);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "Cadastro";
            Text = "Cadastro";
            WindowState = FormWindowState.Maximized;
            Resize += Cadastro_Resize;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox TB_Nome;
        private TextBox TB_Email;
        private TextBox TB_CPF;
        private TextBox TB_Senha;
        private Button BT_Cadastrar;
        private Panel panel4;
        private Label Nome;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label1;
        private Label Senha;
        private Label CPF;
        private Label Email;
        private Label label2;
        private Label label3;
        private Label PerfilLabel;
        private ComboBox CMB_Perfil;
    }
}
