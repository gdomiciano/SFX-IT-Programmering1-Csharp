using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRöd_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void btnBlå_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }
    }
}
