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
    public partial class DashboardCliente : Form
    {
        private readonly IServiceProvider _serviceProvider = null!;
        private readonly ChamadoService _chamadoService = null!;

        public DashboardCliente()
        {
            InitializeComponent();
        }

        public DashboardCliente(IServiceProvider serviceProvider, ChamadoService chamadoService) : this()
        {
            _serviceProvider = serviceProvider;
            _chamadoService = chamadoService;
        }

        private void btNovoChamado_Click(object sender, EventArgs e)
        {
            var entrar = _serviceProvider.GetRequiredService<NovoChamado>();
            entrar.Show();
            this.Hide();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DashboardCliente_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new object[] { "Todos os chamados" });
            cmbStatus.SelectedIndex = 0;

            // Amarração do evento de trava direto por código para evitar mexer no Designer
            this.ActiveControl = lbTituloPagina;
            AjustarCards();
            CarregarChamados();
            var usuario = SessaoUsuario.UsuarioLogado;
            lbNomeUsuario.Text = usuario?.Nome;
        }

        private void lbTituloPagina_Click(object sender, EventArgs e)
        {

        }

        private void DashboardCliente_Resize(object sender, EventArgs e)
        {
            AjustarCards();
        }

        private void AjustarCards()
        {
            var largura = Math.Max(600, flowChamados.ClientSize.Width - 24);

            foreach (Control controle in flowChamados.Controls)
            {
                controle.Width = largura;
            }
        }

        private void CarregarChamados()
        {
            if (SessaoUsuario.UsuarioLogado == null)
                return;

            var chamados = _chamadoService.ListaChamadoUsuario();

            flowChamados.Controls.Clear();

            foreach (var chamado in chamados)
            {
                var card = new CardChamado();
                card.Width = Math.Max(600, flowChamados.ClientSize.Width - 24);
                card.CarregarDados(chamado);

                flowChamados.Controls.Add(card);
            }
        }
    }
}
