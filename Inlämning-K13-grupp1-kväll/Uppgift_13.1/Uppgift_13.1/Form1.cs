using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_13._1
{
    public partial class Uppgift_13_1 : Form
    {
        List<Glos> glosor = new List<Glos>();
        List<string> fellista = new List<string>();
        int pos = 0;
        int felRäknare = 0;
        int rättRäknare = 0;
        public Uppgift_13_1()
        {
            InitializeComponent();

            gbxGlostest.Enabled = false;
            gbxResultat.Enabled = false;
            btnStartaGlostest.Enabled = false;
            btnNyaGlosor.Enabled = false;
        }

        private void btnLäggTill_Click(object sender, EventArgs e)
        {
            Glos glosOrd = new Glos(tbxLäggTillSvenskt.Text, tbxLäggTillEngelskt.Text);
            glosor.Add(glosOrd);
            tbxLäggTillEngelskt.Clear();
            tbxLäggTillSvenskt.Clear();
            if (glosor.Count > 0) btnStartaGlostest.Enabled = true;
        }

        private void btnStartaGlostest_Click(object sender, EventArgs e)
        {
            gbxLäggtill.Enabled = false;
            btnStartaGlostest.Enabled = false;
            gbxGlostest.Enabled = true;
            gbxResultat.Enabled = false;
            lblResultat.Text = "";
            fellista.Clear();
        }

        private void gbxGlostest_EnabledChanged(object sender, EventArgs e)
        {
            if (gbxGlostest.Enabled)
            {
                tbxGlostestSvenskt.Text = glosor.ElementAt<Glos>(pos).svenska;
                tbxGlostestSvenskt.Enabled = false;
                tbxGlostestEngelskt.Focus();
            }
        }

        private void btnSvara_Click(object sender, EventArgs e)
        {
            if (tbxGlostestEngelskt.Text.Equals(glosor.ElementAt<Glos>(pos).engelska))
            {
                rättRäknare++;
            }
            else
            {
                felRäknare++;
                fellista.Add($"\ndu har skrivit fel ord {tbxGlostestEngelskt.Text} " + 
                    $"\nrätt ord är {glosor.ElementAt<Glos>(pos).engelska} för {glosor.ElementAt<Glos>(pos).svenska}");
            }
            pos++;

            if (glosor.Count == pos)
            {
                gbxResultat.Enabled = true;
                btnStartaGlostest.Enabled = true;
             
                lblResultat.Text = $"Du hade: \n\t{rättRäknare} rätt svaror \n\t{felRäknare} fel svaror!";

                for (int i = 0; i < fellista.Count; i++)
                {
                    lblResultat.Text+=fellista.ElementAt(i);
                }

                tbxGlostestEngelskt.Clear();
                tbxGlostestSvenskt.Clear();
                gbxGlostest.Enabled = false;
                btnNyaGlosor.Enabled = true;
                pos = rättRäknare = felRäknare = 0;
            }
            else
            {
                tbxGlostestSvenskt.Text = glosor.ElementAt<Glos>(pos).svenska;
                tbxGlostestEngelskt.Clear();
            }
        }

        private void btnNyaGlosor_Click(object sender, EventArgs e)
        {
            gbxLäggtill.Enabled = true;
            lblResultat.Text = "";
            btnNyaGlosor.Enabled = false;

            //reset list and variables
            glosor.Clear();
        }
    }
}
