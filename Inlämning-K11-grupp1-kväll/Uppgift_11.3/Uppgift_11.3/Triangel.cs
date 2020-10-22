using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_11._3
{
    class Triangel
    {
        public int höjd { get; set; }
        public int bredd { get; set; }

        public Triangel(int höjd, int bredd)
        {
            this.höjd = höjd;
            this.bredd = bredd > 0 ? bredd : höjd;
        }

        public void Rita(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.Red), 50, 50, höjd, bredd);
        }

        public int FåArean()
        {
            return höjd * bredd;
        }
    }
}
