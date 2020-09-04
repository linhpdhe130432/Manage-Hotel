using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ManageHotel.GalleryDetail
{
    public partial class _1stRoom : Form
    {
        public _1stRoom()
        {
            InitializeComponent();
        }
        private int imageNumber = 1;
        private void LoadNextImage()
        {
            if(imageNumber == 4)
            {
                imageNumber = 1;
            }
            SliderPicture1st.ImageLocation = string.Format(@"Images1\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
    }
}
