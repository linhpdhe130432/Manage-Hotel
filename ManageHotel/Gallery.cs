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
    public partial class Gallery : Form
    {
        public Gallery()
        {
            InitializeComponent();
        }

        private void btn1st_Click(object sender, EventArgs e)
        {
            GalleryDetail._1stRoom _1StRoom = new GalleryDetail._1stRoom();
            _1StRoom.ShowDialog();
        }

        private void btn2nd_Click(object sender, EventArgs e)
        {
            GalleryDetail._2ndRoom _2ndRoom = new GalleryDetail._2ndRoom();
            _2ndRoom.ShowDialog();
        }
    }
}
