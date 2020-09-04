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
    public partial class ListBooking : Form
    {
        public ListBooking()
        {
            InitializeComponent();
        }

        private void ListBooking_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            BookingDAO b = new BookingDAO();
            //sd.showData(cbxClass.Text, cbxDepartment.Text, cbxSubject.Text);

            b.showBooking();
            BookingView.DataSource = null;
            DataTable dataTable = b.showBooking();
            BookingView.DataSource = dataTable;

        }
        private int deleteId;
        private void BookingView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteId = Convert.ToInt32(BookingView.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            BookingDAO ud = new BookingDAO();
            ud.removeBooking(deleteId);
            BookingView.DataSource = null;
            DataTable dataTable = ud.showBooking();
            BookingView.DataSource = dataTable;
        }
    }
}
