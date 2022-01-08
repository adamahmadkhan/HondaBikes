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
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        private void ExitDashboard_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ContactUSBTN_Click(object sender, EventArgs e)
        {
           
        }

        private void ContactUSBTN_Click_1(object sender, EventArgs e)
        {
            aboutUS1.Hide();
            newbike1.Hide();
            totalCart1.Hide();
            CN.Show();
        }

        private void AboutUSBTN_Click(object sender, EventArgs e)
        {
            CN.Hide();
            newbike1.Hide();
            totalCart1.Hide();
            aboutUS1.Show();
        }

        private void NewBikeBTN_Click(object sender, EventArgs e)
        {
            CN.Hide();
            aboutUS1.Hide();
            totalCart1.Hide();
            newbike1.Show();

        }

        private void newbike1_Load(object sender, EventArgs e)
        {

        }

        private void CartBTN_Click(object sender, EventArgs e)
        {
            CN.Hide();
            aboutUS1.Hide();
            newbike1.Hide();
            totalCart1.Show();
        }

        private void totalCart1_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
