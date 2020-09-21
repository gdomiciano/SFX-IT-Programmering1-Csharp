using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double distans = double.Parse(tbxSlag.Text);
            if (distans < 150 || distans > 190)
            {
                lblSvar.Text = "Grattis!";
            }
            else
            {
                lblSvar.Text = "Du undviktet inte dammen";
            }
        }

        private void tbxSlag_TextChanged(object sender, EventArgs e)
        {
            lblSvar.Text = "";
        }
    }
}
