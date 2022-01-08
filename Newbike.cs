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
        Panel[] p = new Panel[8];
        CheckBox[] cb = new CheckBox[8];
        int t = 0;
        public Newbike()
        {
            InitializeComponent();
            p[0] = panel0;
            p[1] = panel1;
            p[2] = panel2;
            p[3] = panel3;
            p[4] = panel4;
            p[5] = panel5;
            p[6] = panel6;
            p[7] = panel7;
            cb[0] = checkBox0;
            cb[1] = checkBox1;
            cb[2] = checkBox2;
            cb[3] = checkBox3;
            cb[4] = checkBox4;
            cb[5] = checkBox5;
            cb[6] = checkBox6;
            cb[7] = checkBox7;
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void checkBox0_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UpdateCart_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 8; i++)
            {
                if (cb[i].Checked)
                {
                    t = t + 1;
                    CartStoring.x++;
                    CartStoring.cart.Add(p[i]);
                }
            }
            label4.Text = "Total Bikes: " + t;
            t = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

