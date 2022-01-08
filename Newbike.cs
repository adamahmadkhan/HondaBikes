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
        Panel[] OneBikePanel = new Panel[10];
        CheckBox[] CheckBuy = new CheckBox[10];
        Label[] Names = new Label[10];
        Label[] Prices = new Label[10];

        public Newbike()
        {
            InitializeComponent();
            OneBikePanel[0] = panel0;
            OneBikePanel[1] = panel1;
            OneBikePanel[2] = panel2;
            OneBikePanel[3] = panel3;
            OneBikePanel[4] = panel4;
            OneBikePanel[5] = panel5;
            OneBikePanel[6] = panel6;
            OneBikePanel[7] = panel7;
            OneBikePanel[8] = panel8;
            OneBikePanel[9] = panel9;
            CheckBuy[0] = checkBox0;
            CheckBuy[1] = checkBox1;
            CheckBuy[2] = checkBox2;
            CheckBuy[3] = checkBox3;
            CheckBuy[4] = checkBox4;
            CheckBuy[5] = checkBox5;
            CheckBuy[6] = checkBox6;
            CheckBuy[7] = checkBox7;
            CheckBuy[8] = checkBox8;
            CheckBuy[9] = checkBox9;
            Names[0] = bike0;
            Names[1] = bike1;
            Names[2] = bike2;
            Names[3] = bike3;
            Names[4] = bike4;
            Names[5] = bike5;
            Names[6] = bike6;
            Names[7] = bike7;
            Names[8] = bikes8;
            Names[9] = bikes9;
            Prices[0] = price0;
            Prices[1] = price1;
            Prices[2] = price2;
            Prices[3] = price3;
            Prices[4] = price4;
            Prices[5] = price5;
            Prices[6] = price6;
            Prices[7] = price7;
            Prices[8] = price8;
            Prices[9] = price9;
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
            int PriceToCart = 0;
            String NameToCart;
            for (int i = 0; i < 10; i++)
            {
                if (CheckBuy[i].Checked)
                {
                    PriceToCart = Convert.ToInt32(Prices[i].Text);
                    NameToCart = Names[i].Text;
                    CartStoring.x++;
                    CheckBuy[i].Hide();
                    CartStoring.DataNames.Add(NameToCart);
                    CartStoring.DataPrices.Add(PriceToCart);
                    CartStoring.cart.Add(OneBikePanel[i]);
                    CheckBuy[i].Checked = false;

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
                OneBikePanel[i].Hide();
            
            if(Option.Text=="ALL")
            {
                for (int i = 0; i < 10; i++)
                    OneBikePanel[i].Show();
            }
            if (Option.Text == "Sports")
            {
                for (int i = 5; i < 8; i++)
                    OneBikePanel[i].Show();
            }
            if (Option.Text == "Classic")
            {
                for (int i = 1; i < 5; i++)
                    OneBikePanel[i].Show();
            }
            if (Option.Text == "Scooter")
            {
                for (int i = 7; i < 10; i++)
                    OneBikePanel[i].Show();
            }
        }

        private void bikes9_Click(object sender, EventArgs e)
        {

        }

        private void bikes8_Click(object sender, EventArgs e)
        {

        }
    }
}

