using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_8._3
{
    public partial class Form1 : Form
    {

        private int nrDatorVinster;
        private int nrSpelarVinster;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpela_Click(object sender, EventArgs e)
        {
            gbxStenSaxPåse.Enabled = true;
            btnSpela.Enabled = false;
            lblDatornsVal.Text = "";
            lblResultat.Text = "";
            nrDatorVinster = 0;
            nrSpelarVinster = 0;
        }

        private void pbxSten_Click(object sender, EventArgs e)
        {
            hittaVinner("sten");
        }

        private void pbxSax_Click(object sender, EventArgs e)
        {
            hittaVinner("sax");

        }

        private void pbxPåse_Click(object sender, EventArgs e)
        {
            hittaVinner("påse");

        }

        private void hittaVinner(string spelaresVal)
        {
            Random slump = new Random();
            int datornsTal = slump.Next(1, 4);
            string datornsVal = "";
            lblResultat.Text = "";


            switch (datornsTal)
            {
                case 1:
                    datornsVal = "sten";
                    break;
                case 2:
                    datornsVal = "sax";
                    break;
                case 3:
                    datornsVal = "påse";
                    break;
            }

            lblDatornsVal.Text = datornsVal;

            if (spelaresVal.Equals("sten") && datornsVal.Equals("sax"))
            {
                nrSpelarVinster++;
            }
            else if (spelaresVal.Equals("påse") && datornsVal.Equals("sten"))
            {
                nrSpelarVinster++;
            }
            else if (spelaresVal.Equals("sax") && datornsVal.Equals("påse"))
            {
                nrSpelarVinster++;
            }
            else if (spelaresVal.Equals(datornsVal))
            {
                lblResultat.Text = "Oavgjord match";
            }
            else
            {
                nrDatorVinster++;
            }

            string vinstText = "Dator: " + nrDatorVinster + ", Spelare: " + nrSpelarVinster;

            if (lblResultat.Text.Equals("")) lblResultat.Text = vinstText;

            if (nrDatorVinster > 2 || nrSpelarVinster > 2)
            {
                gbxStenSaxPåse.Enabled = false;
                btnSpela.Enabled = true;
                tbxMinaResultat.AppendText(vinstText + Environment.NewLine);
            }

        }
    }
}
