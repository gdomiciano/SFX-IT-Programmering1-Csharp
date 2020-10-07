using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_10._7
{
    public partial class Uppgift_10_7 : Form
    {
        public Uppgift_10_7()
        {
            InitializeComponent();
        }

        private void btnBeräkna_Click(object sender, EventArgs e)
        {
            int bas = int.Parse(tbxBas.Text);
            int exponent = int.Parse(tbxExponent.Text);

            int potensResultat = potens(bas, exponent);
            lblSvar.Text = bas + " uppphöjt till " + exponent + " är " + potensResultat; 
        }

        private int potens(int bas, int exponent)
        {
            return int.Parse(Math.Pow(bas, exponent).ToString());
        }
    }
}
