using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
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
        private void Spel_Load(object sender, EventArgs e)
        {
            tbxGissa.Enabled = false;
            mTbxSvar.Focus();
        }

        private void mTbxSvar_KeyUp(object sender, KeyEventArgs e)
        {
            if(mTbxSvar.Text.Length == 6)
            {
                mTbxSvar.Enabled = false;
                tbxGissa.Enabled = true;
                tbxGissa.Focus();
                lblInfo.Text = "Gissa på en bokstav";
                tbxVisa.Text = "??????";
            }
        }

        private void tbxGissa_TextChanged(object sender, EventArgs e)
        { 
            if (tbxGissa.Text == "" ) return;

            int index = mTbxSvar.Text.IndexOf(tbxGissa.Text); // index blir 3. 
            Console.WriteLine(index);
           if(index > -1)
           {
             string temp = tbxVisa.Text.Remove(index, 1);   // temp blir “?????” (fem frågetecken) 
              tbxVisa.Text = temp.Insert(index, tbxGissa.Text);// visa blir ”???c??”. Ett ? har alltså bytts mot c.
                
           } else
           {
                flyttaGubbe();
           }
            
            if (!tbxVisa.Text.Contains('?'))
            {
                // blir true (om visa är ”???c??”) ! visa.Contains( ’?’ ) // blir false. 
                // show winned
                MessageBox.Show("Du är vinner", "Förslagare");
            }
            tbxGissa.Text = "";
        }

        private void flyttaGubbe()
        {
            int offset = 40;
            pbxGubbe.Top = pbxGubbe.Top + offset;

                //"C:/Users/geisy/Projekter/SFX-IT-Programmering1-Csharp/Hänga_Gubbe/Hänga_Gubbe/bilder/" + --fel +".png"
            pbxGubbe.Image = Image.FromFile("C:/Users/geisy/Projekter/SFX-IT-Programmering1-Csharp/Hänga_Gubbe/Hänga_Gubbe/bilder/" + --fel + ".png");

            if(fel == 0)
            {
                MessageBox.Show("Du är inte vinner", "Förslagare");
            }
        }

        private void pbxMark_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.DarkGreen);

            g.FillRectangle(brush, -1, 290, 350, 50);
        }
    }
}
