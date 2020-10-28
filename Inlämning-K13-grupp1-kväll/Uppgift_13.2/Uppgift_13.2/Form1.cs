using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_13._2
{
    public partial class Uppgift_13_2 : Form
    {
        public Uppgift_13_2()
        {
            InitializeComponent();
        }

        private void btnKontrolera_Click(object sender, EventArgs e)
        {
            lblResultat.Text = "";
            bool fel = false;

            Stack<char> parentesföljden = new Stack<char>();

            string parentes = tbxParentesFöljd.Text;

            for (int i = 0; i < parentes.Length; i++)
            {
                if (parentes[i].Equals('('))
                {
                    parentesföljden.Push(parentes[i]);
                }

                if ((parentes[i].Equals(')')))
                {
                    if (parentesföljden.Count == 0)
                    {
                        fel = true;
                    }
                    else
                    {
                        parentesföljden.Pop();
                    }
                }
            }

            if (parentesföljden.Count > 0 || fel)
            {
                lblResultat.Text = parentes + " är en felaktig parentesföld";
            }
            else
            {
                lblResultat.Text = parentes + " är en riktig parentesföld";
            }

        }
    }
}
