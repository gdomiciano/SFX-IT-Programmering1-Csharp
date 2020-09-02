using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._2
{
    public partial class Teckenkoden : Form
    {
        public Teckenkoden()
        {
            InitializeComponent();
        }

        private void btnHittaTecken_Click(object sender, EventArgs e)
        {
            string teckenkod = tbxTeckenkod.Text;
            try
            {
                lblSvar.Text = "Teckenkoden " + teckenkod + " representera tecken " + (char) int.Parse(teckenkod) + '.';
            }
            catch (FormatException fel)
            {
                lblFel.Text = fel.Message;
            }
        }

        private void tbxTeckenkod_TextChanged(object sender, EventArgs e)
        {
            lblSvar.Text = "";
            lblFel.Text = "";
        }
    }
}
