using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_5._1
{
    public partial class Fönster : Form
    {
        public Fönster()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int tal = fåTal(tbxTal.Text);
            
            int svar = tal;
            if (svar >= 0)
            {
                lblAddera1.Text = svar + " + " + "1 = " + (svar += 1);
                lblMultiplicera2.Text = svar + " * " + "2 = " + (svar *= 2);
                lblSubtrahera6.Text = svar + " - " + " 6 = " + (svar -= 6);
                lblHalvera.Text = svar + " / " + "2 = " + (svar /= 2);
                lblAddera3.Text = svar + " + " + "3 = " + (svar += 3);
                lblSubtraheraTalet.Text = svar + " - " + tal + "= " + (svar -= tal);

                // svar = (((((tal + 1) * 2) - 6) / 2) + 3) - tal;
                lblSvar.Text = "Svar: " + svar;
            }
            else
            {
                lblFel.Text = "Det var fel tallet.";
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
                 else if (tbxTal.Text.Contains(","))
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
    }
}
