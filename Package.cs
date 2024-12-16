using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FuneralManagementSystem.AddPackageClass;

namespace FuneralManagementSystem
{
    public partial class Package : UserControl
    {
        private DelegateText DelPackage, DelInclustions, DelID;
        private DelegateNumber DelPrice;
        private DelegateImage DelImg;
        frmMain main;
        frmClientContractForm ccf;

        //SQL Connection
        SqlConnection con = new SqlConnection(@"Data Source=JIANNESANTOS\SQLEXPRESS;Initial Catalog=FuneralManagementSystem;Integrated Security=True");

        

        private void btnOmsAvail_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(this.label1.Text);
            main = (frmMain)Application.OpenForms["frmMain"];
            main.OpenChildForm(new frmClientContractForm());
            ccf = (frmClientContractForm)Application.OpenForms["frmClientContractForm"];
            ccf.package = p;
            main.panelTitleBar.Visible = false;
        }

        
        private void applyRoundEdge()
        {
            // PANG ROUND NG EDGESS!!
            roundEdge(btnOmsAvail, 20); 
            roundEdge(txtInclusions, 15); 
            roundEdge(lblPackageName, 10);

            roundEdgeForm();
        }
            
        private void roundEdgeForm()
        {
            int borderRadius = 30; 
            GraphicsPath path = new GraphicsPath();

            // Add arcs to the corners 
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
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

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void Package_Load(object sender, EventArgs e)
        {
            roundEdgeForm();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtInclusions_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Confirmation message dialog
            DialogResult result = MessageBox.Show("Are you sure you want to delete this package? ",
                "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    String name = this.lblPackageName.Text;

                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText =
                        "UPDATE PACKAGE SET archive = 1 WHERE packageName = '" + name + "'";
                    cmd.ExecuteNonQuery();

                    con.Close();

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
                this.Dispose();
                MessageBox.Show("Deleted successfully.",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           
        

    }

        public Package()
      
        {
            InitializeComponent();
            DelPackage = new DelegateText(AddPackageClass.GetPackage);
            DelInclustions = new DelegateText(AddPackageClass.GetInclusions);
            DelPrice = new DelegateNumber(AddPackageClass.GetPrice);
            DelImg = new DelegateImage(AddPackageClass.GetImage);
            DelID = new DelegateText(AddPackageClass.getPackageID);

            lblPackageName.Text = DelPackage(AddPackageClass.PackageName);
            txtInclusions.Text = DelInclustions(AddPackageClass.Inclusions);
            lblPrice.Text = DelPrice(AddPackageClass.Price).ToString();
            label1.Text = DelID(AddPackageClass.PackageID).ToString();


            byte[] imageData = AddPackageClass.PImage;
            MemoryStream ms = new MemoryStream(imageData);
            Image image = Image.FromStream(ms);
            pbImg.Image = image;

            //loadPanel();

            applyRoundEdge();
        }
    }
}
