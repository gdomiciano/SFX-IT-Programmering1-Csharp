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

        private void InputWithdraw_KeyPress(object sender, KeyPressEventArgs e)
        {
            char nyChar = e.KeyChar;


            //8 is the keycode for backspace
            if (Char.IsDigit(nyChar) || nyChar == ',')
            {  
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Skriv bara seffror.");

            }
        }




        private void InputWithdraw_TextChanged(object sender, EventArgs e)
        {
            if (InputWithdraw.Text.Length > 0)
            {
                const int sedelHundra = 100;
                const int sedelFemHundra = 500;

                double belop = Double.Parse(InputWithdraw.Text);

                int attFåFemHundrar = (int)(belop / sedelFemHundra);

                int belopMinusFemHundrarna = (int)belop - attFåFemHundrar * sedelFemHundra;
                int attFåHundrar = (int)(belopMinusFemHundrarna / sedelHundra);




                UpdateraMeddelande(FemHundraBox, attFåFemHundrar * sedelFemHundra);
                UpdateraMeddelande(HundraBox, attFåHundrar * sedelHundra);
            }

        }



        private void UpdateraMeddelande(TextBox textBox, int numer)
        {
            textBox.Text = numer.ToString();
        }


    }




}
