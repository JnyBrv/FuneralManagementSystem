 using FontAwesome.Sharp;
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
    public partial class System_Arragement : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderbtn;
        private Form currentChildForm;
       
        
        public System_Arragement()
        {
            InitializeComponent();
            leftBorderbtn = new Panel();
            leftBorderbtn.Size = new Size(7, 60);
            PanelMenu.Controls.Add(leftBorderbtn);
        }

        private void System_Arragement_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

        }

        private void btnSlideHide_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

        }

        private void OpenChildForm(Form childForm) {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelMainMenu.Controls.Add(childForm);
            PanelMainMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnSlide_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.Green;
                currentBtn.ForeColor = Color.FromArgb(206, 203, 150);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.ForeColor = Color.FromArgb(206, 203, 150);
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;

                //left border button
                leftBorderbtn.BackColor = color;
                leftBorderbtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderbtn.Visible = true;
                leftBorderbtn.BringToFront();

                //icon CurrentChild Icon
                
            }
        }

        private void DisableButton() {

            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(16,16,16);
                currentBtn.ForeColor = Color.FromArgb(206, 203, 150);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(206, 203, 150);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;

            }
        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Green);
            OpenChildForm(new FrmPackages());
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Green);
            OpenChildForm(new FrmClients());
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Green);
        }

        private void PanelMainMenu_Paint(object sender, PaintEventArgs e)
        {
            //OpenChildForm(new FrmPackages());
        }
    }
}
