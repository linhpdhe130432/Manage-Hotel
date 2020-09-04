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
    public partial class BookingFrame : Form
    {
        public BookingFrame()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Booking b = new Booking();
            b.FirstName = txtFirstName.Text;
            b.LastName = txtLastName.Text;
            b.IndentityCard = Convert.ToInt32(txtIdentityCard.Text);
            b.PhoneNumber = Convert.ToInt32(txtPhone.Text);
            b.TypeRoom = txtTypeRoom.Text;
            b.Address = txtAddress.Text;
            b.BillAmount = Double.Parse(txtBill.Text);
            b.DateOfBooking = dateTimePicker1.Value.Date;
            
            BookingDAO bd = new BookingDAO();
            bd.bookingRoom(b);
            MessageBox.Show("Book successful!");

        }

        private void btnShowRecord_Click(object sender, EventArgs e)
        {
            ListBooking listBooking = new ListBooking();
            listBooking.ShowDialog();
            this.Hide();
        }
    }
}
