using FormsHelp.Models;
using FormsHelp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace FormsHelp.UI
{
    public partial class Cadastro : Form
    {
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private readonly UsuarioService _usuarioService = null!;

        public Cadastro()
        {
            InitializeComponent();
            ArredondarComponentes();
            CMB_Perfil.SelectedIndex = 0;
        }

        public Cadastro(UsuarioService usuarioService) : this()
        {
            _usuarioService = usuarioService;
        }

        private void ArredondarComponentes()
        {
            TB_Nome.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TB_Nome.Width, TB_Nome.Height, 15, 15));
            TB_Email.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TB_Email.Width, TB_Email.Height, 15, 15));
            TB_CPF.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TB_CPF.Width, TB_CPF.Height, 15, 15));
            TB_Senha.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TB_Senha.Width, TB_Senha.Height, 15, 15));
            BT_Cadastrar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BT_Cadastrar.Width, BT_Cadastrar.Height, 15, 15));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void CPF_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            CadastrarUsuario();
        }

        private void BT_Cadastrar_Click(object sender, EventArgs e)
        {
            CadastrarUsuario();
        }

        private void CadastrarUsuario()
        {
            if (string.IsNullOrWhiteSpace(TB_Nome.Text) || string.IsNullOrWhiteSpace(TB_Email.Text) ||
                string.IsNullOrWhiteSpace(TB_CPF.Text) || string.IsNullOrWhiteSpace(TB_Senha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var usuario = new Usuario
                {
                    Nome = TB_Nome.Text.Trim(),
                    Email = TB_Email.Text.Trim(),
                    CPF = TB_CPF.Text.Trim(),
                    Senha = TB_Senha.Text,
                    Perfil = ObterPerfilSelecionado()
                };

                _usuarioService.CriarUsuario(usuario);

                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TB_Nome.Clear();
                TB_Email.Clear();
                TB_CPF.Clear();
                TB_Senha.Clear();
                CMB_Perfil.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Perfil ObterPerfilSelecionado()
        {
            return CMB_Perfil.SelectedIndex == 1 ? Perfil.Analista : Perfil.Cliente;
        }

        private void TB_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cadastro_Resize(object sender, EventArgs e)
        {
            AjustarLayout();
        }

        private void AjustarLayout()
        {
            panel3.Width = Math.Max(420, (int)(ClientSize.Width * 0.4));
            panel3.Height = ClientSize.Height - panel1.Height;
            panel4.Left = panel3.Right;
            panel4.Top = panel1.Bottom;
            panel4.Width = ClientSize.Width - panel3.Width;
            panel4.Height = ClientSize.Height - panel1.Height;

            var larguraCampos = Math.Min(420, Math.Max(320, panel4.Width - 280));
            var esquerda = Math.Max(80, (panel4.Width - larguraCampos) / 2);

            Nome.Left = esquerda;
            TB_Nome.Left = esquerda;
            TB_Nome.Width = larguraCampos;
            Email.Left = esquerda;
            TB_Email.Left = esquerda;
            TB_Email.Width = larguraCampos;
            CPF.Left = esquerda;
            TB_CPF.Left = esquerda;
            TB_CPF.Width = larguraCampos;
            Senha.Left = esquerda;
            TB_Senha.Left = esquerda;
            TB_Senha.Width = larguraCampos;
            PerfilLabel.Left = esquerda;
            CMB_Perfil.Left = esquerda;
            CMB_Perfil.Width = larguraCampos;
            BT_Cadastrar.Left = esquerda + (larguraCampos - BT_Cadastrar.Width) / 2;

            pictureBox2.Left = Math.Max(40, (panel3.Width - pictureBox2.Width) / 2);
            label2.Left = Math.Max(40, (panel3.Width - label2.Width) / 2);
            label3.Left = Math.Max(40, (panel3.Width - label3.Width) / 2);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
