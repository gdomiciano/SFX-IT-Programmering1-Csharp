using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_9._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBeräkna_Click(object sender, EventArgs e)
        {
            BigInteger resultat = BigInteger.Parse(fåTal(tbxStartAntal.Text).ToString());
            int tid = fåTal(tbxTid.Text); 

            if(tid > 0 && resultat > 0)
            {
                for(int i = 0; i < tid; i++) resultat *= 2; 

                lblResultat.Text = resultat.ToString();
            } else
            {
                lblResultat.Text = "indata var fel. försoka igen";
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
    }
}
