using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekvensiell_Sökning
{
    class Kortlek
    {

        // Slumptalsgenerator används för att blanda kortleken
        Random slump = new Random();
        // Antalet kort i kortbunten
        private static int antalKort = 9;
        // Korten i kortbunten
        private Kort[] korten = new Kort[antalKort];
        // Index för for-loopen vid sekventiell sökning
        private int iFor = 0;
        // Index för det sökta kortet.
        private int index = -1;
        // Avbryt sökningen för att kortet har hittats eller för att
        // hela kortbunten har sökts igenom.
        private bool avbryt = false;
        /// <summary>
        /// Konstruktor som skapar en kortbunt. Kortbunten är sorterad
        /// och det kort med lägst värde ligger längst till vänster.
        /// </summary>
 public Kortlek()
        {
        }
        /// <summary>
        /// Blandar kortleken genom att stega igenom den och byta plats på två kort.
        /// Korten vänds sedan med framsidan nedåt.
        /// </summary>
        public void Blanda()
        {
            // Blanda kortbunten
            // Visa kortbuntens baksida
            // Initiera variablerna som hanterar sekventiell sökning
            iFor = 0;
            index = -1;
            avbryt = false;
        }
        // Ger index för det sökta kortet i kortbunten.
        public int Index
        {
        }
        /// <summary>
        /// Söker efter ett kort med en viss valör i kortbunten. Metoden
        /// som används är sekventiell sökning. När kortet har hittats returneras
        /// true.
        /// </summary>
        public bool SekventielltSökSteg(int söktValör)
        {
        }
        /// <summary>
        /// Ritar korten i kortbunten.
        /// </summary>
        /// <param name="g"></param>
        public void Rita(Graphics g)
        {
        }
    }
}
