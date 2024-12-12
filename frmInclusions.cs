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
        string total;
        public int id;

        //SQL Connection
        SqlConnection con = new SqlConnection(@"Data Source=JIANNESANTOS\SQLEXPRESS;Initial Catalog=FuneralManagementSystem;Integrated Security=True");

        public frmInclusions()
        {
            InitializeComponent();
            loadComponents();
            initialBalance();
        }

        public void loadComponents()
        {

            try
            {
                id = getCount(-1);
                date.Format = DateTimePickerFormat.Custom;
                date.CustomFormat = "yyyy/MM/dd";

                String query = "SELECT CLIENT.dateOfPurchase, PACKAGE.packageName, PACKAGE.packageInclusions, PACKAGE.packageAmount FROM CLIENT " +
                    "INNER JOIN PACKAGE ON CLIENT.packageID = PACKAGE.packageID WHERE CLIENT.clientID = " + id ;

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
                    con.Close();

                    
                }
                
                
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }


        }

        public int getCount(int count)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT COUNT(*) FROM DECEASED";

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        count = Convert.ToInt32(result) - 1;

                    }
                    con.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("HERE" + ee.Message);
            }
            return count;
        }

        public void initialBalance()
        {
            try
            {
                id = getCount(-1);
                String item = txtAddInclusions.Text;
                float bal = float.Parse(lblTotal.Text);

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE CLIENT SET balance = '" + bal + "' WHERE clientID = " + id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.AutoScroll = true;
        }


        private void frmInclusions_Load(object sender, EventArgs e)
        {
            panel1 = new Panel();
        }

        

        private void btnPayment_Click(object sender, EventArgs e)
        {
            PaymentCash frmPmt = new PaymentCash();
            frmPmt.Show();

            frmInclusions inclusions = new frmInclusions();

            inclusions.Close();

            //frmAvail frmAvl = new frmAvail();
            //frmAvl.Close();
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


        private void txtAddPayment_Leave(object sender, EventArgs e)
        {
            
        }

        String item, inclusionTotal;
        private void btnPayment_Click_1(object sender, EventArgs e)
        {
            try
            {
                id = getCount(-1);
                
                if (string.IsNullOrEmpty(txtAddInclusions.Text))
                {
                    txtAddInclusions.Text = "";
                    item = txtAddInclusions.Text;
                }
                else
                {
                    item = txtAddInclusions.Text;
                }

                float bal = float.Parse(lblTotal.Text);

                if (string.IsNullOrEmpty(txtAddPayment.Text))
                {
                    txtAddPayment.Text = "0";
                    inclusionTotal = txtAddPayment.Text;
                }
                else
                {
                    inclusionTotal = txtAddPayment.Text;
                }
                

                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE CLIENT SET addInclusions = '"+ item +"', inclusionsTotal = '" + inclusionTotal + "' WHERE clientID = " + id +
                    "UPDATE CLIENT SET balance = '" + bal + "' WHERE clientID = " + id;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

            main = (frmMain)Application.OpenForms["frmMain"];
            main.OpenChildForm(new PaymentCash());
            main.panelTitleBar.Visible = false;

            frmInclusions inclusions = new frmInclusions();
            inclusions.Close();

        }

        private void txtAddPayment_TextChanged(object sender, EventArgs e)
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
                lblTotal.Text = total;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = txtPackage.SelectedItem.ToString();
            id = getCount(-1);

            if (selectedItem == "Package A")
            {
                try
                {
                    String query = "SELECT packageAmount, packageInclusions  FROM PACKAGE WHERE packageName = '" + selectedItem + "'; " +
                                    "UPDATE CLIENT SET packageID = 0 WHERE clientID = " + id ;

                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(query, con);

                        SqlDataReader read = cmd.ExecuteReader();
                        read.Read();

                        if (read.HasRows)
                        {
                            richTextBox1.Text = read[1].ToString();
                            lblTotal.Text = read[0].ToString();
                            total = read[0].ToString();
                        }
                        else
                        {
                            con.Close();
                            MessageBox.Show("Data doesn't exist.");
                        }
                        con.Close();
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            else if (selectedItem == "Package B")
            {
                
                String query = "SELECT packageAmount, packageInclusions  FROM PACKAGE WHERE packageName = '" + selectedItem + "'; " +
                            "UPDATE CLIENT SET packageID = 1 WHERE clientID = " + id ;

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);

                    SqlDataReader read = cmd.ExecuteReader();
                    read.Read();

                    if (read.HasRows)
                    {
                        richTextBox1.Text = read[1].ToString();
                        lblTotal.Text = read[0].ToString();
                        total = read[0].ToString();
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show("Data doesn't exist.");
                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid package. ",
                "Package error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
