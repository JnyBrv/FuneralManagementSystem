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
        //Form[] form = new Form[2];
        //int currentIndex = 0;

        private List<Form> childForms; // List of child forms
        private int currentFormIndex = -1;

        frmClientContractForm frmClient = new frmClientContractForm();
        frmDeceasedForm frmDeceased = new frmDeceasedForm();
        frmInclusions Inclusions = new frmInclusions();

        public frmAvail()
        {
            InitializeComponent();

            //form[0] = new frmClientContractForm();
            //form[1] = new frmDeceasedForm();
            //form[2] = new frmInclusions();

            btnPreviousForm.Enabled = false;
            btnNextForm.Enabled = true;


        }

        private void InitializeChildForms()
        {
            // Initialize the list of child forms
           
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



        private void ShowChildForm(int index)
        {
            // Ensure the index is valid
            if (index < 0 || index >= childForms.Count)
                return;

            // Hide the currently active form (if any)
            if (currentFormIndex >= 0 && currentFormIndex < childForms.Count)
            {
                childForms[currentFormIndex].Hide();
            }

            // Show the new form
            currentFormIndex = index;
            Form currentForm = childForms[currentFormIndex];
            currentForm.MdiParent = this; // Optional: set parent form as MDI container
            currentForm.Show();

            // Enable/disable navigation buttons
            btnPreviousForm.Enabled = currentFormIndex > 0;
            btnNextForm.Enabled = currentFormIndex < childForms.Count - 1;
        }

        private void panelClientFormContainer_Paint(object sender, PaintEventArgs e)
        {
            OpenChildForm(new frmClientContractForm());
        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {


            //if (currentChildForm == frmClient)
            //{
            //    OpenChildForm(new frmDeceasedForm());
            //}

            //else if (currentChildForm == frmDeceased)
            //{
            //    OpenChildForm(new frmInclusions());
            //}
            if(currentFormIndex < childForms.Count - 1)
            {
                ShowChildForm(currentFormIndex + 1);
            }

            //else {
            //    OpenChildForm(new frmClientContractForm());
            //}
        }
        frmAvail avail;
        private void button4_Click(object sender, EventArgs e)
        {
            avail = (frmAvail)Application.OpenForms["frmAvail"];
            avail.Hide();
        }
    }
}
