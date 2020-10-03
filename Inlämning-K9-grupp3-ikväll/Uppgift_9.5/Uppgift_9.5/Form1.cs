using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_9._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            Pen penna;

            for (int i = 255; i >= 0; i--)
            {
                penna = new Pen(Color.FromArgb(255, i, i));
                g.DrawRectangle(penna, i, 0, 1, 255);
            }
        }
    }
}
