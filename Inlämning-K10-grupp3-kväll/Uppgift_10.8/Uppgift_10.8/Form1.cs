using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_10._8
{
    public partial class Uppgift_10_8 : Form
    {
        public Uppgift_10_8()
        {
            InitializeComponent();
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            int tidSekunder = int.Parse(tbxTid.Text);
            lblSvar.Text = fåTidForm(tidSekunder); 
        }

        private string fåTidForm(int tidSekunder)
        {
            string svar = "";
            try
            {
                int timmar = tidSekunder / 3600;
                tidSekunder %= 3600;
                int minuter = tidSekunder / 60;
                int sekunder = tidSekunder % 60;


                if (timmar > 0)
                {
                    svar += timmar + " h ";
                }

                if ((minuter > 0 || sekunder > 0) && (minuter > 0 || timmar > 0))
                {
                    svar += minuter + " min ";
                }

                if (sekunder > 0)
                {
                    svar += sekunder + " sek ";
                }
            }
            catch (FormatException fel)
            {
                svar = fel.Message;
            }
            
            return svar;
        }
    }
}
