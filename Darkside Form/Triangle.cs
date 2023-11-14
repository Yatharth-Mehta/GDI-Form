using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darkside_Form
{
    public class Triangle
    {
        public Triangle(Graphics g, Pen p)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            Point[] points = { new Point(10, 100), new Point(120, 10), new Point(200, 100) };
            g.DrawPolygon(p, points);
        }
    }
}
