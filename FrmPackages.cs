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
    public partial class FrmPackages : Form
    {
        private Form parentForm;
        
        public FrmPackages()
        {
            InitializeComponent();


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
        frmMain main;
      
        frmClientContractForm ccf;

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            frmAddPackage frm = new frmAddPackage();
            frm.ShowDialog();

            if (frm != null)
            {
                
                AddPanel();
            }

        }

        public void AddPanel() {



            flowLayoutPanel1.Controls.Add(new Package());


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
            ccf.package = 0;
            main.panelTitleBar.Visible = false;
        }

        private void btnpackageB_Click_1(object sender, EventArgs e)
        {
            main = (frmMain)Application.OpenForms["frmMain"];
            main.OpenChildForm(new frmClientContractForm());
            ccf = (frmClientContractForm)Application.OpenForms["frmClientContractForm"];
            ccf.package = 1;
            main.panelTitleBar.Visible = false;
        }
    }
}
