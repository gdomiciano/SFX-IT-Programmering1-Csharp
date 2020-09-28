using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_8._1
{
    public partial class Uppgift_8_1 : Form
    {

        private int x = 400;
        private int y = 400;
        public Uppgift_8_1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics cirkel = e.Graphics;
            Pen penna = new Pen(Color.Black);
            SolidBrush pensel = new SolidBrush(Color.Blue);
            cirkel.DrawEllipse(penna, x, y, 50, 50);
            cirkel.FillEllipse(pensel, x, y, 50, 50);
        }

        private void btnFlyttaTillVänster_Click(object sender, EventArgs e)
        {
            x -= 5;
            Invalidate();
        }

        private void btnFlyttaTillHöger_Click(object sender, EventArgs e)
        {
            x += 5;             
            Invalidate();
        }

        private void btnFlyttaUpp_Click(object sender, EventArgs e)
        {
            y -= 5;
            Invalidate();
        }

        private void btnFlyttaNed_Click(object sender, EventArgs e)
        {
            y += 5;
            Invalidate();
        }
    }
}
