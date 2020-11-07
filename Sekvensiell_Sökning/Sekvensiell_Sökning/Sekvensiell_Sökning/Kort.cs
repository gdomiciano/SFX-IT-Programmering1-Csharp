using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekvensiell_Sökning
{
    class Kort
    {
        // Kortets bredd
        private const int bredd = 50;
        // Kortets höjd
        private const int höjd = 70;
        /// <summary>
        /// Egenskap för att sätta/hämta kortets x-läge
        /// </summary>
        public int x {get; set;}
        /// <summary>
        /// Egenskap för att sätta/hämta kortets y-läge
        /// </summary>
        public int y {get; set;}
        /// <summary>
        /// Egenskap för att sätta/hämta kortets valör
        /// </summary>
        public int valör {get; set;}

        /// <summary>
        /// Egenskap för att sätta/hämta om framsidan ska visas eller inte
        /// </summary>
        public bool visaFramsida {get; set;} = false;

        public static int Bredd => bredd;

        public static int Höjd => höjd;

        /// <summary>
        /// Konstruktor som initierar ett kort
        /// </summary>
        /// <param name="x">Kortets x-läge</param>
        /// <param name="y">kortets y-läge</param>
        /// <param name="valör">Kortets valör</param>
        public Kort(int x, int y, int valör)
        {
            this.x = x;
            this.y = y;
            this.valör = valör;
        }
        /// <summary>
        /// Ritar ett ruterkort. En enda rutersymbol ritas i mitten av kortet.
        /// </summary>
        /// <param name="g"></param>
        public void Rita(Graphics g)
        {
            Color rödFärg = Color.DarkRed;
            Color vitFärg = Color.White;
            Pen penna = new Pen(rödFärg);
            SolidBrush pensel = new SolidBrush(rödFärg);

            if (visaFramsida)
            {
                // Kortets framsida ritas
                // Rita en vit framsida
                penna.Color = pensel.Color = vitFärg;

                g.DrawRectangle(penna, x, y, Bredd, Höjd);
                g.FillRectangle(pensel, this.x, this.y, Bredd, Höjd);


                // Rita en rutersymbol i mitten
                penna.Color = pensel.Color = rödFärg;

                Point[] points = {
                new Point(this.x + Bredd/2, this.y + Höjd/4),
                new Point(this.x + (Bredd/4)*3, this.y + Höjd/2),
                new Point(this.x + Bredd/2, this.y + (Höjd/4)*3),
                new Point(this.x + (Bredd/4), this.y + Höjd/2)};

                g.DrawPolygon(penna, points);
                g.FillPolygon(pensel, points);

                // Skriv valören i hörnen
                g.DrawString(valör.ToString(), SystemFonts.DefaultFont, pensel, x + 5, y + 5);
                g.DrawString(valör.ToString(), SystemFonts.DefaultFont, pensel, x + Bredd - 15, y + Höjd - 15);
            }
            else
            {
                // Ritar baksidan som en röd rektangel
                g.DrawRectangle(penna, x, y, Bredd, Höjd);
                g.FillRectangle(pensel, x, y, Bredd, Höjd);
            }
        }
    }
}
