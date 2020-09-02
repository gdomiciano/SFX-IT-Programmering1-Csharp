using System;
using System.Windows.Forms;

namespace Övning_3._3
{
    public partial class DecimaltalTillHeltal : Form
    {
        double nummer = -1;

        public DecimaltalTillHeltal()
        {
            InitializeComponent();
        }

        private int avrundaNummer(double dubbelNummer)
        {
            int fastNummer = (int)dubbelNummer;
            int förstaDecimal = (int)((dubbelNummer - fastNummer) * 10);

            if (förstaDecimal >= 5)
            {
                fastNummer++;
            }

            return fastNummer;
        }

        private Boolean validera(string texten)
        {
            try
            {
                string nyaTexten = texten.Replace('.', ',');
                nummer = double.Parse(nyaTexten);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btnAvrunda_Click(object sender, EventArgs e)
        {
            string texten = txbDecimaltalet.Text;

            if (validera(texten))
            {
                lblSvar.Text = avrundaNummer(nummer).ToString();
            }
            else
            {
                lblFel.Text = "Fel, mata bara in nummer.";
            }
        }

        private void txbDecimaltalet_TextChanged(object sender, EventArgs e)
        {
            lblFel.Text = "";
            lblSvar.Text = "";
        }
    }
}
