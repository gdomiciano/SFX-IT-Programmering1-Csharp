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
        }

        private void gbxGlostest_EnabledChanged(object sender, EventArgs e)
        {
            if (gbxGlostest.Enabled)
            {
                tbxGlostestSvenskt.Text = glosor.First<Glos>().svenska;
                tbxGlostestSvenskt.Enabled = false;
                tbxGlostestEngelskt.Focus();
            }
        }

        private void btnSvara_Click(object sender, EventArgs e)
        {
            if (tbxGlostestEngelskt.Text.Equals(glosor.First<Glos>().engelska))
            {
                rättRäknare++;
            }
            else
            {
                felRäknare++;
            }
            glosor.RemoveAt(0);

            if (glosor.Count == 0)
            {
                gbxResultat.Enabled = true;
             
                lblResultat.Text = $"Du hade: \n\t{rättRäknare} rätt svaror \n\t{felRäknare} fel svaror!";
                tbxGlostestEngelskt.Clear();
                tbxGlostestSvenskt.Clear();
                gbxGlostest.Enabled = false;
                btnNyaGlosor.Enabled = true;

            }
            else
            {
                tbxGlostestSvenskt.Text = glosor.First<Glos>().svenska;
                tbxGlostestEngelskt.Clear();
            }
        }

        private void btnNyaGlosor_Click(object sender, EventArgs e)
        {
            gbxLäggtill.Enabled = true;
            lblResultat.Text = "";
            btnNyaGlosor.Enabled = false;
        }
    }
}
