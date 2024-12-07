using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        //public int package, id;
        int id = 4;
        string total;

        //SQL Connection
        SqlConnection con = new SqlConnection(@"Data Source=JIANNESANTOS\SQLEXPRESS;Initial Catalog=FuneralManagementSystem;Integrated Security=True");

        public frmInclusions()
        {
            InitializeComponent();
            loadElements();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.AutoScroll = true;
        }

        public void loadElements()
        {
            try
            {
                date.Format = DateTimePickerFormat.Custom;
                date.CustomFormat = "yyyy/MM/dd";

                String query = "SELECT CLIENT.dateOfPurchase, PACKAGE.packageName, PACKAGE.packageInclusions, PACKAGE.packageAmount FROM CLIENT " +
                    "INNER JOIN PACKAGE ON CLIENT.packageID = PACKAGE.packageID WHERE CLIENT.clientID = " + id + "; ";

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);

                    SqlDataReader read = cmd.ExecuteReader();
                    read.Read();

                    if (read.HasRows)
                    {
                        DateTime dateTimeValue = (DateTime)read[0];
                        date.Value = dateTimeValue;
                        txtPackage.Text = read[1].ToString();
                        richTextBox1.Text = read[2].ToString();
                        lblTotal.Text = read[3].ToString();
                        total = read[3].ToString();
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show("Data doesn't exist.");
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void frmInclusions_Load(object sender, EventArgs e)
        {
            panel1 = new Panel();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PaymentCash frmPmt = new PaymentCash();
            frmPmt.Show();

            frmInclusions inclusions = new frmInclusions();
            inclusions.Close();
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

        private void txtAddPayment_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAddPayment_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAddPayment_Leave(object sender, EventArgs e)
        {
            lblTotal.Text = total;
            // Get the value from TextBox1, parsing it as a decimal
            if (decimal.TryParse(txtAddPayment.Text, out decimal value1))
            {
                decimal value2 = decimal.Parse(lblTotal.Text);

                // Perform the calculation, rounding to 2 decimal places
                decimal result = Math.Round(value1 + value2, 2);

                // Update the result label
                lblTotal.Text = result.ToString("N2");
            }
            else
            {
                // Handle invalid input, e.g., clear the result label
                lblTotal.Text = string.Empty;
            }
        }
    }
}
