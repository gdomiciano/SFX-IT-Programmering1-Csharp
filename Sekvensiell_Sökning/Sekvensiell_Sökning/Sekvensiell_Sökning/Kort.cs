using System;
using System.Collections.Generic;
using System.Drawing;
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
            Color färg = Color.DarkRed;
            Pen penna = new Pen(färg);
            SolidBrush pensel = new SolidBrush(färg);
            if (VisaFramsida)
            {
                // Kortets framsida ritas
                // Rita en vit framsida

                // Rita en rutersymbol i mitten
                // Skriv valören i hörnen
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
