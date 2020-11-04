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
        Graphics g;
        public Sekvensiell_Sökning()
        {
            InitializeComponent();
        }

        private void btnSök_Click(object sender, EventArgs e)
        {
            bool hittadeValör = kortbunt.SekventielltSökSteg(int.Parse(tbxSöktValör.Text));
            tbxSöktValör.Enabled = false;
            tbxIndex.Text = kortbunt.Index.ToString();
            if (hittadeValör) btnSök.Enabled = false;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            g = e.Graphics;
            kortbunt.Rita(g);
        }
    }
}
