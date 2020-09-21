using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_7._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            lblSvar.Text = (tbxKön.Text.Equals("k") || tbxKön.Text.Equals("K")) ? "Du är en kvinna." : "Du är en man"; 
        }


        private void klaraSvar(object sender, EventArgs e)
        {
            lblSvar.Text = "";
        }
    }
}
