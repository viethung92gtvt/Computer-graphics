using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace draw_geometry
{
    public partial class PracticeCircle : Form
    {
        Bitmap b;
        int w = 400, h = 400;

        public PracticeCircle()
        {
            InitializeComponent();
        }

        private void PracticeCircle_Load(object sender, EventArgs e)
        {
            b = new Bitmap(w, h);
            drawCoordinateAxis();
        }

        void drawCoordinateAxis()
        {
            for (int i = 0; i < w; i++)
            {
                b.SetPixel(i, w / 2, Color.Black);
                b.SetPixel(w / 2, i, Color.Black);
            }
            picView.Image = b;
        }

        void Draw8Pixel(int x0, int y0, int x, int y)
        {
            b.SetPixel(x0 + x, y0 + y, Color.Red);
            b.SetPixel(x0 - x, y0 + y, Color.Blue);
            b.SetPixel(x0 + x, y0 - y, Color.Yellow);
            b.SetPixel(x0 - x, y0 - y, Color.Green);
            b.SetPixel(x0 + y, y0 +x, Color.Black);
            b.SetPixel(x0 - y, y0 + x, Color.SpringGreen);
            b.SetPixel(x0 + y, y0 - x, Color.Orange);
            b.SetPixel(x0 - y, y0 - x, Color.Gray);
        }

        void Draw_Circle(int xA, int yA, int R)
        {
            int x, y, d;
            x = 0; y = R; d = 5 - 4 * R;

            while (x<=y)
            {
                Draw8Pixel(w / 2 + xA, h / 2 + yA, x, y);
                if (d < 0)
                {
                    d += 4 * (2 * x + 3);
                }
                else
                {
                    d += 4 * (2 * x - 2 * y + 5);
                    y--;
                }
                x++;
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtX.Text);
            int y = int.Parse(txtY.Text);
            int r = int.Parse(txtR.Text);
            Draw_Circle(x, y, r); ;
            picView.Image = b;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            b = new Bitmap(w, h);
            drawCoordinateAxis();
        }

    }
}
