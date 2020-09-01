using System;
using System.Windows.Forms;

namespace Övning_3._3
{
    public partial class Form1 : Form
    {
        double inputNumber = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonToRoundNumbers_Click(object sender, EventArgs e)
        {
            string inputValue = TextBoxInput.Text;

            if (HasValidInput(inputValue))
            {
                TextBoxInput.Text = RoundNumber(inputNumber).ToString();
            }
            else
            {
                TextBoxInput.Text = "Error";
            }
        }

        private int RoundNumber(double doubleNumber)
        {
            int frakNumber = (int)doubleNumber;
            int firstDecimal = (int)((doubleNumber - frakNumber) * 10);

            if (firstDecimal >= 5)
            {
                frakNumber++;
            }

            return frakNumber;

        }

        /// <summary>
        /// Check if the input passed is indeed a valid double number.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private Boolean HasValidInput(string message)
        {
            try
            {
                inputNumber = Double.Parse(message);
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }


    }
}
