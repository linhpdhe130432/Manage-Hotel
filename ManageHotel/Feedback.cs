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
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void Feedback_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Feedbacks f = new Feedbacks();
            f.Title = txtTitle.Text;
            f.Description = txtDescription.Text;
            f.Name = txtFullName.Text;
            f.Room = txtRoom.Text;

            FeedbackDAO fd = new FeedbackDAO();
            fd.sendFeedback(f);
        }
    }
}
