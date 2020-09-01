using System;
using System.Collections.Generic;
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
            char newInputCharacter = e.KeyChar;


            //8 is the keycode for backspace
            if (Char.IsDigit(newInputCharacter) || newInputCharacter == ',')
            {
                //TODO make this read from elsewhere so they are decoupled.





            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid value");

            }
        }


        private Int32 CalculateNumberOfBills(int billSize, double ammount)
        {
            return (int)(ammount / billSize);
        }

        private void UpdateValue(TextBox textBox, int value)
        {
            textBox.Text = value.ToString();
        }

        private void InputWithdraw_TextChanged(object sender, EventArgs e)
        {
            if (InputWithdraw.Text.Length > 0)
            {
                const int billHundra = 100;
                const int billFemHundra = 500;

                double ammount = Double.Parse(InputWithdraw.Text);

                int hundraAmmount = billHundra * CalculateNumberOfBills(billHundra, ammount);
                int femHundraAmmount = billFemHundra * CalculateNumberOfBills(billFemHundra, ammount);

                UpdateValue(HundraBox, hundraAmmount);
                UpdateValue(FemHundraBox, femHundraAmmount);
            }

        }
    }



    //TODO make this a class for future scaling things

    public class BankAutomat
    {
        public enum CurrencyTypes
        {
            Tjugo = 20,
            Hundra = 100,
            TvåHundra = 200,
            FemHundra = 500

        }

        List<CurrencyTypes> availableCurrencies;

        public void WithDrawMoney(CurrencyTypes currency)
        {

        }




    }
}
