using System;
using System.Drawing;
using System.Windows.Forms;

namespace cs_winform_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CrtajKlaster(Graphics g, float x0, float y0, float d)
        {
            Random rnd = new Random();
            if (d < 3) return;
            int n = rnd.Next(5, 7);
            float r = 0.1f * d;
            for (int i = 0; i < n; i++)
            {
                float xi = x0 + d * (float)Math.Cos(2 * Math.PI * i / n) + r * rnd.Next(-3, 3);
                float yi = y0 + d * (float)Math.Sin(2 * Math.PI * i / n) + r * rnd.Next(-3, 3);
                g.FillEllipse(new SolidBrush(Color.Red), xi - r, yi - r, 2 * r, 2 * r);
                CrtajKlaster(g, xi, yi, 0.3f * d);
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            CrtajKlaster(
                e.Graphics,
                ClientSize.Width / 2,
                ClientSize.Height / 2,
                250);
        }
    }
}
