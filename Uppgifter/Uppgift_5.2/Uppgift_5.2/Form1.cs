using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAvrunda_Click(object sender, EventArgs e)
        {
            int tusental = fåTal(txbTusental.Text);
            if (tusental > 1500)
            {
                avrunda(txbTusental.Text);
            }
            else if (tusental > 500 && tusental <= 1500)
            {
                lblSvar.Text = "Talet avrundade till: 1000";
            }
            else
            {
                lblFel.Text = "Mata in ett tusental";
            }
        }

        private void avrunda(string tusentalText)
        {
            int tusentallängd = tusentalText.Length;
            int hundrar = int.Parse(string.Join("", tusentalText[tusentallängd - 3], tusentalText[tusentallängd - 2], tusentalText[tusentallängd - 1]));
            int nyTusen;
            if ( hundrar > 500 && hundrar < 1000)
            {
                nyTusen = int.Parse(tusentalText.Remove(tusentallängd - 3, 3)) + 1;
            }
            else
            {
                nyTusen = int.Parse(tusentalText.Remove(tusentallängd - 3, 3));
            }
            lblSvar.Text = "Talet avrundade till: " + nyTusen + "000";
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

        private void txbTusental_TextChanged(object sender, EventArgs e)
        {
            lblSvar.Text = "";
            lblFel.Text = "";
        }
    }
}
