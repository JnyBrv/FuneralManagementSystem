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
        //private Button selectedButton = null;

        private bool isClientsExpanded = false;
        private bool isArchiveExpanded = false;



        public Form currentChildForm;
        private Form currentTitleChildForm;
        public frmMain()
        {
            InitializeComponent();
            OpenChildForm(new FrmPackages());
            btnPackages.BackColor = Color.Gold;
            btnPackages.ForeColor = Color.Black;

        }

        Bitmap bmpPackage = Properties.Resources.packageIcon;


        public void OpenChildForm(Form childForm) {
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


        private void ResetButtonIcons()
        {
            //defualt yellow color icon
            btnPackages.Image = Properties.Resources.packageIcon; 
            btnClients.Image = Properties.Resources.clientIcon;  
            btnArchive.Image = Properties.Resources.archive_color;  
        }



        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmPackages());
            panelTitleBar.Visible = false;

            //clicked colors
            btnPackages.BackColor = Color.Gold;
            btnPackages.ForeColor = Color.Black;
            btnClients.BackColor = Color.Black;
            btnClients.ForeColor = Color.Gold;
            btnArchive.BackColor = Color.Black;
            btnArchive.ForeColor = Color.Gold;

            //clicked image color
            ResetButtonIcons();
            btnPackages.Image = Properties.Resources.package_black;
           
        }


     

        private void btnClients_Click(object sender, EventArgs e)
        {
            //icon dropdown
           


            //clicked image color
            ResetButtonIcons();
            btnClients.Image = Properties.Resources.client_black;


            //dropdown
            if (!isClientsExpanded)
            {
                //show
                btnOnService.Visible = true;
                btnPaying.Visible = true;
                isClientsExpanded = true;
            }
            else
            {
                //hide the button
                btnOnService.Visible = false;
                btnPaying.Visible = false;
                isClientsExpanded = false;
            }


            OpenChildForm(new FrmClients());
            panelTitleBar.Visible = false;

            //clicked colors
            btnPackages.BackColor = Color.Black;
            btnPackages.ForeColor = Color.Gold;
            btnClients.BackColor = Color.Gold;
            btnClients.ForeColor = Color.Black;
            btnArchive.BackColor = Color.Black;
            btnArchive.ForeColor = Color.Gold;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            //ARCHIVE BUTTON NA TOHHHHHH
            //ARCHIVE BUTTON NA TOHHHHHH
            //ARCHIVE BUTTON NA TOHHHHHH

            //clicled image color
            ResetButtonIcons();
            btnArchive.Image = Properties.Resources.archive_black;

            if (!isArchiveExpanded)
            {
                btnEmployees.Visible = true;
                btnClient.Visible = true;

                isArchiveExpanded = true;
            }
            else
            {
                btnEmployees.Visible = false;
                btnClient.Visible = false;

                isArchiveExpanded = false;
            }






            OpenChildForm(new FrmEmployees());
            panelTitleBar.Visible = false;

            //clicked colors
            btnPackages.BackColor = Color.Black;
            btnPackages.ForeColor = Color.Gold;
            btnClients.BackColor = Color.Black;
            btnClients.ForeColor = Color.Gold;
            btnArchive.BackColor = Color.Gold;
            btnArchive.ForeColor = Color.Black;
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

        private void pbExit_Click(object sender, EventArgs e)
        {
            //Confirmation message dialog
            DialogResult result = MessageBox.Show("Are you sure you want to close the system? ",
                "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout? ",
                "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Hide();
                frmLogIn login = new frmLogIn();
                login.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void btnEmployees_Click_1(object sender, EventArgs e)
        {

        }
    }

}
