using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_10._4_b
{
    public partial class Uppgift_10_4_b : Form
    {

        bool rita = false;
        public Uppgift_10_4_b()
        {
            InitializeComponent();
        }

        private void btnRita_Click(object sender, EventArgs e)
        {
            rita = true;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (rita)
            {
                Graphics g = e.Graphics;
                int antal = int.Parse(tbxAntal.Text);
                ritaCirklar(g, antal);
            }
        }

        private void ritaCirklar(Graphics g, int antal)
        {
            SolidBrush penna = new SolidBrush(Color.Red);
            for( int r = 1; r <= antal; r++)
            {

                for (int k = 1; k <= r; k++)
                {
                    g.FillEllipse(penna, (k+1) * 20, 30 + (r+1) * 20, 20, 20);
                }

            }
        }

        private void tbxAntal_TextChanged(object sender, EventArgs e)
        {
            rita = false;
            Invalidate();
        }
    }
}
