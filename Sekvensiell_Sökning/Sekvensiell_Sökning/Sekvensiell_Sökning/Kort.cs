using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekvensiell_Sökning
{
    class Kort
    {

        // Kortets x-läge
        private int x;
        // Kortets y-läge
        private int y;
        // Kortets valör
        private int valör;
        // Kortets bredd
        private int bredd = 50;
        // Kortets höjd
        private int höjd = 70;
        // Bestämmer om kortets fram eller baksida ska ritas
        private bool visaFramsida = true;
        /// <summary>
        /// Egenskap för att sätta/hämta kortets x-läge
        /// </summary>
        public int X
        {
        }
        /// <summary>
        /// Egenskap för att sätta/hämta kortets y-läge
        /// </summary>
        public int Y
        {
        }
        /// <summary>
        /// Egenskap för att sätta/hämta kortets valör
        /// </summary>
        public int Valör
        {
        }
        /// <summary>
        /// Egenskap för att hämta kortets bredd
        /// </summary>
        public int Bredd
        {
        }
        /// <summary>
        /// Egenskap för att hämta kortets höjd
        /// </summary>
        public int Höjd
        {
        }
        /// <summary>
        /// Egenskap för att sätta/hämta om framsidan ska visas eller inte
        /// </summary>
        public bool VisaFramsida
        {
        }
        /// <summary>
        /// Konstruktor som initierar ett kort
        /// </summary>
        /// <param name="x">Kortets x-läge</param>
        /// <param name="y">kortets y-läge</param>
        /// <param name="valör">Kortets valör</param>
        public Kort(int x, int y, int valör)
        {
        }
        /// <summary>
        /// Ritar ett ruterkort. En enda rutersymbol ritas i mitten av kortet.
        /// </summary>
        /// <param name="g"></param>
        public void Rita(Graphics g)
        {
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
            }
        }
    }
}
