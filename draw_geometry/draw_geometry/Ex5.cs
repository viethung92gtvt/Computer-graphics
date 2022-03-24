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
    public partial class Ex5 : Form
    {
        public Ex5()
        {
            InitializeComponent();
        }

     
        private void Ex6_Load(object sender, EventArgs e)
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
            float r_circle2 = 70;

            PointF center = new PointF(x - r_circle, y - r_circle);
            PointF locA = _process.cirlePoint(r_circle , 45, new PointF(x, y));
            PointF locB = _process.cirlePoint(r_circle , 135, new PointF(x, y));
            PointF locC = _process.cirlePoint(r_circle , 225, new PointF(x, y));
            PointF locD = _process.cirlePoint(r_circle , 315, new PointF(x, y));   
         
            PointF loc_a = _process.cirlePoint(r_circle *2, 0, new PointF(x, y));
            PointF loc_b = _process.cirlePoint(r_circle *2, 90, new PointF(x, y));
            PointF loc_c = _process.cirlePoint(r_circle *2, 180, new PointF(x, y));
            PointF loc_d = _process.cirlePoint(r_circle *2, 270, new PointF(x, y));

            Pen pen = new Pen(Color.Blue, 2);

            gp.DrawPolygon(_process.getPen(), new PointF[] { locA, locB, locC, locD });
            gp.DrawEllipse(_process.getPen(), _process.getCircle(loc_a, r_circle2,r_circle2));
            gp.DrawEllipse(_process.getPen(), _process.getCircle(loc_b, r_circle2, r_circle2));
            gp.DrawEllipse(_process.getPen(), _process.getCircle(loc_c, r_circle2,  r_circle2));
            gp.DrawEllipse(_process.getPen(), _process.getCircle(loc_d, r_circle2, r_circle2));            
            picView.Image = b;
        }

        private void picView_MouseClick(object sender, MouseEventArgs e)
        {
            draw(e.X, e.Y);
        }
    }
}
