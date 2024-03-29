﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Modern_Login
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user = DbMethods.FetchUser.login(UserNameBox.Text.ToString());
            if (UserNameBox.Text == user.Name)
            {
                if (PasswordBox.Text == user.Password)
                {
                    MainDashboard MB = new MainDashboard();
                    MB.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Credentials");
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Process.Start("https://forms.gle/bwSXJzDppJ1btnyY9/");

            CreateNewUser Cnu = new CreateNewUser();
            Cnu.Show();
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserNameBox_Enter(object sender, EventArgs e)
        {
            if (UserNameBox.Text == "UserName")
            {
                UserNameBox.Text = "";
                UserNameBox.ForeColor = Color.Black;
            }
        }

        private void UserNameBox_Leave(object sender, EventArgs e)
        {
            if (UserNameBox.Text == "")
            {
                UserNameBox.Text = "UserName";
                UserNameBox.ForeColor = Color.Silver;
            }
        }
    }
}
