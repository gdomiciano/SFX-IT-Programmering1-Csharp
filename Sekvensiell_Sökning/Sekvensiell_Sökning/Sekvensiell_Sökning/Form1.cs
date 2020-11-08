﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sekvensiell_Sökning
{
    public partial class Sekvensiell_Sökning : Form
    {
        Kortlek kortbunt = new Kortlek();
        int söktValör = -1;
        public Sekvensiell_Sökning()
        {
            InitializeComponent();
            kortbunt.Blanda();
        }

        /// <summary>
        /// göra sokning.
        /// </summary>
        private void btnSök_Click(object sender, EventArgs e)
        {
            bool hittadeValör = kortbunt.SekventielltSökSteg(söktValör);
            tbxSöktValör.Enabled = false;

            if (hittadeValör)
            {
                tbxIndex.Text = kortbunt.Index.ToString();
                btnSök.Enabled = false;
            }

            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            kortbunt.Rita(g);
        }

        /// <summary>
        /// återställa programmet status.
        /// </summary>
        private void btnBlanda_Click(object sender, EventArgs e)
        {
            kortbunt.Blanda();
            Invalidate();
            tbxSöktValör.Clear();
            tbxIndex.Clear();
            tbxSöktValör.Enabled = true;
            tbxSöktValör.Focus();
        }

        /// <summary>
        /// Validera tbxSöktValör och visa feedback om det behövs.
        /// </summary>
        private void tbxSöktValör_TextChanged(object sender, EventArgs e)
        {
            btnSök.Enabled = false;
            if (!int.TryParse(tbxSöktValör.Text, out söktValör) && tbxSöktValör.Text != "")
            {
                visaFeedback("fel");
                return;
            }
            else if (söktValör > 10)
            {
                visaFeedback("fel");
            }
            else if (söktValör > 0 && söktValör <= 10)
            {
                visaFeedback("rätt");
                btnSök.Enabled = true;
            }
            else
            {
                visaFeedback();
            }
        }

        /// <summary>
        /// Visa feedback meddelande intill tbxSöktValör.
        /// </summary>
        /// <param name="type">kan vara fel eller rätt, annars unset</param>
        private void visaFeedback(string type = "unset")
        {
            switch (type)
            {
                case "fel":
                    lblFeedback.ForeColor = Color.DarkRed;
                    lblFeedback.Text = "Mata in en heltal mellan 2 och 10 för att aktivera Sekventiell sökning knappen";
                    break;
                case "rätt":
                    lblFeedback.ForeColor = Color.LightGreen;
                    lblFeedback.Text = "✔";
                    break;
                default:
                    lblFeedback.Text = "";
                    break;
            }
        }
    }
}
