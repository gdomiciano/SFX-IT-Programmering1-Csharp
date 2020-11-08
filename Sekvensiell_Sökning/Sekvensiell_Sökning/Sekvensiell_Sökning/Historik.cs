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

        public void adderaArtikel(int valör, int index)
        {
            int sökNummer = atiklar.Count + 1;
            atiklar.Add($"Sök {sökNummer}: söktvälor {valör} var i index {index} {Environment.NewLine}");
        }

        public void klaraArtikel()
        {
            atiklar.Clear();
        }

        public string visaSistaArtikel(int valör, int index)
        {
            adderaArtikel(valör, index);
            return this.atiklar.Last();
        }
    }
}
