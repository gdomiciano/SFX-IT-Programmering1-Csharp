using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_10._9
{
    public partial class Uppgift_10_9 : Form
    {

        Random slump = new Random();

        public Uppgift_10_9()
        {
            InitializeComponent();
        }

        private void btnKasta_Click(object sender, EventArgs e)
        {
            tbxResultat.Clear(); 
            int antal = 5;
            int[] tärningar = new int[antal];
            for(int i = 0; i < antal; i++)
            {
                kastaTärningar(tärningar, i);
                visaTärningar(tärningar, i);

            }
            summaTärningar(tärningar);

        }
        private void kastaTärningar(int[] tärningar, int i)
        {
            int antalPrickar = slump.Next(1, 7);
            tärningar[i] = antalPrickar;
        }

        private void visaTärningar(int[] tärningar, int i)
        {
            tbxResultat.AppendText("Täning " + (i + 1) + ": \t" + tärningar[i] + Environment.NewLine);
        }

        private void summaTärningar(int[] tärningar)
        {
            int summa = 0;
            for (int i = 0; i < tärningar.Length; i++)
            {
                summa += tärningar[i];
            }

            tbxResultat.AppendText(Environment.NewLine + "Antal prickar: " + summa);

        }

    }
}
