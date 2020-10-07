using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_10._2
{
    public partial class Uppgift_10_2 : Form
    {
        public Uppgift_10_2()
        {
            InitializeComponent();
        }


        private void tbxTal_TextChanged(object sender, EventArgs e)
        {
            lblSvar.Text = "";
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            double tal = fåTal(tbxTal.Text);
            lblSvar.Text = (tal > 0 || tal < 0) ? bestämTecken(tal).ToString() : "något gick fel.";
        }

        private char bestämTecken(double tal)
        {
            if (tal > 0)
            {
                return '+';
            }
            else
                return '-';
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
                    return 0;
                }
            }
        }
    }
}
