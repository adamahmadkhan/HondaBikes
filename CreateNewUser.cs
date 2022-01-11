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
           
        }

        private void Reconfirm_TextChanged(object sender, EventArgs e)
        {
            if (PasswordBox.Text == Reconfirm.Text)
                CheckPassword.Text = "Password Match";
            else
                CheckPassword.Text = "Password not match";
        }

        private bool ConfirmPassword()
        {
            if(PasswordBox.Text == Reconfirm.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(ConfirmPassword() == true)
            {
                
                DbMethods.FetchUser.CreateUser(Email.Text, textBox1.Text, PasswordBox.Text);
            }
            //type Datasebase code above this line
            this.Close();
        }

        private void SpecialChars_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_Enter(object sender, EventArgs e)
        {
            if (Email.Text == "Email")
            {
                Email.Text = "";
                Email.ForeColor = Color.Black;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (Email.Text == "")
            {
                Email.Text = "Email";
                Email.ForeColor = Color.Silver;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text =="UserName")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "UserName";
                textBox1.ForeColor = Color.Silver;
            }
        }
    }
}
