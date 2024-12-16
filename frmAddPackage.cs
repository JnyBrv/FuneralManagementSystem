using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FuneralManagementSystem
{
    public partial class frmAddPackage : Form
    {
        FrmPackages package;
        public frmAddPackage()
        {
            InitializeComponent();
        }

        private void btnPackage_Click(object sender, EventArgs e)
        {
            AddPackageClass.PackageName = txtPackageName.Text;
            AddPackageClass.Inclusions = txtInclusions.Text;
            AddPackageClass.Price = long.Parse(txtPrice.Text);


            txtPackageName.Text = " ";
            txtInclusions.Text = " ";
            txtPrice.Text = " ";

            package = new FrmPackages();
            package.AddPanel();
            this.Close();
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg Files(*.jpg)|*jpg| PNG files(*.png|*.png| All files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    pbPackage.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
        private Image resizeIcon(Image image, int width, int height)
        {
            //resize the icon
            Bitmap resizedImage = new Bitmap(image, new Size(width, height));
            return resizedImage;

        }

        private void frmAddPackage_Load(object sender, EventArgs e)
        {
            btnAddPicture.Image = resizeIcon(Properties.Resources.addblack, 24, 24);

            applyRoundEdge();
          
        }


        private void applyRoundEdge()
        {
            // round edge functions
            roundEdge(btnPackage, 20);
            roundEdge(plPackage, 20);
        }

        private void roundEdge(Control control, int borderRadius)
        {


            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(control.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(control.Width - borderRadius, control.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, control.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);


        }

        private void txtInclusions_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtPackageName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPackageId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCurrency_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            btnAddPicture.Image = resizeIcon(Properties.Resources.uploadEdit,35,35);
        }
    }
}
