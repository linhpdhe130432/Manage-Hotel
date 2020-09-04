using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ManageHotel.admin
{
    public partial class FeedbackAdmin : Form
    {
        public FeedbackAdmin()
        {
            InitializeComponent();
        }

        private void FeedbackAdmin_Load(object sender, EventArgs e)
        {
            FeedbackDAO ud = new FeedbackDAO();
            //sd.showData(cbxClass.Text, cbxDepartment.Text, cbxSubject.Text);

            ud.showFeedback();
            dataGridView1.DataSource = null;
            DataTable dataTable = ud.showFeedback();
            dataGridView1.DataSource = dataTable;
        }
 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
