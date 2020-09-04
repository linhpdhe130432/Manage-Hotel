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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Maps maps = new Maps();
            maps.ShowDialog();
        }

        private void btnGallery_Click(object sender, EventArgs e)
        {
            Gallery gallery = new Gallery();
            gallery.ShowDialog();
        }

        private void btnFeedBack_Click(object sender, EventArgs e)
        {
            Feedback feedback = new Feedback();
            feedback.ShowDialog();
            MessageBox.Show("Feedback has send!");
            
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            BookingFrame booking = new BookingFrame();
            booking.ShowDialog();
        }

        private void btnFacilities_Click(object sender, EventArgs e)
        {
            Facilities facilities = new Facilities();
            facilities.ShowDialog();
            
        }
    }
}
