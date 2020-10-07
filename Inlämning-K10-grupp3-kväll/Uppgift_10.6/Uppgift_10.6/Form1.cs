using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_10._6
{
    public partial class Uppgift_10_6 : Form
    {
        public Uppgift_10_6()
        {
            InitializeComponent();
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            int tal = int.Parse(tbxTal.Text);

            lblSvar.Text = ärPrimtal(tal) ? "Talet är ett primtal" : "Talet är inte ett primtal"; 
        }

        private bool ärPrimtal(int tal)
        {
            if ((tal % 2 == 0 || tal % 3 == 0 || tal % 5 == 0) && tal > 3 && tal != 5)
            {
                return false;
            }
            else
            {
            return true;

            }
        }

        private void tbxTal_TextChanged(object sender, EventArgs e)
        {
            lblSvar.Text = "";
        }
    }
}
