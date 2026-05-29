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
    public partial class AtualizarChamado : Form
    {
        public AtualizarChamado()
        {
            InitializeComponent();
        }

        private void AtualizarChamado_Load(object sender, EventArgs e)
        {
            cmbStatusChamado.SelectedIndex = 0;
            cmbPrioridadeChamado.SelectedIndex = 2;
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            // Cria o caminho gráfico
            GraphicsPath path = new GraphicsPath();
            int radius = 12; // Raio ideal para elementos pequenos como este
            Rectangle rect = new Rectangle(0, 0, panel8.Width, panel8.Height);

            // Adiciona os arcos nos quatro cantos
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);

            path.CloseAllFigures();

            // Aplica a região arredondada ao panel8
            panel8.Region = new Region(path);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_2(object sender, PaintEventArgs e)
        {
            // Cria o caminho gráfico
            GraphicsPath path = new GraphicsPath();
            int radius = 20; // Ajuste este valor se quiser mais ou menos arredondado
            Rectangle rect = new Rectangle(0, 0, panel4.Width, panel4.Height);

            // Adiciona os arcos nos quatro cantos
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);

            path.CloseAllFigures();

            // Aplica a região arredondada ao panel4
            panel4.Region = new Region(path);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {
            // Cria o caminho gráfico para o formato
            GraphicsPath path = new GraphicsPath();
            int radius = 25; // Raio mais pronunciado para um container maior
            Rectangle rect = new Rectangle(0, 0, panel16.Width, panel16.Height);

            // Adiciona os arcos nos quatro cantos
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);

            path.CloseAllFigures();

            // Aplica a região arredondada ao panel16
            panel16.Region = new Region(path);
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Cria o caminho gráfico para o formato
            GraphicsPath path = new GraphicsPath();
            int radius = 15; // Raio arredondado para um visual moderno
            Rectangle rect = new Rectangle(0, 0, panel2.Width, panel2.Height);

            // Adiciona os arcos para arredondar os quatro cantos
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);

            path.CloseAllFigures();

            // Aplica a região arredondada ao painel
            panel2.Region = new Region(path);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            // Criamos o caminho gráfico
            GraphicsPath path = new GraphicsPath();
            int radius = 20; // Raio arredondado
            Rectangle rect = new Rectangle(0, 0, panel10.Width, panel10.Height);

            // Definimos os arcos nos quatro cantos
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);

            path.CloseAllFigures();

            // Aplicamos a região ao panel10
            panel10.Region = new Region(path);
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            // Criamos o caminho gráfico
            GraphicsPath path = new GraphicsPath();
            // Use um raio menor para painéis pequenos (10px a 12px costuma ficar bom)
            int radius = 10;
            Rectangle rect = new Rectangle(0, 0, panel11.Width, panel11.Height);

            // Definimos os arcos nos quatro cantos
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);

            path.CloseAllFigures();

            // Aplicamos a região ao panel11
            panel11.Region = new Region(path);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            // Criamos o caminho gráfico
            GraphicsPath path = new GraphicsPath();
            int radius = 12; // Raio ideal para elementos pequenos
            Rectangle rect = new Rectangle(0, 0, panel12.Width, panel12.Height);

            // Definimos os arcos nos quatro cantos
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);

            path.CloseAllFigures();

            // Aplicamos a região ao panel12
            panel12.Region = new Region(path);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // Cria o caminho gráfico
            GraphicsPath path = new GraphicsPath();
            int radius = 20; // Ajuste este valor se quiser mais ou menos arredondado
            Rectangle rect = new Rectangle(0, 0, panel3.Width, panel3.Height);

            // Adiciona os arcos nos quatro cantos
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);

            path.CloseAllFigures();

            // Aplica a região arredondada ao panel3
            panel3.Region = new Region(path);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            // Cria o caminho gráfico
            GraphicsPath path = new GraphicsPath();
            int radius = 15; // Um raio de 15px fica ótimo para campos de texto
            Rectangle rect = new Rectangle(0, 0, panel9.Width, panel9.Height);

            // Adiciona os arcos nos quatro cantos
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);

            path.CloseAllFigures();

            // Aplica a região arredondada ao panel9
            panel9.Region = new Region(path);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            // Cria o caminho gráfico
            GraphicsPath path = new GraphicsPath();
            int radius = 15; // Raio ideal para um arredondamento harmônico
            Rectangle rect = new Rectangle(0, 0, panel7.Width, panel7.Height);

            // Adiciona os arcos nos quatro cantos
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);

            path.CloseAllFigures();

            // Aplica a região arredondada ao panel7
            panel7.Region = new Region(path);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            // Cria o caminho gráfico
            GraphicsPath path = new GraphicsPath();
            int radius = 15; // Ajuste conforme a sua preferência
            Rectangle rect = new Rectangle(0, 0, panel6.Width, panel6.Height);

            // Adiciona os arcos nos quatro cantos
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);

            path.CloseAllFigures();

            // Aplica a região arredondada ao panel6
            panel6.Region = new Region(path);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            // Cria o caminho gráfico para o formato arredondado
            GraphicsPath path = new GraphicsPath();
            int radius = 15; // Mantendo o padrão de 15px para consistência
            Rectangle rect = new Rectangle(0, 0, panel5.Width, panel5.Height);

            // Adiciona os arcos nos quatro cantos
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);

            path.CloseAllFigures();

            // Aplica a região arredondada ao panel5
            panel5.Region = new Region(path);
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            // Cria o caminho gráfico para o formato arredondado
            GraphicsPath path = new GraphicsPath();
            int radius = 15; // Mantendo o padrão para consistência visual
            Rectangle rect = new Rectangle(0, 0, panel15.Width, panel15.Height);

            // Adiciona os arcos nos quatro cantos
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);

            path.CloseAllFigures();

            // Aplica a região arredondada ao panel15
            panel15.Region = new Region(path);
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            // Cria o caminho gráfico para o formato arredondado
            GraphicsPath path = new GraphicsPath();
            int radius = 15; // Ajuste conforme o tamanho do painel
            Rectangle rect = new Rectangle(0, 0, panel14.Width, panel14.Height);

            // Adiciona os arcos nos quatro cantos
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);

            path.CloseAllFigures();

            // Aplica a região arredondada ao panel14
            panel14.Region = new Region(path);
        }

        private void btnAtualizarChamado_Click(object sender, EventArgs e)
        {

        }
    }
}
