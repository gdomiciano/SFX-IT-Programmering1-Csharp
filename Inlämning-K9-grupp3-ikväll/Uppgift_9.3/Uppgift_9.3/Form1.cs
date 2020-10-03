using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_9._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double a4Ark = 0.1;
            double månenDistans = (double) 384000 * 1000000;

            int räknare = 1;
            while (a4Ark <= månenDistans){
                a4Ark *= 2;
                räknare++;
            }

            lblSvar.Text = "Du måste vika ett A4-ark " + räknare + "gånger \nför att tjokleken blir lika med avståndet till månen. \n\n A4-ark tjokleken är: " + (int)(a4Ark / 1000000) + "km";
        }
    }
}
