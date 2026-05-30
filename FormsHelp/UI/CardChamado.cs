using FormsHelp.Models;
using FormsHelp.Services;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class CardChamado : UserControl
    {
        private readonly IServiceProvider _serviceProvider = null!;
        private long _idChamadoAtual;

        public CardChamado()
        {
            InitializeComponent();
            AjustarLayout();
        }

        // Construtor que recebe o provedor de serviços do Dashboard
        public CardChamado(IServiceProvider serviceProvider) : this()
        {
            _serviceProvider = serviceProvider;
        }

        private void CardChamado_Resize(object sender, EventArgs e)
        {
            AjustarLayout();
        }

        private void AjustarLayout()
        {
            const int margem = 15;
            const int larguraBadge = 90;
            const int espacoBadge = 25;

            lblStatus.Left = Width - larguraBadge - margem;
            lblPrioridade.Left = lblStatus.Left;
            btnVerDetalhes.Left = lblStatus.Left;

            var larguraTexto = Math.Max(220, lblStatus.Left - espacoBadge - margem);
            lbTitulo.Width = larguraTexto;
            lblDescricao.Width = larguraTexto;
            lblInfo.Width = larguraTexto;
        }

        public void CarregarDados(Chamado chamado)
        {
            _idChamadoAtual = chamado.Id; // Salva o ID correto do chamado vindo do banco

            lbTitulo.Text = chamado.Titulo;
            lblDescricao.Text = chamado.Descricao;
            lblStatus.Text = chamado.Status.ToString();
            lblPrioridade.Text = chamado.Prioridade.ToString();
            lblInfo.Text = $"{chamado.Solicitante?.Nome ?? "Usuario"}     {chamado.DataAbertura:dd/MM/yyyy}     {chamado.Categoria}";
        }

        private void btnVerDetalhes_Click(object sender, EventArgs e)
        {
            if (_idChamadoAtual <= 0) return;

            try
            {
                // 1. Instancia ou resolve a tela de detalhes pelo Container de DI
                var telaDetalhe = _serviceProvider.GetRequiredService<DetalheAnalista>();

                // 2. Transmite o ID guardado neste Card para a nova tela
                telaDetalhe.MapearIdChamado(_idChamadoAtual);

                // 3. Exibe a tela de detalhes
                telaDetalhe.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir detalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblInfo_Click(object sender, EventArgs e) { }
        private void cardChamado_Load(object sender, EventArgs e) { }
        private void lblDescricao_Click(object sender, EventArgs e) { }
    }
}

