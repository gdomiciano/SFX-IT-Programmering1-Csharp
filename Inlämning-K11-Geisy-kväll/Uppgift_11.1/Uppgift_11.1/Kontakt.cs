using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_11._1
{
    public class Kontakt
    {
        public string förnamn { get; set; }
        public string efternamn { get; set; }
        public string telefonnummer { get; set; }

        public Kontakt(string förnamn, string efternamn, string telefonnummer)
        {
            this.förnamn = förnamn;
            this.efternamn = efternamn;
            this.telefonnummer = telefonnummer;
        }
    }
}
