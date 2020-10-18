using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_11._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLägg_Click(object sender, EventArgs e)
        {
            string förnamn = tbxFörnamn.Text;
            string efternam = tbxEfternamn.Text;
            string telefon = tbxTelefon.Text;

        Kontakt person = new Kontakt(förnamn, efternam, telefon);

        }
    }
}
