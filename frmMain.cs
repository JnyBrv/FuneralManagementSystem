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
        private bool isClientsIcon = false;
        private bool isArchiveIcon = false;


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



        private void fillSpaceForIcon()
        {
          

            btnPackages.Padding = new Padding(15, 0, 0, 0);
            btnClients.Padding = new Padding(13, 0, 0, 0);
            btnArchive.Padding = new Padding(15, 0, 0, 0);
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnClient.Padding = new Padding(15, 0, 0, 0);
            btnEmployees.Padding = new Padding(15, 0, 0, 0);
            btnPayment.Padding = new Padding(15,0,0,0);
            btnBill.Padding = new Padding(13, 0, 0, 0);
        }

        private Image resizeIcon(Image image, int width, int height)
        {
            //resize the icon
            Bitmap resizedImage = new Bitmap(image, new Size(width, height));
            return resizedImage;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Packages Button


            OpenChildForm(new FrmPackages());
            panelTitleBar.Visible = false;

            //clicked colors
            btnPackages.BackColor = Color.Gold;
            btnPackages.ForeColor = Color.FromArgb(40, 40, 40);
            btnClients.BackColor = Color.FromArgb(40, 40, 40);
            btnClients.ForeColor = Color.Gold;
            btnArchive.BackColor = Color.FromArgb(40, 40, 40);
            btnArchive.ForeColor = Color.Gold;

            //clicked image color
            fillSpaceForIcon();
            btnPackages.Image = resizeIcon(Properties.Resources.package_black, 30, 30);
            btnPackages.ImageAlign = ContentAlignment.MiddleLeft;
            btnPackages.TextAlign = ContentAlignment.MiddleCenter;

            // change the other buttons to yellow
            btnClients.Image = resizeIcon(Properties.Resources.clientIcon, 40, 40);
            btnArchive.Image = resizeIcon(Properties.Resources.NEWarchiveYellow2, 35, 35);



        }

       

    

        private void btnClients_Click(object sender, EventArgs e)
        {
           
            //clientIconDropdown();


            //clicked image color
            fillSpaceForIcon();
            btnClients.Image = resizeIcon(Properties.Resources.client_black, 40, 40);
            btnClients.ImageAlign = ContentAlignment.MiddleLeft;
            btnClients.TextAlign = ContentAlignment.MiddleCenter;

            // change the other buttons to yellow
            btnPackages.Image = resizeIcon(Properties.Resources.packageIcon, 30, 30);
            btnArchive.Image = resizeIcon(Properties.Resources.NEWarchiveYellow2, 35, 35);

            //dropdown
            if (!isClientsExpanded)
            {

                btnOnService.Visible = true;
                btnPaying.Visible = true;
                isClientsExpanded = true;
                btnClients.Text = "         Clients         ▲";
            }
            else
            {
                //hide the button
                btnOnService.Visible = false;
                btnPaying.Visible = false;
                isClientsExpanded = false;
                btnClients.Text = "         Clients         ▼";
            }


            

            //clicked colors
            btnPackages.BackColor = Color.FromArgb(40, 40, 40);
            btnPackages.ForeColor = Color.Gold;
            btnClients.BackColor = Color.Gold;
            btnClients.ForeColor = Color.FromArgb(40, 40, 40);
            btnArchive.BackColor = Color.FromArgb(40, 40, 40);
            btnArchive.ForeColor = Color.Gold;

            btnOnService.BackColor = Color.FromArgb(40, 40, 40);
            btnOnService.ForeColor = Color.Gold;
            btnPaying.BackColor = Color.FromArgb(40, 40, 40);
            btnPaying.ForeColor = Color.Gold;
            btnClient.BackColor = Color.FromArgb(40, 40, 40);
            btnClient.ForeColor = Color.Gold;
            btnEmployees.BackColor = Color.FromArgb(40, 40, 40);
            btnEmployees.ForeColor = Color.Gold;

        }


        private void btnEmployees_Click(object sender, EventArgs e)
        {
            //ARCHIVE BUTTON NA TOHHHHHH
            //ARCHIVE BUTTON NA TOHHHHHH
            //ARCHIVE BUTTON NA TOHHHHHH

            //dropdown icon
        



            //clicled image color
            fillSpaceForIcon();
       
            btnArchive.Image = resizeIcon(Properties.Resources.NEWarchiveBLACK__2_, 35, 35);
            btnArchive.ImageAlign = ContentAlignment.MiddleLeft;
            btnArchive.TextAlign = ContentAlignment.MiddleCenter;

            // change the other buttons to yellow
            btnPackages.Image = resizeIcon(Properties.Resources.packageIcon, 30, 30);
            btnClients.Image = resizeIcon(Properties.Resources.clientIcon, 40, 40);





            if (!isClientsExpanded)
            {
                btnEmployees.Visible = true;
                btnClient.Visible = true;

                isClientsExpanded = true;
                btnArchive.Text = "        Archive       ▲";
            }
            else
            {
                btnEmployees.Visible = false;
                btnClient.Visible = false;

                isClientsExpanded = false;
                btnArchive.Text = "        Archive       ▼";
                
            }


            //clicked colors
            btnPackages.BackColor = Color.FromArgb(40, 40, 40);
            btnPackages.ForeColor = Color.Gold;
            btnClients.BackColor = Color.FromArgb(40, 40, 40);
            btnClients.ForeColor = Color.Gold;
            btnArchive.BackColor = Color.Gold;
            btnArchive.ForeColor = Color.FromArgb(40, 40, 40);

            btnOnService.BackColor = Color.FromArgb(40, 40, 40);
            btnOnService.ForeColor = Color.Gold;
            btnPaying.BackColor = Color.FromArgb(40, 40, 40);
            btnPaying.ForeColor = Color.Gold;
            btnClient.BackColor = Color.FromArgb(40, 40, 40);
            btnClient.ForeColor = Color.Gold;
            btnEmployees.BackColor = Color.FromArgb(40, 40, 40);
            btnEmployees.ForeColor = Color.Gold;

        }



        private void panelMainMenu_Paint(object sender, PaintEventArgs e)
        {
            panelTitleBar.Visible = false;

            btnPackages.Image = resizeIcon(Properties.Resources.package_black, 30, 30);
            btnClients.Image = resizeIcon(Properties.Resources.clientIcon, 40, 40);
            btnArchive.Image = resizeIcon(Properties.Resources.NEWarchiveYellow2, 35, 35);
            btnClient.Image = resizeIcon(Properties.Resources.clientYellow, 35, 35);
            btnEmployees.Image = resizeIcon(Properties.Resources.employeesIcon,35,35);
            btnPayment.Image = resizeIcon(Properties.Resources.paymentYellow,35,35);
            btnBill.Image = resizeIcon(Properties.Resources.receiptYellow, 35, 35);
            btnLogout.Image = resizeIcon(Properties.Resources.backIcon,40, 40);


            btnPackages.ImageAlign = ContentAlignment.MiddleLeft;
            btnClients.ImageAlign = ContentAlignment.MiddleLeft;
            btnArchive.ImageAlign = ContentAlignment.MiddleLeft;

            btnPackages.TextAlign = ContentAlignment.MiddleCenter;
            btnClients.TextAlign = ContentAlignment.MiddleCenter;
            btnArchive.TextAlign = ContentAlignment.MiddleCenter;

            // Apply initial button styles
            btnPackages.BackColor = Color.Gold;
            btnPackages.ForeColor = Color.FromArgb(40, 40, 40);
            btnClients.BackColor = Color.FromArgb(40, 40, 40);
            btnClients.ForeColor = Color.Gold;
            btnArchive.BackColor = Color.FromArgb(40, 40, 40);
            btnArchive.ForeColor = Color.Gold;

            btnOnService.BackColor = Color.FromArgb(40, 40, 40);
            btnOnService.ForeColor = Color.Gold;
            btnPaying.BackColor = Color.FromArgb(40, 40, 40);
            btnPaying.ForeColor = Color.Gold;
            btnClient.BackColor = Color.FromArgb(40, 40, 40);
            btnClient.ForeColor = Color.Gold;
            btnEmployees.BackColor = Color.FromArgb(40, 40, 40);
            btnEmployees.ForeColor = Color.Gold;


            fillSpaceForIcon();





        }

        private void ResetButtonIcons()
        {
      


            btnPackages.Image = resizeIcon(Properties.Resources.packageIcon, 30, 30);
            btnClients.Image = resizeIcon(Properties.Resources.clientIcon, 40, 40);
            btnArchive.Image = resizeIcon(Properties.Resources.NEWarchiveYellow2, 35, 35);

            btnPackages.ImageAlign = ContentAlignment.MiddleLeft;
            btnClients.ImageAlign = ContentAlignment.MiddleLeft;
            btnArchive.ImageAlign = ContentAlignment.MiddleLeft;

            btnPackages.TextAlign = ContentAlignment.MiddleCenter;
            btnClients.TextAlign = ContentAlignment.MiddleCenter;
            btnArchive.TextAlign = ContentAlignment.MiddleCenter;

            fillSpaceForIcon();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
          
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
            OpenChildForm(new FrmEmployees());







        }

        private void btnOnService_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmClients());

            


            // change the color of icon sa dropdown

            btnPackages.BackColor = Color.Gold;
            btnPackages.ForeColor = Color.FromArgb(40, 40, 40);
            btnClients.BackColor = Color.FromArgb(40, 40, 40);
            btnClients.ForeColor = Color.Gold;
            btnArchive.BackColor = Color.FromArgb(40, 40, 40);
            btnArchive.ForeColor = Color.Gold;

            fillSpaceForIcon();

            btnPackages.Image = resizeIcon(Properties.Resources.package_black, 30, 30);
            btnClients.Image = resizeIcon(Properties.Resources.clientIcon, 40, 40);
            btnArchive.Image = resizeIcon(Properties.Resources.NEWarchiveYellow2, 35, 35);

            btnPackages.ImageAlign = ContentAlignment.MiddleLeft;
            btnClients.ImageAlign = ContentAlignment.MiddleLeft;
            btnArchive.ImageAlign = ContentAlignment.MiddleLeft;

            btnPackages.TextAlign = ContentAlignment.MiddleCenter;
            btnClients.TextAlign = ContentAlignment.MiddleCenter;
            btnArchive.TextAlign = ContentAlignment.MiddleCenter;


        }

        private void btnPaying_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPaying());





        

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmArchivedClients());




         

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {

        }

        private void btnBill_Click(object sender, EventArgs e)
        {

        }
    }

}
