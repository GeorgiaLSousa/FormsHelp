using FormsHelp.Models;
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
    public partial class NovoChamado : Form
    {
        private readonly IServiceProvider _serviceProvider = null!;
        private readonly ChamadoService _chamadoService = null!;

        public NovoChamado()
        {
            InitializeComponent();
        }

        public NovoChamado(IServiceProvider serviceProvider, ChamadoService chamadoService) : this()
        {
            _serviceProvider = serviceProvider;
            _chamadoService = chamadoService;
        }

        private void NovoChamado_Load(object sender, EventArgs e)
        {
            CentralizarFormulario();
        }

        private void lbVoltar_Click(object sender, EventArgs e)
        {

        }

        private void lbVoltar_Click_1(object sender, EventArgs e)
        {
            var sair = _serviceProvider.GetRequiredService<DashboardCliente>();
            sair.Show();
            this.Hide();
        }

        private void NovoChamado_Resize(object sender, EventArgs e)
        {
            CentralizarFormulario();
        }

        private void CentralizarFormulario()
        {
            panelForm.Left = Math.Max(24, (panelConteudo.ClientSize.Width - panelForm.Width) / 2);
            panelForm.Top = Math.Max(24, (panelConteudo.ClientSize.Height - panelForm.Height) / 2);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (SessaoUsuario.UsuarioLogado == null)
                {
                    MessageBox.Show("Usuário não identificado. Faça login novamente.");
                    return;
                }

                var chamado = new Chamado
                {
                    Titulo = txbTitulo.Text.Trim(),
                    Descricao = txbDescricao.Text.Trim(),

                    Prioridade = Enum.Parse<Prioridade>(cmbPrioridade.Text),

                    Categoria = Enum.Parse<Setor>(cmbCategoria.Text),

                    Status = StatusChamado.Aberto,

                    DataAbertura = DateTime.Now,

                    Solicitante = SessaoUsuario.UsuarioLogado
                };

                _chamadoService.CriarChamado(chamado);

                MessageBox.Show("Chamado aberto com sucesso!");
                txbTitulo.Clear();
                txbDescricao.Clear();
                cmbPrioridade.SelectedIndex = -1;
                cmbCategoria.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
