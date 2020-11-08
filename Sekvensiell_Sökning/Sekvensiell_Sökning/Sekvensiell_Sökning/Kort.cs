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
        /// <summary>
        /// Egenskap för att sätta/hämta kortets bredd
        /// </summary>
        public int bredd { get; set; } = 50;
        /// <summary>
        /// Egenskap för att sätta/hämta kortets höjd
        /// </summary>
        public int höjd { get; set; } = 70;
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

                g.DrawRectangle(penna, x, y, bredd, höjd);
                g.FillRectangle(pensel, x, y, bredd, höjd);


                // Rita en rutersymbol i mitten
                penna.Color = pensel.Color = rödFärg;

                //addera +1 när dela stolek by 4 eftersom det är en heltal och jag vill inte byta datatyp som Point ävands int
                Point[] points = {
                    new Point((x + bredd/2), (y + (höjd/4)+1)),
                    new Point((x + ((bredd/4)*3)+1), (y + höjd/2)),
                    new Point((x + bredd/2), (y + ((höjd/4)*3)+1)),
                    new Point((x + (bredd/4)+1), (y + höjd/2))
                };

                g.DrawPolygon(penna, points);
                g.FillPolygon(pensel, points);

                // Skriv valören i hörnen
                g.DrawString(valör.ToString(), SystemFonts.DefaultFont, pensel, x + 5, y + 5);
                g.DrawString(valör.ToString(), SystemFonts.DefaultFont, pensel, x + bredd - 15, y + höjd - 15);
            }
            else
            {
                // Ritar baksidan som en röd rektangel
                g.DrawRectangle(penna, x, y, bredd, höjd);
                g.FillRectangle(pensel, x, y, bredd, höjd);
            }
        }
    }
}
