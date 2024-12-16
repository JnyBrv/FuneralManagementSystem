using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuneralManagementSystem
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }


        private Image resizeIcon(Image image, int width, int height)
        {
            //resize the icon
            Bitmap resizedImage = new Bitmap(image, new Size(width, height));
            return resizedImage;

        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            btnSearch.Image = resizeIcon(Properties.Resources.searchBlack, 30, 30);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void lblInterest_Click(object sender, EventArgs e)
        {

        }
    }
}
