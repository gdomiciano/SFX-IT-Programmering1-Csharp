using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sekvensiell_Sökning
{
    class Historik
    {
        private List<string> atiklar { get; set; } = new List<string>();

        /// <summary>
        /// addera artikel till listan
        /// </summary>
        /// <param name="valör"></param>
        /// <param name="index"></param>
        public void adderaArtikel(int valör, int index)
        {
            int sökNummer = atiklar.Count + 1;
            atiklar.Add($"Sök {sökNummer}: söktvälor {valör} var i index {index} {Environment.NewLine}");
        }

        /// <summary>
        /// klara artiklar listan.
        /// </summary>
        /// <param name="type">kan vara fel eller rätt, annars unset</param>
        public void klaraArtikel()
        {
            atiklar.Clear();
        }

        /// <summary>
        /// skapa artikel
        /// återsända sista artikel i listan.
        /// </summary>
        /// <param name="valör"></param>
        /// <param name="index"></param>
        public string visaSistaArtikel(int valör, int index)
        {
            adderaArtikel(valör, index);
            return this.atiklar.Last();
        }
    }
}
