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
    public partial class Maps : Form
    {
        public Maps()
        {
            InitializeComponent();
            //protected void Page_Load(object sender, EventArgs e)
            //{
            //    string origin = "Oberoi Mall, Goregaon";
            //    string destination = "Infinity IT Park, Malad East";
            //    string url = "https://maps.googleapis.com/maps/api/distancematrix/xml?origins=" + origin + "&destinations=" + destination + "&key=AIzaSyBE1J5Pe_GZXBR_x9TXOv6TU5vtCSmEPW4";
            //    WebRequest request = WebRequest.Create(url);
            //    using (WebResponse response = (HttpWebResponse)request.GetResponse())
            //    {
            //        using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            //        {
            //            DataSet dsResult = new DataSet();
            //            dsResult.ReadXml(reader);
            //            duration.Text = dsResult.Tables["duration"].Rows[0]["text"].ToString();
            //            distance.Text = dsResult.Tables["distance"].Rows[0]["text"].ToString();
            //        }
            //    }
            //}

            // full screeen
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            string name = "InterContinental Ha Noi Westlake";
            string street = "Pho Tu Hoa";

            try
            {
                StringBuilder sqlAddress = new StringBuilder();
                sqlAddress.Append("http://maps.google.com/maps?q=");

                if (name != string.Empty)
                {
                    sqlAddress.Append(name + "," + "+");
                }
                if (street != string.Empty)
                {
                    sqlAddress.Append(street + "," + "+");
                }


                webBrowser1.Navigate(sqlAddress.ToString());
                webBrowser1.ScriptErrorsSuppressed = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void btnSearch_map_Click(object sender, EventArgs e)
        {
            
        }

        private void txtZip_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
