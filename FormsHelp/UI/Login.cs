using FormsHelp.Models;
using FormsHelp.Services;
using FormsHelp.Sessao;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection.Emit;

namespace FormsHelp.UI
{
    public partial class Login : Form
    {
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private readonly UsuarioService _usuarioService = null!;
        private readonly IServiceProvider _serviceProvider = null!;

        // ✅ Construtor com DI (principal)
        public Login(UsuarioService usuarioService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
            _serviceProvider = serviceProvider;

            ArredondarComponentes();
        }

        // ✅ Construtor vazio (necessário pro Designer)
        public Login()
        {
            InitializeComponent();
        }


        private void ArredondarComponentes()
        {
            EmailText.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, EmailText.Width, EmailText.Height, 15, 15));
            SenhaText.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, SenhaText.Width, SenhaText.Height, 15, 15));
            Entrar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Entrar.Width, Entrar.Height, 15, 15));
        }
        private void label5_Click(object sender, EventArgs e)
        {

            // Cria uma nova instância da sua tela de cadastro
            Cadastro telaDeCadastro = _serviceProvider.GetRequiredService<Cadastro>();

            // Mostra a tela de cadastro
            telaDeCadastro.Show();

            // Esconde a tela de login atual
            this.Hide();
        }

        private void Senha_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alteração de senha enviada para esse e-mail!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = _usuarioService.Login(EmailText.Text.Trim(), SenhaText.Text.Trim());
                SessaoUsuario.UsuarioLogado = usuario;
                RedirecionarUsuario(usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void RedirecionarUsuario(Usuario usuario)
        {
            switch (usuario.Perfil)
            {
                case Perfil.Cliente:
                    var dashboardCliente = _serviceProvider.GetRequiredService<DashboardCliente>();
                    dashboardCliente.Show();
                    Hide();
                    break;

                case Perfil.Analista:
                    var dashboardAnalista = _serviceProvider.GetRequiredService<DashboardAnalista>();
                    dashboardAnalista.Show();
                    Hide();
                    break;

                default:
                    MessageBox.Show("Perfil de usuário inválido.");
                    break;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SenhaText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.DeepSkyBlue;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Cyan;
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
