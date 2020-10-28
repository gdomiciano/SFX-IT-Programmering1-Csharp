using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_13._1
{
    class Glos
    {

        public string svenska { get; set; }
        public string engelska { get; set; }

        public Glos(string svenska, string engelska)
        {
            this.svenska = svenska;
            this.engelska = engelska;
        }
    }
}
