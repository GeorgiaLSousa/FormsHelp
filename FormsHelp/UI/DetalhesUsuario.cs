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
        public DetalhesUsuario()
        {
            InitializeComponent();
        }

        private void DetalhesUsuario_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

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
            // Usamos o 'panel10' aqui em vez de 'panel2'
            GraphicsPath path = new GraphicsPath();
            int radius = 20; // Você pode ajustar o raio se quiser que seja menos arredondado

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel10.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel10.Width - radius - 1, panel10.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel10.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();

            panel10.Region = new Region(path);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20; // Ajuste este valor se quiser mais ou menos arredondado

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
            int radius = 20; // Você pode ajustar este valor se quiser um arredondamento diferente

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel14.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel14.Width - radius - 1, panel14.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel14.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();

            panel14.Region = new Region(path);
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            if (sender is not Panel panel)
                return;

            GraphicsPath path = new GraphicsPath();
            int radius = 20; // Você pode ajustar o raio conforme necessário

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius - 1, panel.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();

            panel.Region = new Region(path);
        }

        private void label7_Click(object sender, EventArgs e)
        {

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

        private void label8_Click(object sender, EventArgs e)
        {

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

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20; // Ajuste conforme necessário

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel17.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel17.Width - radius - 1, panel17.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel17.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();

            panel17.Region = new Region(path);
        }

        private void label33_Click(object sender, EventArgs e)
        {

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

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20; // Ajuste o raio conforme sua preferência

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel16.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel16.Width - radius - 1, panel16.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel16.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();

            panel16.Region = new Region(path);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var sair = new DashboardCliente();
            sair.Show();
            this.Hide();
        }
    }
}
