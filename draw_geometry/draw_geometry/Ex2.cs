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
    public partial class Ex2 : Form
    {
        public Ex2()
        {
            InitializeComponent();
        }

        private void Ex2_Load(object sender, EventArgs e)
        {
            draw();
        }

        void draw(float x = 200, float y = 200)
        {
            int w = picView.Width;
            int h = picView.Height;
            Bitmap b = new Bitmap(w, h);
            Graphics gp = Graphics.FromImage(b);
            float r_circle_lagre = 200;
            float r_circle_small = r_circle_lagre / 3;

            PointF center = new PointF(x - r_circle_lagre, y - r_circle_lagre);
            PointF center_circle_small = new PointF(x - r_circle_small, y - r_circle_small);

            PointF center_circle_small_top = new PointF(x - r_circle_small, y - r_circle_lagre);
            PointF center_circle_small_button = new PointF(x - r_circle_small, y + r_circle_small);
            PointF center_circle_small_left = new PointF(x - r_circle_lagre, y - r_circle_small);
            PointF center_circle_small_right = new PointF(x + r_circle_small, y - r_circle_small);

            gp.DrawEllipse(_process.getPen(), _process.getCircle(center, r_circle_lagre));
            gp.DrawEllipse(_process.getPen(), _process.getCircle(center_circle_small, r_circle_small));
            gp.DrawEllipse(_process.getPen(), _process.getCircle(center_circle_small_top, r_circle_small));
            gp.DrawEllipse(_process.getPen(), _process.getCircle(center_circle_small_button, r_circle_small));
            gp.DrawEllipse(_process.getPen(), _process.getCircle(center_circle_small_right, r_circle_small));
            gp.DrawEllipse(_process.getPen(), _process.getCircle(center_circle_small_left, r_circle_small));

            Pen pen = _process.getPen();
            gp.DrawLine(pen, _process.movePoint(center_circle_small_top, r_circle_small), _process.movePoint(center_circle_small_left, r_circle_small));
            gp.DrawLine(pen, _process.movePoint(center_circle_small_top, r_circle_small), _process.movePoint(center_circle_small_right, r_circle_small));
            gp.DrawLine(pen, _process.movePoint(center_circle_small_button, r_circle_small), _process.movePoint(center_circle_small_left, r_circle_small));
            gp.DrawLine(pen, _process.movePoint(center_circle_small_button, r_circle_small), _process.movePoint(center_circle_small_right, r_circle_small));

            picView.Image = b;
        }

        private void picView_MouseClick(object sender, MouseEventArgs e)
        {
            draw(e.X, e.Y);
        }
    }
}
