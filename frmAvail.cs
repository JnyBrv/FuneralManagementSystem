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
    public partial class frmAvail : Form
    {
        private Form currentChildForm;

        public frmAvail()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelClientFormContainer.Controls.Add(childForm);
            panelClientFormContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void panelClientFormContainer_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmClientContractForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDeceasedForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmContractForm1());
        }

    }
}
