﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_10._5
{
    public partial class Uppgift_10_5 : Form
    {
        public Uppgift_10_5()
        {
            InitializeComponent();
        }

        private void tbxGemen_TextChanged(object sender, EventArgs e)
        {
            lblVerssal.Text = "";
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            lblVerssal.Text = geVersal(tbxGemen.Text);
        }

        private string geVersal(string bokstav)
        {
            return bokstav.ToUpper();
        }
    }
}
