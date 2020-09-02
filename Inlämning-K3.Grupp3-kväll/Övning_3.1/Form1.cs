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



        private void btnBeräknaArean_Click(object sender, EventArgs e)
        {
            try
            {
                double tBas = double.Parse(txbBas.Text);
                double tHöjd = double.Parse(txbHöjd.Text);

                if (tBas > 0 && tHöjd > 0)
                {
                    string svar = "Triangeln arean är: ";
                    string tArean = BeräknaArean(tBas, tHöjd).ToString();
                    UppdateraSvar(svar, tArean);
                } else
                {
                    UppdateraFel("Tal måste vara högre än 0");
                }
            }
            catch (FormatException fel)
            {
                UppdateraFel(fel.Message);
            }
        }

        void UppdateraSvar(string svar, string tArean)
        {
            lblFel.Text = "";
            lblSvar.Text = svar + tArean;
        }

        void UppdateraFel(string felTexten)
        {
            lblFel.Text = felTexten;
            lblSvar.Text = "";
        }

        Double BeräknaArean(Double tHöjd, Double tBas)
        {
            return (tHöjd * tBas) / 2;
        }
    }
}
