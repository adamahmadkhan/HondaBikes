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
    public partial class TotalCart : UserControl
    {
        public TotalCart()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1 = CartStoring.cart[0];
            panel2 = CartStoring.cart[2];
            panel3 = CartStoring.cart[3];
        }
    }
}
