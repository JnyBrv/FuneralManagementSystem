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

    public partial class frmMain : Form
    {
        private Form currentChildForm;
        private Form currentTitleChildForm;
        public frmMain()
        {
            InitializeComponent();
            OpenChildForm(new FrmPackages());

            
        }

        private void OpenChildForm(Form childForm) {
            if (currentChildForm != null) { 
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainMenu.Controls.Add(childForm);
            panelMainMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        //private void OpenTitleChildForm(Form titleChildForm)
        //{
        //    if (currentTitleChildForm != null)
        //    {
        //        currentTitleChildForm.Close();
        //    }
        //    currentChildForm = titleChildForm;
        //    titleChildForm.TopLevel = false;
        //    titleChildForm.FormBorderStyle = FormBorderStyle.None;
        //    titleChildForm.Dock = DockStyle.Fill;
        //    panelMainMenu.Controls.Add(titleChildForm);
        //    panelMainMenu.Tag = titleChildForm;
        //    titleChildForm.BringToFront();
        //    titleChildForm.Show();

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmPackages());
            panelTitleBar.Visible = false;
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmClients());
            panelTitleBar.Visible = false;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmEmployees());
            panelTitleBar.Visible = false;
        }

        private void panelMainMenu_Paint(object sender, PaintEventArgs e)
        {
            panelTitleBar.Visible = false;
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;

            //this.Size = new System.Drawing.Size(Convert.ToInt32(0.5 * workingRectangle.Width),
            //    Convert.ToInt32(0.4 * workingRectangle.Height));

            //this.Location = new System.Drawing.Point(230, 0);
        }
    }

}
