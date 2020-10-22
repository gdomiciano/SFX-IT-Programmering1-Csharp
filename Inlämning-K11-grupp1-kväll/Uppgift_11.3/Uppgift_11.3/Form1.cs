using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_11._3
{
    public partial class Form1 : Form
    {
        Cirkel cirkel;
        Rektangel rektangel;
        Rektangel ruta;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        
        protected override void OnPaint (PaintEventArgs e)
        {
          
            if (rBtnCirkel.Checked) cirkel?.Rita(e.Graphics); 
            if (rBtnRektangel.Checked) rektangel?.Rita(e.Graphics); 
            if (rBtnRuta.Checked) ruta?.Rita(e.Graphics); 
           
        }
        private void formChecka(object sender, EventArgs e) {

            tbxRadius.Enabled = false;
            tbxRadius.Clear();
            tbxSida.Enabled = false;
            tbxSida.Clear();
            tbxHöjd.Enabled = false;
            tbxHöjd.Clear();
            tbxBredd.Enabled = false;
            tbxBredd.Clear();
            lblSvar.Text = "";

            if (rBtnCirkel.Checked)
            {
                tbxRadius.Enabled = true;
            }
            else if (rBtnRektangel.Checked)
            {
                tbxHöjd.Enabled = true;
                tbxBredd.Enabled = true;
            }
            else if (rBtnRuta.Checked)
            {
                tbxSida.Enabled = true;
            }
        }
        private void btnRita_Click(object sender, EventArgs e)

        {
            try
            {
                if(rBtnCirkel.Checked)
                {
                    cirkel = new Cirkel(int.Parse(tbxRadius.Text));
                    Invalidate();
                    lblSvar.Text = "Arean för cirkeln är: " + cirkel.FåArean();
                } else if (rBtnRektangel.Checked)
                {
                    rektangel = new Rektangel(int.Parse(tbxHöjd.Text), int.Parse(tbxBredd.Text));
                    Invalidate();
                    lblSvar.Text = "Arean för rektangeln är: " + rektangel.FåArean();

                } else if (rBtnRuta.Checked)
                {
                
                    ruta = new Rektangel(int.Parse(tbxSida.Text), int.Parse(tbxSida.Text));
                    Invalidate();
                    lblSvar.Text = "Arean för rutan är: " + ruta.FåArean();

                }

            }
            catch (FormatException)
            {
                lblSvar.Text = "Det var en fel val, försok igen!";
            }
        }
    }
}
