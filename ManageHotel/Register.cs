using DAL;
using Entity;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            
            
        }

        private void btnImage_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.Username = txtUser.Text;
            u.Password = txtPass.Text;

            //UsersInformation ui = new UsersInformation();
            //ui.Firstname = txtFirstName.Text;
            //ui.Lastname = txtLastName.Text;
            //ui.PhoneNumber = Convert.ToInt32(txtPhone.Text);
            //ui.Email = txtEmail.Text;
            //ui.IndentityCard = txtIdentityCard.Text;
            //ui.Address = txtAddress.Text;
            //ui.Dob = dateTimePicker1.Value.Date;
            //ui.Username = txtUser.Text;
            //ui.Password = txtPass.Text;

            UsersInformationDAO usersInformationDAO = new UsersInformationDAO();
            //usersInformationDAO.registerUser(ui);
            usersInformationDAO.addUsers(u);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
