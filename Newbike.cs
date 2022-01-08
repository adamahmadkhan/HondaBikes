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
        Panel[] p = new Panel[10];
        CheckBox[] cb = new CheckBox[10];
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
            p[8] = panel8;
            p[9] = panel9;
            cb[0] = checkBox0;
            cb[1] = checkBox1;
            cb[2] = checkBox2;
            cb[3] = checkBox3;
            cb[4] = checkBox4;
            cb[5] = checkBox5;
            cb[6] = checkBox6;
            cb[7] = checkBox7;
            cb[8] = checkBox8;
            cb[9] = checkBox9;
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
            
            for (int i = 0; i < 10; i++)
            {
                if (cb[i].Checked)
                {
                  
                    CartStoring.x++;
                    cb[i].Hide();
                    CartStoring.cart.Add(p[i]);
                    cb[i].Checked = false;

                }
            }
            label4.Text = "Total Bikes: " + CartStoring.x;
           
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bike5_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel0_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Option_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
                p[i].Hide();
            
            if(Option.Text=="ALL")
            {
                for (int i = 0; i < 10; i++)
                    p[i].Show();
            }
            if (Option.Text == "Sports")
            {
                for (int i = 5; i < 8; i++)
                    p[i].Show();
            }
            if (Option.Text == "Classic")
            {
                for (int i = 1; i < 5; i++)
                    p[i].Show();
            }
            if (Option.Text == "Scooter")
            {
                for (int i = 7; i < 10; i++)
                    p[i].Show();
            }
        }
    }
}

