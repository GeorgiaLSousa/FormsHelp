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
    public partial class CardChamado : UserControl
    {
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

        public void CarregarDados(Chamado chamado)
        {
            lbTitulo.Text = chamado.Titulo;
            lblDescricao.Text = chamado.Descricao;
            lblStatus.Text = chamado.Status.ToString();
            lblPrioridade.Text = chamado.Prioridade.ToString();
            lblInfo.Text = $"{chamado.Solicitante?.Nome ?? "Usuario"}     {chamado.DataAbertura:dd/MM/yyyy}     {chamado.Categoria}";


        }




        private void btnVerDetalhes_Click(object sender, EventArgs e)
        {

        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void cardChamado_Load(object sender, EventArgs e)
        {

        }

        private void lblDescricao_Click(object sender, EventArgs e)
        {

        }
    }
}
