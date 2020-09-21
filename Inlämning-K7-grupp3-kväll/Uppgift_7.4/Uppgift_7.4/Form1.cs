using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_7._4
{
    public partial class If : Form
    {
        public If()
        {
            InitializeComponent();
        }

        private void btnBeräkna_Click(object sender, EventArgs e)
        {
            double tal1 = double.Parse(tbxTal1.Text);
            double tal2 = double.Parse(tbxTal2.Text);
            string räknesätt = tbxRäknesätt.Text;

            string svar = tal1 + " " + räknesätt + " " + tal2 + " = ";

            if (räknesätt.Equals("*"))
            {
                svar += tal1 * tal2;
            }
            else if (räknesätt.Equals("/"))
            {
                svar += tal1 / tal2;
            }
            else if (räknesätt.Equals("+"))
            {
                svar += tal1 + tal2;
            }
            else if (räknesätt.Equals("-"))
            {
                svar += tal1 - tal2;
            }
            else if (räknesätt.Equals("%"))
            {
                svar += tal1 % tal2;
            }

            lblSvar.Text = svar;
        }

        private void klaraSvar (object sender, EventArgs e)
        {
            lblSvar.Text = "";
        }
    }
}
