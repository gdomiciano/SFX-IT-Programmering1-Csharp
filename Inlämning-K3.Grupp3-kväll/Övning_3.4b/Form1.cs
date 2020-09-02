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

        private void Tryckpåknappen(object sender, KeyPressEventArgs e)
        {
            char nyChar = e.KeyChar;

            if (Char.IsDigit(nyChar) || nyChar == ',')
            {  
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Skriv bara seffror.");

            }
        }




        private void Textharändrats(object sender, EventArgs e)
        {
            if (Belopp.Text.Length > 0)
            {
                const int sedelHundra = 100;
                const int sedelFemHundra = 500;

                double belop = Double.Parse(Belopp.Text);

                int attFåFemHundrar = (int)(belop / sedelFemHundra);

                int belopMinusFemHundrarna = (int)belop - attFåFemHundrar * sedelFemHundra;
                int attFåHundrar = (int)(belopMinusFemHundrarna / sedelHundra);




                UpdateraMeddelande(FemHundrarLabel, attFåFemHundrar * sedelFemHundra);
                UpdateraMeddelande(HunrarLabel, attFåHundrar * sedelHundra);
            }

        }



        private void UpdateraMeddelande(Label label, int numer)
        {
            label.Text = numer.ToString();
        }

    }




}
