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

            if (glosor.Count > 0) btnStartaGlostest.Enabled = true;
        }
    }
}
