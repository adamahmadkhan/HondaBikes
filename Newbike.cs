using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_Login
{
    public partial class Newbike : UserControl
    {
        Panel[] p = new Panel[4];
        CheckBox[] cb = new CheckBox[4];
        public Newbike()
        {
            InitializeComponent();
            p[0] = panel0;
            p[1] = panel1;
            p[2] = panel2;
            p[3] = panel3;
            cb[0] = checkBox0;
            cb[1] = checkBox1;
            cb[2] = checkBox2;
            cb[3] = checkBox3;
        }

        int t = 0;
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void update_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 4; i++)
            {
                if (cb[i].Checked)
                    t = t + 1;
                CartStoring.cart.Add(p[i]);

            }
            label4.Text = t+"";
            t = 0;
        }

        private void checkBox0_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
