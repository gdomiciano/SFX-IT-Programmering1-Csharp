using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_7._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRätta_Click(object sender, EventArgs e)
        {
            string svar;
            if (tbxFråga1.Text.Equals("x") || tbxFråga1.Text.Equals("X"))
            {
                svar = "1. Rätt ";
            }
            else
            {
                svar = " 1. Fel ";
            }

            if (tbxFråga2.Text.Equals("x") || tbxFråga2.Text.Equals("X"))
            {
                svar += " 2. Rätt ";
            }
            else
            {
                svar += " 2. Fel ";
            }

            if (tbxFråga3.Text.Equals("1"))
            {
                svar += " 3. Rätt ";
            }
            else
            {
                svar += " 3. Fel ";
            }

            lblSvar.Text = svar;
        }

        private void klaraSvar(object sender, EventArgs e)
        {
            lblSvar.Text = "";
        }
    }
}
