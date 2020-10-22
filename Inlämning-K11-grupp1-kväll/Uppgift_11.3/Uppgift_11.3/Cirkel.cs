using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Uppgift_11._3
{
    class Cirkel
    {
        public int radius { get; set; }

        public Cirkel (int radius)
        {
            this.radius = radius;
        }

        public void Rita(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Red), 200, 100, radius, radius);
        }

        public double FåArean()
        {
            return 2 * Math.PI * radius;
        }
    }
}
