using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning02_02
{
    public partial class Övning : Form
    {
        public Övning()
        {
            InitializeComponent();
        }

        private void Meddelande_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "Är det roligt att programmera?", "Övining", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
