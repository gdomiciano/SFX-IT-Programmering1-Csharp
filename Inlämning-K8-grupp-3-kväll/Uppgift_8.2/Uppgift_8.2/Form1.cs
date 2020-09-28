using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_8._2
{
    public partial class Uppgift_8_2 : Form
    {

        private int rött = 255;
        private int grönt = 0; 
        private int blått = 0;
        public Uppgift_8_2()
        {
            InitializeComponent();

            txbR.Text = rött.ToString();
            txbG.Text = grönt.ToString();
            txbB.Text = blått.ToString();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics rektangeln = e.Graphics;
            Pen penna = new Pen(Color.FromArgb(rött, blått, grönt));
            SolidBrush pensel = new SolidBrush(Color.FromArgb(rött, blått, grönt));


            rektangeln.DrawRectangle(penna, 20, 100, 300, 100);
            rektangeln.FillRectangle(pensel, 20, 100, 300, 100);
        }
        private bool Validera()
        {
            try
            {
                int rödTal = int.Parse(txbR.Text);
                int grönTal = int.Parse(txbG.Text);
                int blåTal = int.Parse(txbB.Text);
                return ((rödTal >= 0 && rödTal <= 255) && (grönTal >= 0 && grönTal <= 255) && (blåTal >= 0 && blåTal <= 255)) ? true : false;
            }
            catch 
            {
                return false;
            }
                
        }

        private void btnVissaFärg_Click(object sender, EventArgs e)
        {
            bool ärGällande = Validera();
            if (ärGällande)
            {
                lblFel.Visible = false;
                rött = int.Parse(txbR.Text);
                grönt = int.Parse(txbG.Text);
                blått = int.Parse(txbB.Text);
                Invalidate();
            }
            else
            {
                lblFel.Visible = true;
                lblFel.Text = "Du har matat in en fel tal. \nFörsok igen.";
            }
        }
    }
}
