using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_11._2
{
    public class Kontakt
    {
        private string förnamn { get; set; }
        private string efternamn { get; set; }
        private string telefonnummer { get; set; }

        public Kontakt(string förnamn, string efternamn, string telefonnummer)
        {
            this.förnamn = förnamn;
            this.efternamn = efternamn;
            this.telefonnummer = telefonnummer;
        }
    }
}
