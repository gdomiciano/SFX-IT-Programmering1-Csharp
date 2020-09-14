using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txbSekunder_TextChanged(object sender, EventArgs e)
        {
            lblFel.Text = "";
            lblSvar.Text = "";
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            try
            {

            string svar = "";
            int tal = int.Parse(txbSekunder.Text);
            int timmar = tal /3600;
            tal %= 3600;
            int minuter = tal / 60;
            int sekunder = tal % 60;


            if (timmar > 0)
            {
                if (timmar == 1)
                {
                    svar += timmar + " timme ";
                }
                else
                {
                    svar += timmar + " timmer ";
                }

            } 
            
            if ((minuter > 0 || sekunder > 0) && (minuter > 0 || timmar > 0))
            {
                if (minuter == 1)
                {
                    svar += minuter + " minut ";
                }
                else
                {
                    svar += minuter + " minuter ";
                }
            }

            if (sekunder > 0)
            {
                if (sekunder == 1)
                {
                    svar += sekunder + " sekund ";
                }
                else
                {
                    svar += sekunder + " sekunder ";
                }
            }

            lblSvar.Text = svar;

            }
            catch (FormatException fel)
            {
                lblFel.Text = fel.Message;
            }
        }
    }
}
