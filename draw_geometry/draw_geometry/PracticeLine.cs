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
    public partial class PracticeLine : Form
    {
        Bitmap b;
        int w = 400, h = 400;

        public PracticeLine()
        {
            InitializeComponent();
        }

        private void Practice1_Load(object sender, EventArgs e)
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

        void Bres(int xa, int ya, int xb, int yb, int k)
        {
            int Dx = xb - xa;
            int Dy = yb - ya;

            int d = 2 * Dy - Dx;
            int x = xa;
            int y = ya;

            while (x <= xb && y <= yb)
            {
                switch (k)
                {
                    case 0:
                        {
                            b.SetPixel(x, y, Color.Green);
                            break;
                        }
                    case 1:
                        {
                            b.SetPixel(y, x, Color.Red);
                            break;
                        }
                    case 2:
                        {
                            b.SetPixel(x, -y, Color.Blue);
                            break;
                        }
                    case 3:
                        {
                            b.SetPixel(y, -x, Color.Violet);
                            break;
                        }
                    default:
                        break;
                }

                if (d < 0)
                {
                    d += 2 * Dy; x++;
                }
                else
                {
                    d += 2 * (Dy - Dx); y++; x++;
                }

            }
        }

        void LineBres(int xa, int ya, int xb, int yb)
        {
            if (xa > xb)
            {
                int t = xa;
                xa = xb;
                xb = t; 
                t = ya; 
                ya = yb;
                yb = t;
            }

            int Dx = xb - xa;
            int Dy = yb - ya;

            if (0 < Dy && Dy < Dx)
            {
                Bres(xa, yb, xb, yb, 0);
            }

            if (Dy > Dx)
            {
                int xa_new = ya;
                int ya_new = xa;
                int xb_new = yb;
                int yb_new = xb;
                Bres(xa_new, ya_new, xb_new, yb_new, 1);
            }

            if (-Dx < Dy && Dy < 0)
            {
                int xa_new = xa;
                int ya_new = -ya;
                int xb_new = xb;
                int yb_new = -yb;
                Bres(xa_new, ya_new, xb_new, yb_new, 2);
            }

            if (Dy < -Dx)
            {
                int xa_new = -ya;
                int ya_new = xa;
                int xb_new = -yb;
                int yb_new = xb;
                Bres(xa_new, ya_new, xb_new, yb_new, 3);
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            int xA = int.Parse(txtXA.Text);
            int yA = int.Parse(txtYA.Text);
            int xB = int.Parse(txtXB.Text);
            int yB = int.Parse(txtYB.Text);

            LineBres(xA, yA, xB, yB);
            picView.Image = b;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            b = new Bitmap(w, h);
            drawCoordinateAxis();
        }

    }
}
