using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FuneralManagementSystem
{
    public partial class frmAddPackage : Form
    {
        frmMain main;
        FrmPackages package;
        String imgloc;
        public int id;
        //SQL Connection
        SqlConnection con = new SqlConnection(@"Data Source=JIANNESANTOS\SQLEXPRESS;Initial Catalog=FuneralManagementSystem;Integrated Security=True");

        public frmAddPackage()
        {
            InitializeComponent();
        }

        private void btnPackage_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtPackageName.Text == "" || txtPrice.Text == "" || txtInclusions.Text == "" || pbPackage.Image == null)
                {
                    MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    id = getCount(-1);

                    byte[] images = null;
                    FileStream stream = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    images = brs.ReadBytes((int)stream.Length);


                    String name = txtPackageName.Text;
                    String price = txtPrice.Text;
                    String inclu = txtInclusions.Text;


                    //insert into database
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText =
                        "INSERT INTO PACKAGE (packageID, packageName, packageAmount, archive, packageInclusions, packageImg) VALUES (" + id+ ", '" + name + "', '" + price + "', 0, '" + inclu + "' , @images )";
                    cmd.Parameters.Add(new SqlParameter("@images", images));
                    cmd.ExecuteNonQuery();

                    con.Close();


                    MessageBox.Show("New package added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    main = (frmMain)Application.OpenForms["frmMain"];
                    main.OpenChildForm(new FrmPackages());
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }


            AddPackageClass.PackageName = txtPackageName.Text;
            AddPackageClass.Inclusions = txtInclusions.Text;
            AddPackageClass.Price = decimal.Parse(txtPrice.Text + 0.0);


            txtPackageName.Text = " ";
            txtInclusions.Text = " ";
            txtPrice.Text = " ";

            package = new FrmPackages();
            package.AddPanel();
            this.Close();

        }

        public int getCount(int count)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(*) FROM PACKAGE";

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    count = Convert.ToInt32(result) + 1;
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return count;
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg Files(*.jpg)|*jpg| PNG files(*.png|*.png| All files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    pbPackage.ImageLocation = imageLocation;

                    imgloc = imageLocation.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
        private Image resizeIcon(Image image, int width, int height)
        {
            //resize the icon
            Bitmap resizedImage = new Bitmap(image, new Size(width, height));
            return resizedImage;

        }

        private void frmAddPackage_Load(object sender, EventArgs e)
        {
            btnAddPicture.Image = resizeIcon(Properties.Resources.addblack, 24, 24);

            applyRoundEdge();
          
        }


        private void applyRoundEdge()
        {
            // round edge functions
            roundEdge(btnPackage, 20); 
          
        }

        private void roundEdge(Control control, int borderRadius)
        {


            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(control.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(control.Width - borderRadius, control.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, control.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);


        }



        private void pbExit_Click(object sender, EventArgs e)
        {
            //Confirmation message dialog
            DialogResult result = MessageBox.Show("Are you sure you want to close the system? ",
                "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                main = (frmMain)Application.OpenForms["frmMain"];
                this.Close();
                frmLogIn log = (frmLogIn)Application.OpenForms["frmLogIn"];
                log.Close();
                Close();
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, backspace, and decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            // Limit the number of decimal places to 2
            int decimalIndex = (sender as TextBox).Text.IndexOf('.');
            if (decimalIndex > -1 && (sender as TextBox).Text.Length - decimalIndex > 2 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            // Limit the total number of digits to 18
            if ((sender as TextBox).Text.Length >= 18 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
