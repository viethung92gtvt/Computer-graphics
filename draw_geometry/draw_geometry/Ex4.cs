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
    public partial class Ex4 : Form
    {
        public Ex4()
        {
            InitializeComponent();
        }

        private void Ex4_Load(object sender, EventArgs e)
        {
            draw();
        }

        void draw(float x = 200, float y = 200)
        {
            int w = picView.Width;
            int h = picView.Height;
            Bitmap b = new Bitmap(w, h);
            Graphics gp = Graphics.FromImage(b);
            float r_circle = 100;

            PointF center = new PointF(x - r_circle, y - r_circle);
            PointF locA = _process.cirlePoint(r_circle *2, 45, new PointF(x, y));
            PointF locB = _process.cirlePoint(r_circle *2, 135, new PointF(x, y));
            PointF locC = _process.cirlePoint(r_circle *2, 225, new PointF(x, y));
            PointF locD = _process.cirlePoint(r_circle *2, 315, new PointF(x, y));

            PointF loc_a = _process.cirlePoint(r_circle *3, 45, new PointF(x, y));
            PointF loc_b = _process.cirlePoint(r_circle *3, 135, new PointF(x, y));
            PointF loc_c = _process.cirlePoint(r_circle *3, 225, new PointF(x, y));
            PointF loc_d = _process.cirlePoint(r_circle *3, 315, new PointF(x, y));

            Pen pen = new Pen(Color.Blue, 2);
            gp.DrawEllipse(_process.getPen(), _process.getCircle(center, r_circle));
            gp.DrawPolygon(_process.getPen(), new PointF[] { locA, locB, locC, locD });
            gp.DrawPolygon(_process.getPen(), new PointF[] { loc_a, loc_b, loc_c,loc_d });
            gp.DrawLine(_process.getPen(), locA, loc_a);
            gp.DrawLine(_process.getPen(), locB, loc_b);
            gp.DrawLine(_process.getPen(), locC, loc_c);
            gp.DrawLine(_process.getPen(), locD, loc_d);
            picView.Image = b;
        }

        private void picView_MouseClick(object sender, MouseEventArgs e)
        {
            draw(e.X, e.Y);
        }
    }
}
