using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift_9._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random slumpa = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            int sexorRäknare = 0;
            for (int i = 0; i<=1000; i++)
            {
                int tärningsTal = slumpa.Next(1, 7);
                if (tärningsTal == 6)
                {
                    tbxSexor.AppendText(tärningsTal+ "\t");
                    sexorRäknare++;
                }
            }
            tbxSexor.AppendText("\n\n\n Totalt: " + sexorRäknare);

        }
    }
}
