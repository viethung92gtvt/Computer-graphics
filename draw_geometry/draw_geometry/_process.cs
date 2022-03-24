using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace draw_geometry
{
    class _process
    {
        static Random rnd = new Random();
        public const int type_default = 1, type_RotateClockwise = 2, type_rotateCounterclockwise = 3;

        public static Pen getPen(int bold = 2)
        {
            return new Pen(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)), bold);
        }

        public static RectangleF getCircle(PointF center, float radius1, float radius2)
        {
            return new RectangleF(center.X - radius1, center.Y - radius2, radius1 * 2, radius2 * 2);
        }

        public static RectangleF getCircle(PointF center, float radius)
        {
            return new RectangleF(center.X, center.Y, radius * 2, radius * 2);
        }

        public static PointF movePoint(PointF p, float distance)
        {
            return new PointF(p.X + distance, p.Y + distance);
        }

        public static PointF cirlePoint(float radius, float angleInDegrees, PointF origin)
        {
            float x = (float)(radius * Math.Cos(angleInDegrees * Math.PI / 180)) + origin.X;
            float y = (float)(radius * Math.Sin(angleInDegrees * Math.PI / 180)) + origin.Y;

            return new PointF(x, y);
        }
    }
}
