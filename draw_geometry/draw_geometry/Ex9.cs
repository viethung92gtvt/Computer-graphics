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
    public partial class Ex9 : Form
    {
        public Ex9()
        {
            InitializeComponent();
        }

        private void Ex9_Load(object sender, EventArgs e)
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
            float r_circle = 100;

            PointF center = new PointF(x - r_circle, y - r_circle);

            Pen pen = new Pen(Color.Blue, 2);

            PointF locA = _process.cirlePoint(r_circle * 2, 30, new PointF(x, y));
            PointF locB = _process.cirlePoint(r_circle * 2, 90, new PointF(x, y));
            PointF locC = _process.cirlePoint(r_circle * 2, 150, new PointF(x, y));
            PointF locD = _process.cirlePoint(r_circle * 2, 210, new PointF(x, y));
            PointF locE = _process.cirlePoint(r_circle * 2, 270, new PointF(x, y));
            PointF locF = _process.cirlePoint(r_circle * 2, 330, new PointF(x, y));



            gp.DrawEllipse(_process.getPen(), _process.getCircle(center, r_circle));
            gp.DrawPolygon(_process.getPen(), new PointF[] { locA, locB, locC, locD, locE, locF });
            gp.DrawPolygon(_process.getPen(), new PointF[] { locA, locC, locE });
            gp.DrawEllipse(_process.getPen(), center.X - r_circle, center.Y - r_circle, r_circle * 4, r_circle * 4);



            picView.Image = b;
        }
    }
}
