using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekvensiell_Sökning
{
    class Kortlek
    {
        // Slumptalsgenerator används för att blanda kortleken
        private Random slump = new Random();
        // Antalet kort i kortbunten
        private static int antalKort = 9;
        // Korten i kortbunten
        private Kort[] korten = new Kort[antalKort];
        // Index för for-loopen vid sekventiell sökning
        private int iFor = 0;
        // Avbryt sökningen för att kortet har hittats eller för att
        // hela kortbunten har sökts igenom.
        private bool avbryt = false;

        // Ger index för det sökta kortet i kortbunten.
        public int Index { get; private set; } = -1;

        /// <summary>
        /// Konstruktor som skapar en kortbunt. Kortbunten är sorterad
        /// och det kort med lägst värde ligger längst till vänster.
        /// </summary>
        public Kortlek()
        {
            for (int i = 0; i < antalKort; i++)
            {
               korten[i] = skapaKort(i, i+2);
            }
        }

        /// <summary>
        /// Skapa en ny kort objekt.
        /// </summary>
        /// <param name="position">index används för att räkna x position</param>
        /// <param name="valör">kort nummer (2-10)</param>
        private Kort skapaKort(int position, int valör)
        {
            int distans = 60;
            int yPos = 170;
            int xPos = (position + 1) * distans;

            return new Kort(xPos, yPos, valör);
        }

        /// <summary>
        /// Blandar kortleken genom att stega igenom den och byta plats på två kort.
        /// Korten vänds sedan med framsidan nedåt.
        /// </summary>
        public void Blanda()
        {
            // Blanda kortbunten
            for (int i = 0; i < antalKort; i++)
            {
                int r = slump.Next(0, 8);

                // behövde skapa nya korter med gammal världe eftersom rita funkade inte...
                Kort temp = korten[i];
                korten[i] = skapaKort(i, korten[r].valör);
                korten[r] = skapaKort(r, temp.valör);
            };
            
            // Initiera variablerna som hanterar sekventiell sökning
            iFor = 0;
            Index = -1;
            avbryt = false;
        }

        /// <summary>
        /// Söker efter ett kort med en viss valör i kortbunten. Metoden
        /// som används är sekventiell sökning. När kortet har hittats returneras
        /// true.
        /// </summary>
        public bool SekventielltSökSteg(int söktValör)
        {
            //index = iFor;
            for (int i = 0; i <= iFor; i++)
            {
                korten[i].visaFramsida = true;
                if (korten[i].valör == söktValör)
                {
                    avbryt = true;
                    Index = i;
                    break;
                }
            }

            if (iFor < antalKort) iFor++;
            return avbryt;
        }

        /// <summary>
        /// Ritar korten i kortbunten.
        /// </summary>
        /// <param name="g"></param>
        public void Rita(Graphics g )
        {
            for (int i = 0; i < antalKort; i++)
            {
                korten[i].Rita(g);
            }
        }
    }
}
