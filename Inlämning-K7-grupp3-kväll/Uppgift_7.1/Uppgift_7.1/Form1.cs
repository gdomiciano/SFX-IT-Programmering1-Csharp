using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxTal_TextChanged(object sender, EventArgs e)
        {
            lblSvar.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double tal = double.Parse(tbxTal.Text);
            string svar = "Talet är ";
            if(tal > 0)
            {
                svar += "positiv";
            }
            else if (tal < 0) {
                svar += "negativ";
            }
            else
            {
                svar += "0";
            }

            lblSvar.Text = svar;
        }
    }
}
