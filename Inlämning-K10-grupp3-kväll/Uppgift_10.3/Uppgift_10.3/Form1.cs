using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_10._3
{
    public partial class Uppgift_10_3 : Form
    {
        public Uppgift_10_3()
        {
            InitializeComponent();
        }

        private void txbTecken_TextChanged(object sender, EventArgs e)
        {
            lblSvar.Text = "";
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            char tecken = char.Parse(txbTecken.Text);

            lblSvar.Text = ärSiffra(tecken) ? "Tecknet är en siffra" : "Tacknet är inte en siffra";
        }

        private bool ärSiffra(char tecken)
        {
            if ((int)tecken >=48 && (int)tecken <= 57)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
