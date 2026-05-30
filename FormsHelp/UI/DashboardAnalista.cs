using FormsHelp.Services;
using FormsHelp.Sessao;
using FormsHelp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsHelp.UI
{
    public partial class DashboardAnalista : Form
    {
        private readonly IServiceProvider _serviceProvider = null!;
        private readonly ChamadoService _chamadoService = null!;

        // 📌 Variável para controlar qual filtro está ativo ("Aberto" ou "MeusAtendimentos")
        private string _filtroAtivo = "Aberto";

        public DashboardAnalista()
        {
            InitializeComponent();
        }

        public DashboardAnalista(IServiceProvider serviceProvider, ChamadoService chamadoService) : this()
        {
            _serviceProvider = serviceProvider;
            _chamadoService = chamadoService;
        }

        private void DashboardAnalista_Load(object sender, EventArgs e)
        {
            this.ActiveControl = flowChamados;

            // Define o visual inicial dos botões (opcional, para dar destaque ao ativo)
            AjustarEstiloBotoes();

            AjustarCards();
            CarregarChamados();
        }

        private void DashboardAnalista_Resize(object sender, EventArgs e)
        {
            AjustarCards();
        }

        private void AjustarCards()
        {
            var largura = Math.Max(600, flowChamados.ClientSize.Width - 24);

            foreach (Control controle in flowChamados.Controls)
            {
                // Garante que o ajuste de tamanho ignore os botões do topo
                if (controle is CardChamado)
                {
                    controle.Width = largura;
                }
            }
        }

        // 📌 LÓGICA DE CARREGAMENTO: Decide o método pelo valor da variável de controle
        private void CarregarChamados()
        {
            if (SessaoUsuario.UsuarioLogado == null)
                return;

            List<Chamado> chamados;

            if (_filtroAtivo == "MeusAtendimentos")
            {
                // Puxa do banco os chamados que você já assumiu
                chamados = _chamadoService.ListarChamadosAnalista();
            }
            else
            {
                // Padrão: Puxa do banco os chamados abertos disponíveis
                chamados = _chamadoService.ListarChamadosAbertos();
            }

            flowChamados.Controls.Clear();

            foreach (var chamado in chamados)
            {
                var card = new CardChamado();
                card.Width = Math.Max(600, flowChamados.ClientSize.Width - 24);
                card.CarregarDados(chamado, _serviceProvider);
                flowChamados.Controls.Add(card);
            }
        }

        // 📌 EVENTO DO BOTÃO "Abertos"
        private void btnAbertos_Click(object sender, EventArgs e)
        {
            _filtroAtivo = "Aberto";
            AjustarEstiloBotoes();
            CarregarChamados();
        }

        // 📌 EVENTO DO BOTÃO "Meus Atendimentos"
        private void btnMeusAtendimentos_Click(object sender, EventArgs e)
        {
            _filtroAtivo = "MeusAtendimentos";
            AjustarEstiloBotoes();
            CarregarChamados();
        }

        // 📌 Identifica visualmente qual botão está ativo mudando levemente a cor
        private void AjustarEstiloBotoes()
        {
            // Substitua 'btnAbertos' e 'btnMeusAtendimentos' pelos nomes reais dos seus botões se mudar no Designer
            if (_filtroAtivo == "Aberto")
            {
                btnAbertos.BackColor = Color.FromArgb(28, 40, 76); // Cor de destaque
                btnMeusAtendimentos.BackColor = Color.FromArgb(17, 27, 58); // Cor padrão escura
            }
            else
            {
                btnAbertos.BackColor = Color.FromArgb(17, 27, 58);
                btnMeusAtendimentos.BackColor = Color.FromArgb(28, 40, 76);
            }
        }

        private void CardChamado2_Load(object sender, EventArgs e) { }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}