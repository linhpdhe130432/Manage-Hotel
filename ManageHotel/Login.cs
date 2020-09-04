using DAL;
using ManageHotel.admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ManageHotel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = txtUser;
            txtUser.Focus();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string RoleId;
            UserDAO userDAO = new UserDAO();
            Home home = new Home();
            HomeAdmin homeAdmin = new HomeAdmin();
            
            
            if(!string.IsNullOrEmpty(txtUser.Text) && 
               !string.IsNullOrEmpty(txtPass.Text))
            {
                RoleId = userDAO.getUser(txtUser.Text, txtPass.Text);
                
                if(RoleId != "" && RoleId != "1")
                {
                    home.Show();
                    
                    
                }
                else if(RoleId == "1")
                {
                    homeAdmin.Show();
                    
                }
                else
                {
                    MessageBox.Show("Wrong username or password", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                this.Hide();

            }
            else
            {
                MessageBox.Show("Please enter username and password.","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUser.Select();
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
