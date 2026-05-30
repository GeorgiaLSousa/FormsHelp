using FormsHelp.Models;
using FormsHelp.Services;
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
    public partial class DetalhesUsuario : Form
    {
        private readonly ChamadoService _chamadoService = null!;
        private long _idChamado; // 📌 Chave de transporte do ID vindo do Card

        public DetalhesUsuario()
        {
            InitializeComponent();
        }

        // 📌 CONSTRUTOR DE DEPENDÊNCIAS: Resolvido automaticamente pelo container de DI
        public DetalhesUsuario(ChamadoService chamadoService) : this()
        {
            _chamadoService = chamadoService;
        }

        // 📌 MÉTODO DE MAPEAMENTO: Injeta o ID vindo do clique do botão do Card
        public void MapearIdChamado(long id)
        {
            _idChamado = id;
        }

        private void DetalhesUsuario_Load(object sender, EventArgs e)
        {
            if (_idChamado <= 0) return;

            try
            {
                // Busca as informações completas direto do repositório SQLite usando o ID
                var chamado = _chamadoService.DetalhesChamado(_idChamado);

                // ==========================================
                // 📌 PAINEL ESQUERDO (DADOS DO CHAMADO)
                // ==========================================
                label11.Text = chamado.Titulo;
                label14.Text = chamado.Descricao;
                label16.Text = chamado.Solicitante?.Nome ?? "Sem solicitante";
                label18.Text = chamado.DataAbertura.ToString("dd/MM/yyyy 'às' HH:mm");

                // Badges do topo superior direito (Painel Esquerdo)
                label7.Text = chamado.Status.ToString();
                label8.Text = chamado.Prioridade.ToString();

                // 📌 CORREÇÃO DO RESPONSÁVEL: Exibe dinamicamente o analista no campo correto do painel esquerdo
                Responsavel.Text = chamado.Analista != null ? chamado.Analista.Nome : "Aguardando Analista...";

                // ==========================================
                // 📌 PAINEL DIREITO (CARD INFORMATIVO BRANCO)
                // ==========================================

                // Força as caixas cinzas identificadoras a manterem os títulos fixos do card lateral
                Status.Text = "Status:";
                label33.Text = "Prioridade:";

                // Vincula os valores dinâmicos reais ao lado das caixas cinzas
                label32.Text = chamado.Status.ToString();       // Valor real do Status (Ex: Aberto / EmAndamento)
                label31.Text = chamado.Prioridade.ToString();   // Valor real da Prioridade (Ex: Alta / Baixa)
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados do chamado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Fecha esta tela e retorna automaticamente para o Dashboard que já está aberto por baixo
            this.Close();
        }

        // 📌 EVENTO DO BOTÃO EXCLUIR: Deleta apenas se o chamado NÃO estiver em atendimento
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_idChamado <= 0) return;

            try
            {
                // 1. Busca o estado atualizado do chamado para garantir a validação
                var chamado = _chamadoService.DetalhesChamado(_idChamado);

                if (chamado == null)
                {
                    MessageBox.Show("Chamado não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2. REGRA DE SEGURANÇA: Se o status for diferente de Aberto ou já tiver analista dono, bloqueia
                if (chamado.Status != StatusChamado.Aberto || chamado.Analista != null)
                {
                    MessageBox.Show("Este chamado não pode ser excluído porque já está em atendimento por um analista.", "Exclusão Negada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Pede a confirmação do usuário antes de apagar
                var confirmacao = MessageBox.Show("Tem certeza de que deseja excluir este chamado permanentemente?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacao == DialogResult.Yes)
                {
                    // Chama o método de exclusão do seu service
                    _chamadoService.ExcluirChamado(_idChamado);

                    MessageBox.Show("Chamado excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Fecha a tela e volta para o Dashboard
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar excluir o chamado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label34_Click(object sender, EventArgs e) { }
        private void label32_Click(object sender, EventArgs e) { }
        private void label33_Click(object sender, EventArgs e) { }
        private void label31_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }

        #region Renderização de Layouts Arredondados (Painéis)

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel2.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel2.Width - radius - 1, panel2.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel2.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            panel2.Region = new Region(path);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;

            GraphicsPath path = new GraphicsPath();
            int radius = 20;

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(p.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(p.Width - radius - 1, p.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, p.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();

            p.Region = new Region(path);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel3.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel3.Width - radius - 1, panel3.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel3.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            panel3.Region = new Region(path);
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel14.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel14.Width - radius - 1, panel14.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel14.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            panel14.Region = new Region(path);
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            if (sender is not Panel panel) return;
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius - 1, panel.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            panel.Region = new Region(path);
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel11.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel11.Width - radius - 1, panel11.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel11.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            panel11.Region = new Region(path);
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel12.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel12.Width - radius - 1, panel12.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel12.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            panel12.Region = new Region(path);
        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel19.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel19.Width - radius - 1, panel19.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel19.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            panel19.Region = new Region(path);
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel17.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel17.Width - radius - 1, panel17.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel17.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            panel17.Region = new Region(path);
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel18.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel18.Width - radius - 1, panel18.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel18.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            panel18.Region = new Region(path);
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel16.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel16.Width - radius - 1, panel16.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel16.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            panel16.Region = new Region(path);
        }

        #endregion

        private void label34_Click_1(object sender, EventArgs e) { }
        private void label22_Click(object sender, EventArgs e) { }
        private void panel2_Paint_1(object sender, PaintEventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lbVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}