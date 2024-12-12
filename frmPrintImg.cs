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
    public partial class frmPrintImg : Form
    {
        frmMain main;
        public Image img { get; set; }
        public int client { get; set; }
        public frmPrintImg()
        {
            InitializeComponent();
        }

        private void PrintPictureBox(PictureBox pictureBox)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += (sender, e) =>
            {
                // Create a Bitmap image of the PictureBox
                Bitmap bmp = new Bitmap(pictureBox.Image);

                // Calculate the scaling factor to fit the image within the printable area
                float scaleFactor = Math.Min((float)e.MarginBounds.Width / bmp.Width, (float)e.MarginBounds.Height / bmp.Height);

                // Calculate the scaled width and height
                int scaledWidth = (int)(bmp.Width * scaleFactor);
                int scaledHeight = (int)(bmp.Height * scaleFactor);

                // Calculate the x and y coordinates to center the image on the page, considering printer margins
                int x = (e.MarginBounds.Width - scaledWidth) / 2;
                int y = (e.MarginBounds.Height - scaledHeight) / 2;

                // Adjust for printer margins (you might need to fine-tune these values)
                x += e.MarginBounds.Left;
                y += e.MarginBounds.Top;

                // Print the scaled image to the page, centered
                e.Graphics.DrawImage(bmp, x, y, scaledWidth, scaledHeight);
            };

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDoc;
            previewDialog.ShowDialog();
        }



        //private void btnPrint_Click(object sender, EventArgs e)
        //{
        //    PrintDialog pd = new PrintDialog();
        //    PrintDocument doc = new PrintDocument();
        //    doc.PrintPage += Doc_PrintPage;
        //    pd.Document = doc;
        //    if(pd.ShowDialog() == DialogResult.OK)
        //    {
        //        doc.Print();
        //    }
        //}

        //private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    Bitmap bm = new Bitmap(pboxAttachments.Width, pboxAttachments.Height);
        //    pboxAttachments.DrawToBitmap(bm, new Rectangle(0, 0, pboxAttachments.Width, pboxAttachments.Height));
        //    e.Graphics.DrawImage(bm, 0, 0);
        //    bm.Dispose();
        //}

        private void frmPrintImg_Load(object sender, EventArgs e)
        {
            pboxAttachments.Image = img;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            main = (frmMain)Application.OpenForms["frmMain"];
            frmUpdateDetails print = new frmUpdateDetails();
            print.client = client;
            main.OpenChildForm(print);
            main.panelTitleBar.Visible = false;
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPictureBox(pboxAttachments);
        }
    }
}
