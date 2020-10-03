using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_9._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFlyttaBoll_Click(object sender, EventArgs e)
        {
            int bollTopp = pbxBoll.Top;
            int bollHöjd = pbxBoll.Height;
            int fönterHöjd = Form1.ActiveForm.Height;
            int sistaPlats = fönterHöjd - (bollHöjd + bollTopp);

            for(int i = bollTopp; i <= sistaPlats; i++)
            {
                 pbxBoll.Top++;
            }

        }
    }
}
