using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_10._1
{
    public partial class Uppgift_10_1 : Form
    {
        public Uppgift_10_1()
        {
            InitializeComponent();
        }

        private void btnBeräkna_Click(object sender, EventArgs e)
        {
            double radie = fåTal(tbxRadie.Text);
            if (radie > 0) lblSvar.Text = omkretsCirkel(radie).ToString();
        }

        private double omkretsCirkel(double radie)
        {
            double diameter = radie * 2;
            return Math.PI * diameter;
        }

        private void tbxRadie_TextChanged(object sender, EventArgs e)
        {
            lblSvar.Text = "";
        }

        private double fåTal(string text)
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
                    return nyttTalDouble;
                }
                else if (text.Contains(","))
                {
                    nyttTalDouble = double.Parse(text);
                    return nyttTalDouble;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
