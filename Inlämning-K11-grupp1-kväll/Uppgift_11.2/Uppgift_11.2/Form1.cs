using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_11._2
{
    public partial class Kontaker : Form
    {

        Kontakt[] kontakter = new Kontakt[100];
        int räknare = 0;
        public Kontaker()
        {
            InitializeComponent();
        }

        private void btnLäggtill_Click(object sender, EventArgs e)
        {
            Kontakt person = new Kontakt(tbxFörnamn.Text, tbxEfternamn.Text, tbxTelefon.Text);

            adderaKontakt(person);

            tbxFörnamn.Clear();
            tbxEfternamn.Clear();
            tbxTelefon.Clear();

            visaKontakter();

            räknare++;
            
            if(räknare == 2)
            {
                inaktiveraFormulär();
            }
        }

        private void visaKontakter()
        {
            string förnamn = kontakter[räknare].förnamn;
            string efternamn = kontakter[räknare].efternamn;
            string telefonnummer = kontakter[räknare].telefonnummer;

            string text = rBtnEfternamn.Checked
                    ? efternamn + "\t" + förnamn
                    : förnamn + "\t" + efternamn;

            text += "\t" + telefonnummer;

            tbxLista.AppendText(text + Environment.NewLine);

        }

        void adderaKontakt(Kontakt kontakt)
        {
            kontakter[räknare] = kontakt;
        }

        private void inaktiveraFormulär()
        {
            tbxEfternamn.Enabled = false;
            tbxFörnamn.Enabled = false;
            tbxTelefon.Enabled = false;
            btnLäggtill.Enabled = false;
        }
    }
}
