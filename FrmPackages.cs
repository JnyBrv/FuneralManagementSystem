using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuneralManagementSystem
{
    
    public partial class FrmPackages : Form
    {
        private Form parentForm;
        frmMain main;
        Package pack;

    //SQL Connection
    SqlConnection con = new SqlConnection(@"Data Source=JIANNESANTOS\SQLEXPRESS;Initial Catalog=FuneralManagementSystem;Integrated Security=True");

        public FrmPackages()
        {
            InitializeComponent();
            loadPanel();
            //AddPanel();

        }


        private void FrmPackages_Load(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public FrmPackages(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
        }
      
        frmClientContractForm ccf;

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            main = (frmMain)Application.OpenForms["frmMain"];
            frmAddPackage frm = new frmAddPackage();
            main.OpenChildForm(frm);
            

            if (frm != null)
            {
                
                AddPanel();
            }

        }

        public void AddPanel() {

            flowLayoutPanel1.Controls.Add(new Package());

        }

        Image image;
        public void loadPanel()
        {
            try
            {
                con.Open();
                string query = "SELECT packageID, packageName, packageInclusions, packageAmount, packageImg FROM PACKAGE WHERE archive = 0";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);


                int rowIndex = 0;
                foreach (DataRow row in dt.Rows)
                {
                    AddPackageClass.PackageID = row[0].ToString();
                    AddPackageClass.PackageName = row[1].ToString();
                    AddPackageClass.Inclusions = row[2].ToString();
                    AddPackageClass.Price = decimal.Parse(row[3].ToString());
                    byte[] imageBytes = (byte[])row[4];
                    AddPackageClass.PImage = imageBytes;


                    AddPanel();

                    rowIndex++;
                }

                con.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            //Confirmation message dialog
            DialogResult result = MessageBox.Show("Are you sure you want to close the system? ",
                "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                main = (frmMain)Application.OpenForms["frmMain"];
                this.Close();
                frmLogIn log = (frmLogIn)Application.OpenForms["frmLogIn"];
                log.Close();
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuyPackage2_Click(object sender, EventArgs e)
        {

        }

        private void lblDetailsPackage2_Click(object sender, EventArgs e)
        {

        }

        private void pbPackage2_Click(object sender, EventArgs e)
        {

        }

        private void btnOmsAvail_Click(object sender, EventArgs e)
        {
            
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOmsAvail_Click_1(object sender, EventArgs e)
        {
            main = (frmMain)Application.OpenForms["frmMain"];
            main.OpenChildForm(new frmClientContractForm());
            ccf = (frmClientContractForm)Application.OpenForms["frmClientContractForm"];
            ccf.package = Convert.ToInt32(pack.label1.Text);
            main.panelTitleBar.Visible = false;
        }

        private void btnpackageB_Click_1(object sender, EventArgs e)
        {
            main = (frmMain)Application.OpenForms["frmMain"];
            main.OpenChildForm(new frmClientContractForm());
            ccf = (frmClientContractForm)Application.OpenForms["frmClientContractForm"];
            ccf.package = Convert.ToInt32(pack.label1.Text);
            main.panelTitleBar.Visible = false;
        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
