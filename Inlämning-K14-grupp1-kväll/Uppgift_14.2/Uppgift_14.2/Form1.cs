using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_14._2
{
    public partial class Uppgift_14_2 : Form
    {
        public Uppgift_14_2()
        {
            InitializeComponent();
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            int nummer = int.Parse(tbxNummer.Text);
            int resultat = fåAntal(nummer);
            lblResultat.Text = $"Antalet ciklar är {resultat}";
        }

        private int fåAntal(int nummer)
        {
            int total;
            if(nummer == 1)
            {
                return 1;
            }else
            {
                total = nummer + fåAntal(nummer - 1);
            }
            return total;
        }
    }
}
