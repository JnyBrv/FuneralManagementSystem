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
        int PW;
        bool hided;

        public System_Arragement()
        {
            InitializeComponent();
        }

        private void System_Arragement_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            PW = PanelMenu.Width;
            hided = false;

        }

        private void btnSlideHide_Click(object sender, EventArgs e)
        {
            //if (hided) btnSlideHide.Text = ">>";
            //else btnSlideHide.Text = "<<";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hided) {
                PanelMenu.Width = PanelMenu.Width + 20;
                if(PanelMenu.Width >= PW)
                {
                    timer1.Stop();
                    hided = false;
                    this.Refresh();
                }
            }
            else
            {
                PanelMenu.Width = PanelMenu.Width - 20;
                if (PanelMenu.Width <= 0)
                {
                    timer1.Stop();
                    hided = true;
                    this.Refresh();
                }
            }

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
    }
}
