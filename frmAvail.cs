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

        public frmAvail()
        {
            InitializeComponent();

            //form[0] = new frmClientContractForm();
            //form[1] = new frmDeceasedForm();
            //form[2] = new frmInclusions();

           
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

        //private void ShowForm(int index)
        //{
            
        //}

        private void panelClientFormContainer_Paint(object sender, PaintEventArgs e)
        {
            //OpenChildForm(new frmClientContractForm());


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
            OpenChildForm(new frmInclusions());
        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            //int btnClick;

            //for (btnClick = 0; btnClick == 1; btnClick++) { 
            //        if btnCLick == 1            
            //}

            
        }
    }
}
