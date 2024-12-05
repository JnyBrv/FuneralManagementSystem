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
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            main = (frmMain)Application.OpenForms["frmMain"];
            main.OpenChildForm(new frmClientContractForm());
            main.panelTitleBar.Visible = false;

        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            //Confirmation message dialog
            DialogResult result = MessageBox.Show("Are you sure you want to close the system? ",
                "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                main = (frmMain)Application.OpenForms["frmMain"];
                main.Close();
                Close();
            }
        }
    }
}
