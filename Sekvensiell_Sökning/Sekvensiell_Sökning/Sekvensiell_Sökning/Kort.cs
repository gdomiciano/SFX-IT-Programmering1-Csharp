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

        private const int bredd = 50;
        // Kortets höjd
        private const int höjd = 70;
        // Bestämmer om kortets fram eller baksida ska ritas
        private bool visaFramsida = true;
        /// <summary>
        /// Egenskap för att sätta/hämta kortets x-läge
        /// </summary>
        public int x
        {
            get; set;
        }
        /// <summary>
        /// Egenskap för att sätta/hämta kortets y-läge
        /// </summary>
        public int y
        {
            get; set;
        }
        /// <summary>
        /// Egenskap för att sätta/hämta kortets valör
        /// </summary>
        public int valör
        {
            get; set;
        }
        /// <summary>
        /// Egenskap för att hämta kortets bredd
        /// </summary>
       // public int Bredd
       // {
       //     get; set;
      //  }
        /// <summary>
        /// Egenskap för att hämta kortets höjd
        /// </summary>
     //   public int Höjd
     //   {
     //       get; set;
     //   }
        /// <summary>
        /// Egenskap för att sätta/hämta om framsidan ska visas eller inte
        /// </summary>
        public bool VisaFramsida
        {
            get; set;
        }
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

            if (VisaFramsida)
            {
                // Kortets framsida ritas
                // Rita en vit framsida
                penna.Color = pensel.Color = vitFärg;
                g.DrawRectangle(penna, this.x, this.y, bredd, höjd);
                g.FillRectangle(pensel, this.x, this.y, bredd, höjd);

                penna.Color = pensel.Color = rödFärg;

                // Rita en rutersymbol i mitten
                Point[] points = {
                new Point(this.x + bredd/2, this.y + höjd/4),
                new Point(this.x + (bredd/4)*3, this.y + höjd/2),
                new Point(this.x + bredd/2, this.y + (höjd/4)*3),
                new Point(this.x + (bredd/4), this.y + höjd/2)};
                g.DrawPolygon(penna, points);
                g.FillPolygon(pensel, points);

                // Skriv valören i hörnen
                g.DrawString(this.valör.ToString(), SystemFonts.DefaultFont, pensel, this.x + 5, this.y + 5);
                g.DrawString(this.valör.ToString(), SystemFonts.DefaultFont, pensel, this.x + bredd - 15, this.y + höjd - 15);
            }
            else
            {
                // Ritar baksidan som en röd rektangel
                g.DrawRectangle(penna, this.x, this.y, bredd, höjd);
                g.FillRectangle(pensel, this.x, this.y, bredd, höjd);
            }
        }
    }
}
