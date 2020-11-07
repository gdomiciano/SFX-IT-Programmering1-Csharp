using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sekvensiell_Sökning
{
    public partial class Sekvensiell_Sökning : Form
    {
        Kortlek kortbunt = new Kortlek();
        public Sekvensiell_Sökning()
        {
            InitializeComponent();
            kortbunt.Blanda();
        }

        private void btnSök_Click(object sender, EventArgs e)
        {
            bool hittadeValör = kortbunt.SekventielltSökSteg(int.Parse(tbxSöktValör.Text));
            tbxSöktValör.Enabled = false;

            if (hittadeValör)
            {
                tbxIndex.Text = kortbunt.Index.ToString();
                btnSök.Enabled = false;
            }

            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            kortbunt.Rita(g);
        }

        private void btnBlanda_Click(object sender, EventArgs e)
        {
            kortbunt.Blanda();
            Invalidate();
            tbxSöktValör.Clear();
            tbxIndex.Clear();
            tbxSöktValör.Enabled = true;
            btnSök.Enabled = true;
        }
    }
}
