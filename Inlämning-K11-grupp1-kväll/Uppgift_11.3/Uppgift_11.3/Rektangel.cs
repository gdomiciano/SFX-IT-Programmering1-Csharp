using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Uppgift_11._3
{
    class Rektangel
    {

        public int höjd { get; set; }
        public int bredd { get; set; }

        public Rektangel(int höjd, int bredd)
        {
            this.höjd = höjd;
            this.bredd = bredd;
        }

        public void Rita(Graphics g)
        {
            g.DrawRectangle( new Pen (Color.Red), 200, 100, höjd, bredd);
        }

        public int FåArean()
        {
            return höjd * bredd;
        }
    }
}
