﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_Login
{
    public partial class TotalCart: UserControl
    {
        public TotalCart()
        {
            InitializeComponent();
        }
        private void UpdateCart_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < CartStoring.x; i++)
            {
                
                this.flowLayoutPanel1.Controls.Add(CartStoring.cart[i]);
            }
        }

        private void ToserverBtn_Click(object sender, EventArgs e)
        {
            CartStoring.SendToDatabase();
        }
    }
}
