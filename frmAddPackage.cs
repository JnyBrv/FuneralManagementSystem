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
    }
}
