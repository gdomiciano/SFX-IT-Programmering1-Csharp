using System;
using System.Windows.Forms;

namespace Övning_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //TODO
            //Assume the user has given us digits only.
            //Assume that the number is less than the max number available to ints.

            //this can and will fail if its not an INT

            Double triangleBase = -1;
            Double triangleHeight = -1;

            string result = "";

            try
            {
                triangleBase = Double.Parse(txtBoxBase.Text);
                triangleHeight = Double.Parse(txtBoxHeight.Text);

                result = CalculateTriangleArea(triangleBase, triangleHeight).ToString();
            }
            catch (Exception)
            {


            }



            if (triangleBase > -1 && triangleHeight > -1)
            {
                UpdateResultText(result);
            }
            else
            {
                UpdateResultText("Something went wrong");
                //TODO something went wrong.
            }
        }


        /// <summary>
        /// Updates the result field with the outcome text passed.
        /// </summary>
        /// <param name="message"></param>
        void UpdateResultText(string message)
        {
            ResultLabel.Text = message;

        }

        Double CalculateTriangleArea(Double tHeight, Double tBase)
        {
            return (tHeight * tBase) / 2;
        }
    }
}
