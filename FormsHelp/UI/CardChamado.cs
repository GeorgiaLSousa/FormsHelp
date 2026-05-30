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
        private IServiceProvider _serviceProvider = null!;
        private long _idChamadoAtual;

        // Construtor padrão que o Windows Forms e o Designer usam
        public CardChamado()
        {
            InitializeComponent();
            AjustarLayout();
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

        // 📌 ATUALIZADO: Agora o método recebe o 'serviceProvider' junto com o chamado
        public void CarregarDados(Chamado chamado, IServiceProvider serviceProvider)
        {
            _idChamadoAtual = chamado.Id;
            _serviceProvider = serviceProvider; // 📌 Salvamos o provedor aqui de forma segura!

            lbTitulo.Text = chamado.Titulo;
            lblDescricao.Text = chamado.Descricao;
            lblStatus.Text = chamado.Status.ToString();
            lblPrioridade.Text = chamado.Prioridade.ToString();
            lblInfo.Text = $"{chamado.Solicitante?.Nome ?? "Usuario"}     {chamado.DataAbertura:dd/MM/yyyy}     {chamado.Categoria}";
        }

        private void btnVerDetalhes_Click(object sender, EventArgs e)
        {
            if (_idChamadoAtual <= 0 || _serviceProvider == null) return;

            try
            {
                var usuarioLogado = FormsHelp.Sessao.SessaoUsuario.UsuarioLogado;

                // 📌 SEGURANÇA: Se não houver usuário logado ou se o perfil explicitamente NÃO for analista, abre a do cliente
                if (usuarioLogado != null && usuarioLogado.Perfil == Perfil.Analista)
                {
                    // Resolve e abre a tela de detalhes com a visão do Analista (contendo o botão Assumir)
                    var telaDetalheAnalista = _serviceProvider.GetRequiredService<DetalheAnalista>();
                    telaDetalheAnalista.MapearIdChamado(_idChamadoAtual);
                    telaDetalheAnalista.Show();
                }
                else
                {
                    // 🚀 CLIENTE: Resolve e abre a tela DetalhesUsuario (Layout arredondado de leitura)
                    var telaDetalheCliente = _serviceProvider.GetRequiredService<DetalhesUsuario>();
                    telaDetalheCliente.MapearIdChamado(_idChamadoAtual);
                    telaDetalheCliente.Show();
                }
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
