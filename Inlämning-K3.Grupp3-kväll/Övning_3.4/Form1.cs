using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._4
{
    public partial class Uttgsautomat : Form
    {
        public Uttgsautomat()
        {
            InitializeComponent();
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            int sedlarbelopp = 100;
            int belopp = 0;

            try
            {
                belopp = int.Parse(txbBelopp.Text);
                double maxSedlar = belopp / sedlarbelopp;
                if (belopp <= 0)
                {
                    lblFel.Text = "Belopp kan inte bli noll eller minus.";
                }
                else
                {
                    lblSvar.Text = "Uttag: " + sedlarbelopp * maxSedlar + " kr";
                }
            }
            catch (FormatException fel)
            {
                lblFel.Text = fel.Message + "Du kan inte använda punkt eller komma";
            }
        }

        private void txbBelopp_TextChanged(object sender, EventArgs e)
        {
            lblSvar.Text = "";
            lblFel.Text = "";
        }

        private void Uttgsautomat_Load(object sender, EventArgs e)
        {

        }
    }
}
