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
    public partial class Clock : Form
    {
        public Clock()
        {
            InitializeComponent();
        }

        const float x_default = 690, y_default = 230;
        float x = x_default, y = y_default;

        Bitmap b;
        Graphics gp;

        Pen pen;
        Pen pen_Kim_S;
        Pen pen_Kim_M;
        Pen pen_Kim_H;
        Pen pen_M;
        Pen pen_H;
        Pen pen_H_Main;
        Pen penBorder;

        private void Clock_Load(object sender, EventArgs e)
        {
            b = new Bitmap(picView.Width, picView.Height);
            gp = Graphics.FromImage(b);
            pen = new Pen(Color.Black, 6);
            penBorder = new Pen(Color.Black, 15);
            pen_M = new Pen(Color.Black, 2);
            pen_H = new Pen(Color.Black, 4);
            pen_H_Main = new Pen(Color.Black, 10);
            pen_Kim_S = new Pen(Color.Red, 2);
            pen_Kim_M = new Pen(Color.Black, 4);
            pen_Kim_H = new Pen(Color.Black, 8);
            draw();
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
            float r_circle = 200;
            float second = DateTime.Now.Second;
            float minute = DateTime.Now.Minute;
            float hour = DateTime.Now.Hour;
            float s = 270 + second * 6 > 360 ? (270 + second * 6) - 360 : 270 + second * 6;
            float m = 270 + minute * 6 + second / 60 * 6 > 360 ? (270 + minute * 6 + second / 60 * 6) - 360 : 270 + minute * 6 + second / 60 * 6;
            float h = 270 + hour * 30 > 360 + minute / 60 * 30 ? (270 + hour * 30 + minute / 60 * 30) - 360 : 270 + hour * 30 + minute / 60 * 30;
            float s_s = s + 180 >= 360 ? s + 180 - 360 : s + 180;
            float m_m = m + 180 >= 360 ? m + 180 - 360 : m + 180;
            float h_h = h + 180 >= 360 ? h + 180 - 360 : h + 180;

            PointF center = new PointF(x - r_circle, y - r_circle);
            PointF center_line = new PointF(x, y);
            PointF loc_s = _process.cirlePoint(r_circle - 10, s, center_line);
            PointF loc_s_s = _process.cirlePoint(r_circle / 3.5f, s_s, center_line);
            PointF loc_m = _process.cirlePoint(r_circle - 50, m, center_line);
            PointF loc_m_m = _process.cirlePoint(r_circle / 8, m_m, center_line);
            PointF loc_h = _process.cirlePoint(r_circle - 90, h, center_line);
            PointF loc_h_h = _process.cirlePoint(r_circle / 12, h_h, center_line);

            gp.DrawEllipse(pen, _process.getCircle(center, r_circle));
            gp.DrawEllipse(penBorder, _process.getCircle(new PointF(center.X - 12f, center.Y - 12f), r_circle + 12));

            List<PointF> lstH = new List<PointF>();
            List<PointF> lstH_main = new List<PointF>();
            List<PointF> lstM = new List<PointF>();
            for (int i = 0; i < 60; i++)
            {
                PointF loc = _process.cirlePoint(r_circle, i * 6, center_line);
                if (i % 15 == 0)
                {
                    lstH_main.Add(loc);
                }
                else if (i % 5 == 0)
                {
                    lstH.Add(loc);
                }
                else
                {
                    lstM.Add(loc);
                }

            }
            foreach (PointF item in lstM)
            {
                gp.DrawLine(pen_M, center_line, item);
            }
            gp.FillEllipse(Brushes.WhiteSmoke, _process.getCircle(new PointF(center.X + 5, center.Y + 5), r_circle - 5));

            foreach (PointF item in lstH)
            {
                gp.DrawLine(pen_H, center_line, item);
            }
            gp.FillEllipse(Brushes.WhiteSmoke, _process.getCircle(new PointF(center.X + 8, center.Y + 8), r_circle - 8));

            foreach (PointF item in lstH_main)
            {
                gp.DrawLine(pen_H_Main, center_line, item);
            }
            gp.FillEllipse(Brushes.WhiteSmoke, _process.getCircle(new PointF(center.X + 10, center.Y + 10), r_circle - 10));


            gp.DrawLine(pen_Kim_H, center_line, loc_h);
            gp.DrawLine(pen_Kim_H, center_line, loc_h_h);

            gp.DrawLine(pen_Kim_M, center_line, loc_m);
            gp.DrawLine(pen_Kim_M, center_line, loc_m_m);

            gp.DrawLine(pen_Kim_S, center_line, loc_s);
            gp.DrawLine(pen_Kim_S, center_line, loc_s_s);

            gp.FillEllipse(Brushes.Red, _process.getCircle(new PointF(center.X + 194, center.Y + 194), r_circle - 194));
            gp.FillEllipse(Brushes.Red, _process.getCircle(new PointF(loc_s_s.X - 5, loc_s_s.Y - 5), 5));
            picView.Image = b;
        }

        private void timeRun_Tick(object sender, EventArgs e)
        {
            draw();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timeRun.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timeRun.Enabled = true;
        }
    }
}
