using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exempel102_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKlick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mitt första program", "Meddelande", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
