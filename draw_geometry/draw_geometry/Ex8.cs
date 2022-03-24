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
    public partial class Ex8 : Form
    {
        public Ex8()
        {
            InitializeComponent();
        }

        private void Ex8_Load(object sender, EventArgs e)
        {
            draw();
        }

        private void picView_MouseClick(object sender, MouseEventArgs e)
        {
            draw(e.X, e.Y);
        }

        void draw(float x = 200, float y = 200)
        {
            int w = picView.Width;
            int h = picView.Height;
            Bitmap b = new Bitmap(w, h);
            Graphics gp = Graphics.FromImage(b);
            float r_circle = 50;

            PointF center = new PointF(x - r_circle, y - r_circle);

            Pen pen = new Pen(Color.Blue, 2);

            PointF locA = _process.cirlePoint(r_circle*2,90, new PointF(x, y));
            PointF locB = _process.cirlePoint(r_circle*2, 210 , new PointF(x, y));
            PointF locC = _process.cirlePoint(r_circle*2, 330 , new PointF(x, y));

            PointF locA_a = _process.cirlePoint(r_circle * 1.5F, 30, locA);
            PointF locA_b = _process.cirlePoint(r_circle * 1.5F, 150, locA);
            PointF locA_c = _process.cirlePoint(r_circle * 1.5F, 270, locA);

            PointF locB_a = _process.cirlePoint(r_circle * 1.5F, 30, locB);
            PointF locB_b = _process.cirlePoint(r_circle * 1.5F, 150, locB);
            PointF locB_c = _process.cirlePoint(r_circle * 1.5F, 270, locB);

            PointF locC_a = _process.cirlePoint(r_circle * 1.5F, 30, locC);
            PointF locC_b = _process.cirlePoint(r_circle * 1.5F, 150, locC);
            PointF locC_c = _process.cirlePoint(r_circle * 1.5F, 270, locC);

            gp.DrawEllipse(_process.getPen(), _process.getCircle(center, r_circle));
            
            gp.DrawPolygon(_process.getPen(), new PointF[] { locA_a, locA_b, locA_c });

            gp.DrawPolygon(_process.getPen(), new PointF[] { locB_a, locB_b, locB_c });

            gp.DrawPolygon(_process.getPen(), new PointF[] { locC_a, locC_b, locC_c });

            gp.FillEllipse(Brushes.WhiteSmoke, _process.getCircle(new PointF(center.X + 2, center.Y + 2), r_circle - 2));
            

            picView.Image = b;
        }
    }
}
