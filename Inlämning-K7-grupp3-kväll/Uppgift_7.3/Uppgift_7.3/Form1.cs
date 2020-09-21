using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_7._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double längd = double.Parse(tbxLängd.Text);
            double windstyrka = double.Parse(txbWindstyrka.Text);
            string svar = "nytt rekord";
            if (längd > 7.92 && windstyrka <= 2.0)
            {
                svar = "Grattis, " + svar;
            }
            else
            {
                svar = "Tyvärr, inget " + svar;
            }

            lblSvar.Text = svar;
        }

        private void klaraSvar(object sender, EventArgs e)
        {
            lblSvar.Text = "";
        }
    }

}
