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
    public partial class DashboardAnalista : Form
    {
        private readonly ChamadoService _chamadoService = null!;

        public DashboardAnalista()
        {
            InitializeComponent();
        }

        public DashboardAnalista(ChamadoService chamadoService) : this()
        {
            _chamadoService = chamadoService;
        }

        private void DashboardAnalista_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;
            cmbAtendimento.SelectedIndex = 0;
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
                controle.Width = largura;
            }
        }

        private void CarregarChamados()
        {
            var chamados = _chamadoService.TodosChamados();

            flowChamados.Controls.Clear();

            foreach (var chamado in chamados)
            {
                var card = new CardChamado();
                card.Width = Math.Max(600, flowChamados.ClientSize.Width - 24);
                card.CarregarDados(chamado);

                flowChamados.Controls.Add(card);
            }
        }

        private void CardChamado2_Load(object sender, EventArgs e)
        {

        }
    }
}
