﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Darkside_Form
{
    public class Circle
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public void draw(Graphics g, Pen p)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
                g.DrawEllipse(p, 0, 0, radius, radius);
        }

        
    }
}
