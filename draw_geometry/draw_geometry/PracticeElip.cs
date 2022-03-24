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
    public partial class PracticeElip : Form
    {
        Bitmap b;
        Color color;
        int w = 400, h = 400;

        public PracticeElip()
        {
            InitializeComponent();
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

        private void PracticeElip_Load(object sender, EventArgs e)
        {
            b = new Bitmap(w, h);
            drawCoordinateAxis();
        }

        void Draw4Pixel(int xE, int yE, int x, int y)
        {
            b.SetPixel(xE + x, yE + y, color);
            b.SetPixel(xE - x, yE + y, color);
            b.SetPixel(xE + x, yE - y, color);
            b.SetPixel(xE - x, yE - y, color);
        }

        void Draw_Ellipse(int xE, int yE, int a, int b)
        {
            int x = 0, y = b;
            double a2 = (double)a * a;
            double b2 = (double)b * b;
            double d = 4 * b2 + a2 * (1 - 4 * b);
            while (b2 * (x + 1) < a2 * (y - 0.5))
            {
                Draw4Pixel(w / 2 + xE, h / 2 + yE, x, y);
                if (d < 0)
                {
                    d += 4 * b2 * (2 * x + 3);
                }
                else
                {
                    d += 4 * (b2 * (2 * x + 3) - a2 * (2 * y - 2));
                    y--;
                }
                x++;
            }

            d = b2 * (x + 0.5) * (x + 0.5) + a2 * (y - 1) * (y - 1) - a2 * b2;
            while (y>=0)
            {
                Draw4Pixel(w / 2 + xE, h / 2 + yE, x, y);
                if (d > 0)
                {
                    d += -4 * a2 * (2 * y - 3);
                }
                else
                {
                    d += 4 * (b2 * (2 * x + 2) - a2 * (2 * y - 3));
                    x++;
                }
                y--;
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            int xE = int.Parse(txtX.Text);
            int yE = int.Parse(txtY.Text);
            int rX = int.Parse(txtRx.Text);
            int rY = int.Parse(txtRy.Text);
            byte red = byte.Parse(txtRed.Text);
            byte green = byte.Parse(txtGreen.Text);
            byte blue = byte.Parse(txtBlue.Text);
            color = Color.FromArgb(red, green, blue);
            Draw_Ellipse(xE, yE, rX, rY);
            picView.Image = b;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            b = new Bitmap(w, h);
            drawCoordinateAxis();
        }
    }
}
