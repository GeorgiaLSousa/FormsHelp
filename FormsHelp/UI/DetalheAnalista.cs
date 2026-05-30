
using FormsHelp.Services;
using FormsHelp.Sessao;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsHelp.UI
{
    public partial class DetalheAnalista : Form
    {
        private readonly ChamadoService _chamadoService;
        private readonly IServiceProvider _serviceProvider;

        private long _idChamado; // 📌 Variável que armazena o ID enviado pelo Card
        private bool _jaEhDono = false; // 📌 Variável de controle de estado da tela

        // 📌 CONSTRUTOR CORRIGIDO: Injeta tanto o Service quanto o Provider de Dependências
        public DetalheAnalista(ChamadoService chamadoService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _chamadoService = chamadoService;
            _serviceProvider = serviceProvider;
        }

        public void MapearIdChamado(long id)
        {
            _idChamado = id;
        }

        private void DetalheAnalista_Load(object sender, EventArgs e)
        {
            if (_idChamado <= 0) return;

            try
            {
                // Busca o chamado completo no banco através do ID usando o seu Service
                var chamado = _chamadoService.DetalhesChamado(_idChamado);

                // 📌 Preenche os componentes do painel esquerdo com os dados reais do banco
                label11.Text = chamado.Titulo;
                label14.Text = chamado.Descricao;
                label16.Text = chamado.Solicitante?.Nome ?? "Sem solicitante";
                label18.Text = chamado.DataAbertura.ToString("dd/MM/yyyy 'às' HH:mm");
                label20.Text = chamado.Categoria.ToString();

                label22.Text = chamado.Analista?.Nome ?? "Aguardando Analista...";
                label24.Text = chamado.DataAtualizacao.Year == 1 ? "Sem atualizações" : chamado.DataAtualizacao.ToString("dd/MM/yyyy 'às' HH:mm");

                // 📌 Preenche as labels informativas do painel lateral direito
                label7.Text = chamado.Status.ToString();
                label8.Text = chamado.Prioridade.ToString();
                label4.Text = chamado.Status.ToString();
                label5.Text = chamado.Prioridade.ToString();

                // 📌 VALIDAÇÃO DINÂMICA: Verifica se o analista logado é quem está atendendo
                if (chamado.Analista != null)
                {
                    if (SessaoUsuario.UsuarioLogado != null && chamado.Analista.Id == SessaoUsuario.UsuarioLogado.Id)
                    {
                        // Se for o próprio analista dono, muda o botão para o modo de edição
                        _jaEhDono = true;
                        btnAssumir.Enabled = true;
                        btnAssumir.Text = "Atualizar Chamado";
                        btnAssumir.BackColor = Color.FromArgb(41, 128, 185); // Cor Azul de Edição
                    }
                    else
                    {
                        // Se já tiver analista mas for outro profissional, tranca o botão
                        _jaEhDono = false;
                        btnAssumir.Enabled = false;
                        btnAssumir.Text = "Em Atendimento por outro Analista";
                        btnAssumir.BackColor = Color.Gray;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados do chamado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha a tela de detalhes e volta para o Dashboard
        }

        // 📌 EVENTO DO BOTÃO INTELIGENTE: Assume ou abre a tela de edição dependendo do dono
        // 📌 EVENTO DO BOTÃO INTELIGENTE: Assume ou abre a tela de edição dependendo do dono
        private void btnAssumir_Click(object sender, EventArgs e)
        {
            if (_idChamado <= 0) return;

            try
            {
                if (_jaEhDono)
                {
                    // 🚀 CORREÇÃO PRINCIPAL: Cria a instância passando o ID direto no construtor pelo ActivatorUtilities
                    // Isso elimina o uso do GetRequiredService tradicional e remove de vez a linha do MapearIdChamado
                    var telaAtualizar = ActivatorUtilities.CreateInstance<AtualizarChamado>(_serviceProvider, _idChamado);

                    telaAtualizar.Show();
                    this.Close(); // Fecha a tela de leitura atual
                }
                else
                {
                    // CASO ESTEJA ABERTO: Executa a lógica de assumir o ticket
                    var chamadoAtualizado = _chamadoService.AtenderChamado(_idChamado);

                    MessageBox.Show("Você assumiu este chamado com sucesso! Ele agora está Em Andamento.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    label22.Text = chamadoAtualizado.Analista?.Nome ?? SessaoUsuario.UsuarioLogado?.Nome ?? "Analista";
                    label24.Text = chamadoAtualizado.DataAtualizacao.ToString("dd/MM/yyyy 'às' HH:mm");
                    label7.Text = chamadoAtualizado.Status.ToString();
                    label4.Text = chamadoAtualizado.Status.ToString();

                    // Transforma o botão no modo de atualização imediatamente após assumir
                    _jaEhDono = true;
                    btnAssumir.Text = "Atualizar Chamado";
                    btnAssumir.BackColor = Color.FromArgb(41, 128, 185);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível processar a ação: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 📌 CORREÇÃO: Método adicionado para responder ao vínculo do arquivo Designer.cs
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Pode ficar vazio, serve apenas para evitar o erro de referência
        }

        #region Renderização Gráfica Arredondada (Paints Corrigidos)

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int raio = 20;
            gp.AddArc(0, 0, raio, raio, 180, 90);
            gp.AddArc(p.Width - raio, 0, raio, raio, 270, 90);
            gp.AddArc(p.Width - raio, p.Height - raio, raio, raio, 0, 90);
            gp.AddArc(0, p.Height - raio, raio, raio, 90, 90);
            gp.CloseFigure();
            p.Region = new System.Drawing.Region(gp);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int raio = 20;
            gp.AddArc(0, 0, raio, raio, 180, 90);
            gp.AddArc(p.Width - raio, 0, raio, raio, 270, 90);
            gp.AddArc(p.Width - raio, p.Height - raio, raio, raio, 0, 90);
            gp.AddArc(0, p.Height - raio, raio, raio, 90, 90);
            gp.CloseFigure();
            p.Region = new System.Drawing.Region(gp);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int raio = 20;
            gp.AddArc(0, 0, raio, raio, 180, 90);
            gp.AddArc(p.Width - raio - 1, 0, raio, raio, 270, 90);
            gp.AddArc(p.Width - raio - 1, p.Height - raio - 1, raio, raio, 0, 90);
            gp.AddArc(0, p.Height - raio - 1, raio, raio, 90, 90);
            gp.CloseFigure();
            using (SolidBrush brush = new SolidBrush(p.BackColor))
            {
                e.Graphics.FillPath(brush, gp);
            }
            p.Region = new System.Drawing.Region(gp);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int raio = 20;
            gp.AddArc(0, 0, raio, raio, 180, 90);
            gp.AddArc(p.Width - raio - 1, 0, raio, raio, 270, 90);
            gp.AddArc(p.Width - raio - 1, p.Height - raio - 1, raio, raio, 0, 90);
            gp.AddArc(0, p.Height - raio - 1, raio, raio, 90, 90);
            gp.CloseFigure();
            using (SolidBrush brush = new SolidBrush(p.BackColor))
            {
                e.Graphics.FillPath(brush, gp);
            }
            p.Region = new System.Drawing.Region(gp);
        }

        #endregion

        private void label9_Click(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
        private void label12_Click(object sender, EventArgs e) { }
        private void label14_Click(object sender, EventArgs e) { }
        private void pictureBox5_Click(object sender, EventArgs e) { }
        private void pictureBox8_Click(object sender, EventArgs e) { }
        private void label21_Click(object sender, EventArgs e) { }
        private void label26_Click(object sender, EventArgs e) { }
        private void label29_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
    }
}
