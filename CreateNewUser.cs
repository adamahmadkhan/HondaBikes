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
    public partial class CreateNewUser : Form
    {
        public CreateNewUser()
        {
            InitializeComponent();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void CreateNewUser_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (UserNameBox.Text.Contains(" ")) 
            SpecialChars.Text = "It Cant contains empty spaces";
            else
            SpecialChars.Text = "";
        }

        private void Reconfirm_TextChanged(object sender, EventArgs e)
        {
            if (PasswordBox.Text == Reconfirm.Text)
                CheckPassword.Text = "Password Match";
            else
                CheckPassword.Text = "Password not match";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            
            
            
            
            
            //type Datasebase code above this line
            this.Close();
        }

        private void SpecialChars_Click(object sender, EventArgs e)
        {

        }
    }
}
