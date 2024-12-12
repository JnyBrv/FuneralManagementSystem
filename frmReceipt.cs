using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuneralManagementSystem
{
    public partial class frmReceipt : Form
    {
        frmMain main;
        public string clientName { get; set; }
        public string contact { get; set; }
        public string date { get; set; }
        public string description { get; set; }
        public string amount { get; set; }
        public string rbal { get; set; }

        public int client { get; set; }

        public frmReceipt()
        {
            InitializeComponent();
        }


        private void PrintPanel(Panel panelToPrint)
        {
            // Create a Bitmap image of the panel
            Bitmap bmp = new Bitmap(panelToPrint.Width, panelToPrint.Height);
            panelToPrint.DrawToBitmap(bmp, new Rectangle(0, 0, panelToPrint.Width, panelToPrint.Height));

            // Create a PrintDocument instance
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += (sender, e) =>
            {
                // Calculate the scaling factor based on the printable area and image size
                float scaleFactor = Math.Min((float)e.MarginBounds.Width / bmp.Width, (float)e.MarginBounds.Height / bmp.Height);

                // Calculate the scaled width and height
                int scaledWidth = (int)(bmp.Width * scaleFactor);
                int scaledHeight = (int)(bmp.Height * scaleFactor);

                // Create a new Bitmap with the scaled dimensions
                Bitmap scaledBmp = new Bitmap(scaledWidth, scaledHeight);
                using (Graphics g = Graphics.FromImage(scaledBmp))
                {
                    g.DrawImage(bmp, 0, 0, scaledWidth, scaledHeight);
                }

                // Print the scaled image to the page, removing top and left margins
                e.Graphics.DrawImage(scaledBmp, 0, 0, scaledWidth, scaledHeight);
            };

            // Show the Print Preview dialog
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDoc;
            previewDialog.ShowDialog();
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            if ( txtReceivedBy.Text == "")
            {
                MessageBox.Show("Please include the name of the recipient of the payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PrintPanel(pnlReceipt);
            }
            
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

        decimal value, am;
        private void frmReceipt_Load(object sender, EventArgs e)
        {
            lblDate.Text = date;
            lblName.Text = clientName;
            lblNumber.Text = contact;
            lblDescription.Text = description;
            decimal am = decimal.Parse(amount);
            string fValue = am.ToString("N2");
            lblAmount.Text = fValue;

            decimal value = decimal.Parse(rbal);
            string formattedValue = value.ToString("N2"); ;
            lblBalance.Text = formattedValue;
            

        }

        private void txtReceivedBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            main = (frmMain)Application.OpenForms["frmMain"];
            frmUpdateDetails print = new frmUpdateDetails();
            print.client = client;
            main.OpenChildForm(print);
            main.panelTitleBar.Visible = false;
        }
    }
}
