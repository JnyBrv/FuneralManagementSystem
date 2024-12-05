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
    public partial class frmInclusions : Form
    {
        frmMain main;
        public frmInclusions()
        {
            InitializeComponent();
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.AutoScroll = true;
        }

        private void frmInclusions_Load(object sender, EventArgs e)
        {
           panel1 = new Panel();
           
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            PaymentCash frmPmt = new PaymentCash();
            frmPmt.Show();

            frmInclusions inclusions = new frmInclusions();

            inclusions.Close();

            frmAvail frmAvl = new frmAvail();
            frmAvl.Close();
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

        private void frmInclusions_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
