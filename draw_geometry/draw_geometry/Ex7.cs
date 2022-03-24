using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace draw_geometry
{
    public partial class Ex7 : Form
    {
        public Ex7()
        {
            InitializeComponent();
        }

        const float x_default = 200, y_default = 200, r_circle_default = 50;
        bool have_moon = false;
        float r_circle = r_circle_default, x = x_default, y = y_default;
        int  i = 0, i_moon = 0;
        Bitmap b;
        Graphics gp;
        Pen pen;

        private void Ex7_Load(object sender, EventArgs e)
        {
            b = new Bitmap(picView.Width, picView.Height);
            gp = Graphics.FromImage(b);
            pen = new Pen(Color.LightBlue,3);
            applyChangeScale();
        }

        void draw()
        {
           gp.Clear(Color.WhiteSmoke);

            float r_circle_small = r_circle/4;
            float r_circle_small2 = r_circle / 8;
            float r_circle_small3 = r_circle / 20;

            PointF center = new PointF(x - r_circle, y - r_circle);
            PointF loc = _process.cirlePoint(r_circle, 60 + i, new PointF(x, y));

            gp.DrawEllipse(pen, _process.getCircle(center, r_circle));
            gp.FillEllipse(Brushes.Yellow, _process.getCircle(new PointF(x - r_circle_small, y - r_circle_small), r_circle_small));
            gp.FillEllipse(Brushes.Blue, _process.getCircle(new PointF(loc.X - r_circle_small2, loc.Y - r_circle_small2), r_circle_small2));

            if (have_moon)
            {
                PointF loc_moon = _process.cirlePoint(r_circle_small2 * 2, 60 + i * 10, new PointF(loc.X, loc.Y));
                gp.FillEllipse(Brushes.Gray, _process.getCircle(new PointF(loc_moon.X - r_circle_small3, loc_moon.Y - r_circle_small3), r_circle_small3));
            }
           
            picView.Image = b;
        }

        private void picView_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            draw();
        }

        private void trackScale_ValueChanged(object sender, EventArgs e)
        {
            applyChangeScale();
        }

        void applyChangeScale()
        {
            lblScale.Text = trackScale.Value.ToString() + "X";
            r_circle = r_circle_default * trackScale.Value;
            draw();
        }

        private void rdbDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDefault.Checked)
            {
                draw();
                timeRun.Stop();
                timerMoon.Stop();
            }
        }

        private void timeRun_Tick(object sender, EventArgs e)
        {
            i = i < 360 ? i + 2 : i = 0;
            draw();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            r_circle = r_circle_default;
            x = x_default;
            y = y_default;
            i = 0;
            draw();
            trackScale.Value = 1;
            rdbDefault.Checked = true;
        }

        private void rdbRotate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRotate.Checked)
            {
                timeRun.Start();
                timerMoon.Stop();
            }
        }

        private void rdbHaveMoon_CheckedChanged(object sender, EventArgs e)
        {
            have_moon = rdbHaveMoon.Checked;
            timeRun.Stop();
            timerMoon.Start();
        }

        private void timerMoon_Tick(object sender, EventArgs e)
        {
            i = i < 360 ? i + 2 : i = 0;
            i_moon = i_moon < 360 ? i_moon + 10 : i_moon = 0;
            draw();
        }
       
    }
}
