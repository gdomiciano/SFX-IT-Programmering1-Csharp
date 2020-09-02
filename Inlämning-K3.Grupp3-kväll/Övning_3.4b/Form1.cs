using System;
using System.Windows.Forms;

namespace Övning_3._4b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UppdateraSvar(Label etiket, int nummer, int sedel)
        {
            etiket.Text = "Uttag i " + sedel + "-sedlar:" + nummer.ToString() + "kr";
        }

        private void txbBelopp_TextChanged(object sender, EventArgs e)
        {
            lblSvarFemHundra.Text = "";
            lblSvarHundra.Text = "";
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbBelopp.Text.Length > 0)
                {
                    const int sedelHundra = 100;
                    const int sedelFemHundra = 500;

                    double belopp = double.Parse(txbBelopp.Text);

                    int attFåFemHundraLappar = (int)(belopp / sedelFemHundra);

                    int beloppMinusFemHundraLapparna = (int)belopp - attFåFemHundraLappar * sedelFemHundra;
                    int attFåHundraLappar = (int)(beloppMinusFemHundraLapparna / sedelHundra);

                    UppdateraSvar(lblSvarFemHundra, attFåFemHundraLappar * sedelFemHundra, sedelFemHundra);
                    UppdateraSvar(lblSvarHundra, attFåHundraLappar * sedelHundra, sedelHundra);
                }
            } catch (FormatException fel)
            {
                MessageBox.Show(fel.Message +" Skriv bara siffror.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }




}
