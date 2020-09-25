using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hänga_Gubbe
{
    public partial class Spel : Form
    {
        public Spel()
        {
            InitializeComponent();
        }
        public int fel = 5;

        public void återställaSpel()
        {
            lblInfo.Text = "";
            tbxVisa.Text = "";
            mTbxSvar.Text = "";
            pbxGubbe.Visible = false;
            tbxGissa.Enabled = false;
            mTbxSvar.Enabled = true;
            tbxGissa.Enabled = false;
            mTbxSvar.Focus();
        }

        private void Spel_Load(object sender, EventArgs e)
        {
            återställaSpel();
        }

        private void pbxMark_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.DarkGreen);

            g.FillRectangle(brush, -1, 290, 350, 50);
        }

        private void mTbxSvar_KeyUp(object sender, KeyEventArgs e)
        {
            if(mTbxSvar.Text.Length == 6)
            {
                pbxGubbe.Visible = true;
                mTbxSvar.Enabled = false;
                tbxGissa.Enabled = true;
                tbxGissa.Focus();
                lblInfo.Text = "Gissa på en bokstav";
                tbxVisa.Text = "??????";
            }
        }

        private void tbxGissa_TextChanged(object sender, EventArgs e)
        {
            string gissining = tbxGissa.Text;

           if (gissining == "" ) return;

            if (mTbxSvar.Text.IndexOf(gissining) < 0) {
                behandlaFelGissining();
            } else {
                behandlaRättGissining(gissining);
            }

           tbxGissa.Text = "";

        }
        private void behandlaRättGissining(string gissining) {
            for (int i = 0; i < mTbxSvar.Text.Length; i++)
            {
                if ((mTbxSvar.Text[i]).ToString() == gissining)
                {
                    string temp = tbxVisa.Text.Remove(i, 1);
                    tbxVisa.Text = temp.Insert(i, gissining);
                    lblInfo.Text = "Bra gissining";
                    lblInfo.ForeColor = Color.DarkGreen;
                }
            }

            if (!tbxVisa.Text.Contains('?'))
            {
                visaResultat("Grattis!!!", "🏆 Du vann!!! \n Vill du spela igen?", true);
            }
        }
        private void behandlaFelGissining()
        {
            lblInfo.Text = "Det finns " + fel + " chanser";
            lblInfo.ForeColor = Color.DarkRed;
            flyttaGubbe();
            if (fel == 0)
            {
                visaResultat("Tyvärr", "😵 Du förlorade... \n Vill du spela igen?", false);
            }
        }
        private void flyttaGubbe()
        {
            int offset = 40;
            pbxGubbe.Top = pbxGubbe.Top + offset;
            pbxGubbe.Image = Image.FromFile(Directory.GetCurrentDirectory()+"\\bilder\\" + --fel + ".ico");
        }

        public void visaResultat(string titel, string meddela, bool ärVinner) {
            MessageBoxIcon beläte = ärVinner ? MessageBoxIcon.Information : MessageBoxIcon.Error;
            DialogResult beslut = MessageBox.Show(meddela, titel, MessageBoxButtons.RetryCancel, beläte);

            if (beslut == DialogResult.Retry)
            {
                återställaSpel();
            }
            else
            {
                this.Close();
            }
            
        }

    }
}
