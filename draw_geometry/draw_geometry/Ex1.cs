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
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
        }

        private void Ex1_Load(object sender, EventArgs e)
        {
            draw();
        }

        void draw(float x = 200, float y = 200)
        {
            int w = picView.Width;
            int h = picView.Height;
            Bitmap b = new Bitmap(w, h);
            Graphics gp = Graphics.FromImage(b);
            PointF center = new PointF(x, y);

            float r_circle_large = 200;
            float r_circle_small = r_circle_large / 2;

            gp.DrawEllipse(_process.getPen(), _process.getCircle(center, r_circle_large, r_circle_large));
            gp.DrawEllipse(_process.getPen(), _process.getCircle(center, r_circle_small, r_circle_small));
            gp.DrawEllipse(_process.getPen(), _process.getCircle(center, r_circle_large, r_circle_small));


            //Bổ sung hình tam giác
            PointF pointA = _process.cirlePoint(r_circle_small, -90, center);
            PointF pointB = _process.cirlePoint(r_circle_small,-210, center);
            PointF pointC = _process.cirlePoint(r_circle_small, -330, center);
            gp.DrawPolygon(_process.getPen(), new PointF[] { pointA, pointB, pointC });

            picView.Image = b;
        }

        private void picView_MouseClick(object sender, MouseEventArgs e)
        {
            draw(e.X, e.Y);
        }
    }
}
