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
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
        }

        private void Ex3_Load(object sender, EventArgs e)
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
            float size = 400;
            float r_circle = size / 2;

            PointF center = new PointF(x-r_circle, y-r_circle);
            PointF locA = _process.cirlePoint(r_circle, 30, new PointF(x, y));
            PointF locB = _process.cirlePoint(r_circle, 150, new PointF(x, y));
            PointF locC = _process.cirlePoint(r_circle, 270, new PointF(x, y));

            PointF loc_a = _process.cirlePoint(r_circle/2, 90, new PointF(x, y));
            PointF loc_b = _process.cirlePoint(r_circle/2, 210, new PointF(x, y));
            PointF loc_c = _process.cirlePoint(r_circle/2, 330, new PointF(x, y));

            Pen pen = new Pen(Color.Blue, 2);
            gp.DrawRectangle(_process.getPen(), x - r_circle, y-r_circle, size, size);
            gp.DrawEllipse(_process.getPen(), _process.getCircle(center, r_circle));
            gp.DrawPolygon(_process.getPen(), new PointF[] { locA, locB, locC });
            gp.DrawPolygon(_process.getPen(), new PointF[] { loc_a, loc_b, loc_c });
            picView.Image = b;
        }
    }
}
