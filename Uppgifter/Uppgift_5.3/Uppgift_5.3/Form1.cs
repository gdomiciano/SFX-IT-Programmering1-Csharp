using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int täljare = fåTal(txbTäljare.Text);
            int nämnare = fåTal(txbNämnare.Text);

            if(täljare > 0 && nämnare > 0)
            {
                int divisionsSvar = täljare / nämnare;
                int modulusSvar = täljare % nämnare;
                lblSvar.Text = täljare + "/" + nämnare + " blir " + divisionsSvar;

                if (modulusSvar > 0)
                {

                    lblSvar.Text += " " + modulusSvar + "/" + nämnare + " i blandad form.";
                }
                else
                {
                    lblSvar.Text += " i blandad form.";
                }
            } else
            {
                lblFel.Text = "Matta in en giltig tal.";
            }

        }

        private int fåTal(string text)
        {
            try
            {
                return int.Parse(text);
            }
            catch (FormatException)
            {
                double nyttTalDouble;

                if (text.Contains("."))
                {
                    string nyttTalText = text.Replace('.', ',');
                    nyttTalDouble = double.Parse(nyttTalText);
                    return (int)nyttTalDouble;
                }
                else if (text.Contains(","))
                {
                    nyttTalDouble = double.Parse(text);
                    return (int)nyttTalDouble;
                }
                else
                {
                    return -1;
                }
            }
        }

        private void klaraTexter(object sender, EventArgs e)
        {
            lblSvar.Text = "";
            lblFel.Text = "";
        }
    }
}
