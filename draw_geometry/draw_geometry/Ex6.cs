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
    public partial class Ex6 : Form
    {
        public Ex6()
        {
            InitializeComponent();
        }

        const float x_default = 200, y_default = 200, r_circle_default = 25;
        float r_circle = r_circle_default, x = x_default, y = y_default;
        int _type = 0;
        int i = 0;
        Bitmap b;
        Graphics gp;

        private void Ex6_Load(object sender, EventArgs e)
        {
            b = new Bitmap(picView.Width, picView.Height);
            gp = Graphics.FromImage(b);
            applyChangeScale();
        }

        private void picView_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            draw();
        }

        void draw()
        {
            gp.Clear(Color.WhiteSmoke);

            int angle = i;
            if (_type == _process.type_rotateCounterclockwise)
            {
                angle = i * -1;
            }

            PointF center = new PointF(x - r_circle, y - r_circle);
            PointF loc;
            float r = 360 / 12;

            gp.DrawEllipse(_process.getPen(), _process.getCircle(center, r_circle));
            for (int j = 0; j <= 12; j++)
            {
                loc = _process.cirlePoint(r_circle, r * j + angle, new PointF(x, y));
                gp.DrawLine(_process.getPen(), new PointF(x, y), loc);
            }

            picView.Image = b;
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

        private void rdbRotateClockwise_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRotateClockwise.Checked)
            {
                _type = _process.type_RotateClockwise;
                i = 0;
                timeRun.Start();
            }
        }

        private void rdbDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDefault.Checked)
            {
                _type = _process.type_default;
                draw();
                timeRun.Stop();
            }
        }

        private void rdbRotateCounterclockwise_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRotateCounterclockwise.Checked)
            {
                _type = _process.type_rotateCounterclockwise;
                timeRun.Start();
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
    }
}
