using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_12._1
{
    public partial class Sortering : Form
    {
        public Sortering()
        {
            InitializeComponent();
        }
        List<int> talLista = new List<int>();

        private void skapaFält ()
        {
            talLista.Clear();
            try
            {
                talLista.Add(int.Parse(tbxTal1.Text));
                talLista.Add(int.Parse(tbxTal2.Text));
                talLista.Add(int.Parse(tbxTal3.Text));
                talLista.Add(int.Parse(tbxTal4.Text));
                talLista.Add(int.Parse(tbxTal5.Text));
            }
            catch (FormatException)
            {
                lblSvar.Text = "det var en fel";
            }
        }

        private void btnStigande_Click(object sender, EventArgs e)
        {

            skapaFält();

            int i, n;
            int lenght = talLista.Count; if (lenght < 2) return;
            int temp;

            for (n = 1; n < lenght; n++)
            {
                temp = talLista[n];
                i = n - 1;

                while (i >= 0 && talLista[i] < temp)
                {
                    talLista[i + 1] = talLista[i];
                    i--;
                }

                talLista[i + 1] = temp;
            }

            skrivaSortering();
        }

        private void btnFallande_Click(object sender, EventArgs e)
        {
            skapaFält();

            int i, n;
            int lenght = talLista.Count; if (lenght < 2) return;
            int temp;

            for (n = 1; n<lenght; n++)
            {
                temp = talLista[n];
                i = n - 1;

                while (i >= 0 && talLista[i] > temp)
                {
                    talLista[i + 1] = talLista[i];
                    i--;
                }

                talLista[i + 1] = temp;
            }

            skrivaSortering();
        }

        private void skrivaSortering()
        {
            lblSvar.Text = "";

            for(int i = 0; i < talLista.Count; i++)
            {
                lblSvar.Text += talLista[i].ToString() + ", ";
            }
        }

        private void btnÅterställa_Click(object sender, EventArgs e)
        {
            tbxTal1.Clear();
            tbxTal2.Clear();
            tbxTal3.Clear();
            tbxTal4.Clear();
            tbxTal5.Clear();
            lblSvar.Text = "";
            talLista.Clear();
        }
    }
}
