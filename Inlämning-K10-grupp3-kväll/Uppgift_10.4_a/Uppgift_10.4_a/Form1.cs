using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_10._4_a
{
    public partial class Uppgift_10_4_a : Form
    {
        bool rita = false;
        public Uppgift_10_4_a()
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
            if(rita)
            {
                Graphics g = e.Graphics;
                int antal = int.Parse(tbxAntal.Text);
                ritaCirklar(g, antal);
            }
        }

        private void ritaCirklar(Graphics g, int antal)
        {
            SolidBrush penna = new SolidBrush(Color.Red);
            for(int k = 1; k <= antal; k++)
            {
                g.FillEllipse(penna, k * 20, 70, 20, 20);
            }
        }

        private void tbxAntal_TextChanged(object sender, EventArgs e)
        {
            rita = false;
            Invalidate();
        }
    }
}
