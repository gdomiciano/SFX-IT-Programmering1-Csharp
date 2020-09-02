﻿using System;
using System.Windows.Forms;

namespace Övning_3._3
{
    public partial class DecimaltalTillHeltal : Form
    {
        double numer = -1;

        public DecimaltalTillHeltal()
        {
            InitializeComponent();
        }



        private int AvRundaNumer(double dubelNumer)
        {
            int fastNumer = (int)dubelNumer;
            int förstaDecimal = (int)((dubelNumer - fastNumer) * 10);

            if (förstaDecimal >= 5)
            {
                fastNumer++;
            }

            return fastNumer;

        }


        private Boolean ÄrRätt(string texten)
        {
            try
            {
                numer = Double.Parse(texten);
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }

        private void RundKnapp_Click(object sender, EventArgs e)
        {
            string texten = txbDecimaltalet.Text;

            if (ÄrRätt(texten))
            {
                txbDecimaltalet.Text = AvRundaNumer(numer).ToString();
            }
            else
            {
                txbDecimaltalet.Text = "Fel, bara numer.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
