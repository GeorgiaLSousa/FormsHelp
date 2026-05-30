using FormsHelp.Services;
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
        private long _idChamado; // 📌 Variável que armazena o ID enviado pelo Card
        public DetalheAnalista(ChamadoService chamadoService)
        {
            InitializeComponent();
            _chamadoService = chamadoService;
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
                label24.Text = chamado.DataAtualizacao.ToString("dd/MM/yyyy 'às' HH:mm");

                // 📌 Preenche as labels informativas do painel lateral direito
                label7.Text = chamado.Status.ToString();
                label8.Text = chamado.Prioridade.ToString();
                label4.Text = chamado.Status.ToString();
                label5.Text = chamado.Prioridade.ToString();

                // Desativa o botão de assumir caso um analista já seja dono dele
                if (chamado.Analista != null)
                {
                    btnAssumir.Enabled = false;
                    btnAssumir.Text = "Chamado em Atendimento";
                    btnAssumir.BackColor = Color.Gray;
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // 1. Criamos um caminho gráfico para desenhar a forma
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int raio = 20; // Ajuste este número para mais ou menos arredondado

            // 2. Desenhamos os arcos nos quatro cantos
            gp.AddArc(0, 0, raio, raio, 180, 90);
            gp.AddArc(this.panel2.Width - raio, 0, raio, raio, 270, 90);
            gp.AddArc(this.panel2.Width - raio, this.panel2.Height - raio, raio, raio, 0, 90);
            gp.AddArc(0, this.panel2.Height - raio, raio, raio, 90, 90);

            // 3. Fechamos a figura e aplicamos ao painel
            gp.CloseFigure();
            this.panel2.Region = new System.Drawing.Region(gp);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // O 'sender' é o painel que está sendo pintado
            if (sender is not Panel p) return;

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int raio = 20; // Ajuste conforme necessário

            gp.AddArc(0, 0, raio, raio, 180, 90);
            gp.AddArc(p.Width - raio, 0, raio, raio, 270, 90);
            gp.AddArc(p.Width - raio, p.Height - raio, raio, raio, 0, 90);
            gp.AddArc(0, p.Height - raio, raio, raio, 90, 90);

            gp.CloseFigure();
            p.Region = new System.Drawing.Region(gp);

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            // O 'sender' é o painel que está sendo pintado
            if (sender is not Panel p) return;

            // Melhora a qualidade do desenho para não serrilhar
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int raio = 20;

            // Define o formato arredondado
            gp.AddArc(0, 0, raio, raio, 180, 90);
            gp.AddArc(p.Width - raio - 1, 0, raio, raio, 270, 90);
            gp.AddArc(p.Width - raio - 1, p.Height - raio - 1, raio, raio, 0, 90);
            gp.AddArc(0, p.Height - raio - 1, raio, raio, 90, 90);
            gp.CloseFigure();

            // Pinta o fundo do painel e aplica o formato
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
