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
    public partial class frmDeceasedForm : Form
    {
        frmMain main;
        public frmDeceasedForm()
        {
            InitializeComponent();
        }

        private void frmDeceasedForm_Load(object sender, EventArgs e)
        {

        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {

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

        private void btnNext_Click(object sender, EventArgs e)
        {

            main = (frmMain)Application.OpenForms["frmMain"];
            main.OpenChildForm(new frmInclusions());
            main.panelTitleBar.Visible = false;
        }
    }
}
