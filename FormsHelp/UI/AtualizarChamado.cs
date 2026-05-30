using FormsHelp.Services;
using FormsHelp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace FormsHelp.UI
{
    // 📌 CORREÇÃO: Removida a linha duplicada da classe que quebrava o escopo
    public partial class AtualizarChamado : Form
    {
        private readonly ChamadoService _chamadoService = null!;
        private readonly long _idChamado; // 📌 ID recebido de forma segura no construtor

        // Construtor padrão exigido pelo Designer do WinForms
        public AtualizarChamado()
        {
            InitializeComponent();
        }

        // 📌 CONSTRUTOR ATUALIZADO: Recebe o service e o ID enviado pelo ActivatorUtilities
        public AtualizarChamado(ChamadoService chamadoService, long idChamado) : this()
        {
            _chamadoService = chamadoService;
            _idChamado = idChamado;
        }

        private void AtualizarChamado_Load(object sender, EventArgs e)
        {
            if (_idChamado <= 0) return;

            try
            {
                // Busca as informações atuais do chamado no SQLite
                var chamado = _chamadoService.DetalhesChamado(_idChamado);

                // Carrega os textos nos ComboBoxes exatamente como estão salvos
                // Se o banco retornar "EmAndamento", a combo exibe "Em atendimento" de forma amigável
                if (chamado.Status == StatusChamado.EmAndamento)
                    cmbStatusChamado.Text = "Em atendimento";
                else
                    cmbStatusChamado.Text = chamado.Status.ToString();

                cmbPrioridadeChamado.Text = chamado.Prioridade.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados para edição: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 📌 EVENTO DO BOTÃO ATUALIZAR: Mapeia as alterações de Status e Prioridade
        // 📌 EVENTO DO BOTÃO ATUALIZAR: Mapeia as alterações com segurança
        private void btnAtualizarChamado_Click(object sender, EventArgs e)
        {
            if (_idChamado <= 0) return;

            try
            {
                // 1. Busca o chamado original com TODOS os campos obrigatórios já preenchidos do banco
                var chamadoModificado = _chamadoService.DetalhesChamado(_idChamado);

                if (chamadoModificado == null)
                {
                    MessageBox.Show("Chamado não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string statusTexto = cmbStatusChamado.Text.Replace(" ", "");
                if (statusTexto.Equals("Ematendimento", StringComparison.OrdinalIgnoreCase))
                {
                    statusTexto = "EmAndamento";
                }

                // 3. Atualiza APENAS as propriedades que vieram das caixas de seleção da tela
                chamadoModificado.Status = (StatusChamado)Enum.Parse(typeof(StatusChamado), statusTexto);
                chamadoModificado.Prioridade = (Prioridade)Enum.Parse(typeof(Prioridade), cmbPrioridadeChamado.Text);

                _chamadoService.AtualizarChamado(chamadoModificado);

                MessageBox.Show("Chamado atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close(); // Fecha a tela de atualização e retorna
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar chamado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Renderização Gráfica Arredondada (Paints usando sender dinâmico)

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;
            GraphicsPath path = new GraphicsPath();
            int radius = 12;
            Rectangle rect = new Rectangle(0, 0, p.Width, p.Height);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            p.Region = new Region(path);
        }

        private void panel4_Paint_2(object sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            Rectangle rect = new Rectangle(0, 0, p.Width, p.Height);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            p.Region = new Region(path);
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;
            GraphicsPath path = new GraphicsPath();
            int radius = 25;
            Rectangle rect = new Rectangle(0, 0, p.Width, p.Height);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            p.Region = new Region(path);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;
            GraphicsPath path = new GraphicsPath();
            int radius = 15;
            Rectangle rect = new Rectangle(0, 0, p.Width, p.Height);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            p.Region = new Region(path);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            Rectangle rect = new Rectangle(0, 0, p.Width, p.Height);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            p.Region = new Region(path);
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;
            GraphicsPath path = new GraphicsPath();
            int radius = 10;
            Rectangle rect = new Rectangle(0, 0, p.Width, p.Height);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            p.Region = new Region(path);
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;
            GraphicsPath path = new GraphicsPath();
            int radius = 12;
            Rectangle rect = new Rectangle(0, 0, p.Width, p.Height);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            p.Region = new Region(path);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            Rectangle rect = new Rectangle(0, 0, p.Width, p.Height);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            p.Region = new Region(path);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;
            GraphicsPath path = new GraphicsPath();
            int radius = 15;
            Rectangle rect = new Rectangle(0, 0, p.Width, p.Height);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            p.Region = new Region(path);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;
            GraphicsPath path = new GraphicsPath();
            int radius = 15;
            Rectangle rect = new Rectangle(0, 0, p.Width, p.Height);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            p.Region = new Region(path);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;
            GraphicsPath path = new GraphicsPath();
            int radius = 15;
            Rectangle rect = new Rectangle(0, 0, p.Width, p.Height);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            p.Region = new Region(path);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;
            GraphicsPath path = new GraphicsPath();
            int radius = 15;
            Rectangle rect = new Rectangle(0, 0, p.Width, p.Height);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            p.Region = new Region(path);
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;
            GraphicsPath path = new GraphicsPath();
            int radius = 15;
            Rectangle rect = new Rectangle(0, 0, p.Width, p.Height);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, p.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            p.Region = new Region(path);
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;
            GraphicsPath path = new GraphicsPath();
            int radius = 15;
            Rectangle rect = new Rectangle(0, 0, p.Width, p.Height);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            p.Region = new Region(path);
        }

        #endregion

        private void label4_Click(object sender, EventArgs e) { }
        private void panel4_Paint(object sender, PaintEventArgs e) { }
        private void panel4_Paint_1(object sender, PaintEventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label32_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label31_Click(object sender, EventArgs e) { }
    }
}