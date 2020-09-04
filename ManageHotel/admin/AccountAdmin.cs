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
    public partial class AccountAdmin : Form
    {
        public AccountAdmin()
        {
            InitializeComponent();
        }
        private int deleteId;
        private void AccountAdmin_Load(object sender, EventArgs e)
        {
            UserDAO ud = new UserDAO();
            //sd.showData(cbxClass.Text, cbxDepartment.Text, cbxSubject.Text);

            ud.showAccount();
            dataGridView1.DataSource = null;
            DataTable dataTable = ud.showAccount();
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            UserDAO ud = new UserDAO();
            ud.removeAccount(deleteId);
            dataGridView1.DataSource = null;
            DataTable dataTable = ud.showAccount();
            dataGridView1.DataSource = dataTable;

        }
    }
}
