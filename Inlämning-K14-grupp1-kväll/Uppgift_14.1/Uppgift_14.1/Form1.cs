using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_14._1
{
    public partial class Uppgift_14_1 : Form
    {
        int börja = 8000;
        double rämta = 1.05;
        public Uppgift_14_1()
        {
            InitializeComponent();
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            int år = int.Parse(tbxÅr.Text);
            int resultat = FåKapitalet(år);
            lblResultat.Text = $"Kepitelet är {resultat} kr";
        }

        private int FåKapitalet(int år)
        {
            int k = börja;
            if (år == 0)
            {
                return k;
            }
            else
            {
                k = (int)(rämta * FåKapitalet(år - 1));
            }
            return k;
        }
    }
}
