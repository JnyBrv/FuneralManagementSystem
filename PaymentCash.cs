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
    public partial class PaymentCash : Form
    {
        frmMain main;
        public int id;
        decimal payamount;

        //SQL Connection
        SqlConnection con = new SqlConnection(@"Data Source=JIANNESANTOS\SQLEXPRESS;Initial Catalog=FuneralManagementSystem;Integrated Security=True");

        public PaymentCash()
        {
            InitializeComponent();

            DateTime today = DateTime.Today;
            lblDate.Text = today.ToString("MMMM dd, yyyy");
            loadElements();

        }
        String fname, mname, lname, num;
        public void loadElements()
        {
            try
            {
                id = getCount(-1);

                String query = "SELECT clientFname, clientMname, clientLname, clientContactNo, clientAddress, balance FROM CLIENT WHERE clientID = " + id ; 

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);

                    SqlDataReader read = cmd.ExecuteReader();
                    read.Read();

                    if (read.HasRows)
                    {
                        fname = read[0].ToString();
                        mname = read[1].ToString();
                        lname = read[2].ToString();
                        num = read[3].ToString();
                        lblClient.Text = fname + " " + mname + " " + lname;
                        lblContactNo.Text = num;
                        lblAddress.Text = read[4].ToString();
                        lblClientNo.Text = id.ToString();
                        txtTotalAmount.Text = read[5].ToString();
                        lblTotal.Text= read[5].ToString();
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

        public int getCount(int count)
        {
            try
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
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
            return count;
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPayment_KeyPress(object sender, KeyPressEventArgs e)
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

        public void calculate()
        {
            decimal num1, num2, num3, result;

            if (string.IsNullOrEmpty(txtDiscount.Text))
            {
                num1 = 0;
            }
            else
            {
                num1 = decimal.Parse(txtDiscount.Text);
            }

            if (string.IsNullOrEmpty(txtPayment.Text))
            {
                num2 = 0;
            }
            else
            {
                num2 = decimal.Parse(txtPayment.Text);
            }
            
            num3 = decimal.Parse(txtTotalAmount.Text);


            payamount = (num1 + num2);
            result = num3 - payamount;

            if (result < 0)
            {
                MessageBox.Show("You've entered an exceeding amount.", "Payment error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPayment.Text = "";
                txtDiscount.Text = "";
            }
            else
            {
                result = Math.Round(result, 2);
                lblTotal.Text = result.ToString("0.00");
            }

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDiscount.Text) || !string.IsNullOrEmpty(txtPayment.Text))
            {
                if (!string.IsNullOrEmpty(txtDescription.Text))
                {
                    DialogResult result = MessageBox.Show("Confirm Payment and Print Receipt?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        id = Convert.ToInt32(lblClientNo.Text);
                        int pitems = countPay(-1);
                        String paymentID = id + "-" + pitems;
                        String newbal = lblTotal.Text;

                        DateTime today = DateTime.Today;
                        String date = today.ToString("yyyy-MM-dd");

                        String desc = txtDescription.Text;

                        try
                        {
                            con.Open();

                            SqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "UPDATE CLIENT SET balance = '" + newbal + "' WHERE clientID = " + id +
                                "INSERT INTO PAYMENT (paymentID, payAmount, payDescription, paydate, archive, clientID) VALUES('" + paymentID + "'," + payamount + ", '" + desc + "', '" + date + "',0, " + id + "); ";
                            cmd.ExecuteNonQuery();

                            con.Close();

                            MessageBox.Show("Record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            main = (frmMain)Application.OpenForms["frmMain"];
                            main.OpenChildForm(new FrmPackages());
                            main.panelTitleBar.Visible = false;

                            //receipt


                            main = (frmMain)Application.OpenForms["frmMain"];
                            frmReceipt rec = new frmReceipt();
                            rec.clientName = fname + " " + mname + " " + lname;
                            rec.contact = num;
                            rec.date = date;
                            rec.description = desc;
                            rec.amount = payamount.ToString();
                            rec.rbal = newbal.ToString();
                            rec.client = id;

                            main.OpenChildForm(rec);

                            txtDescription.Text = "";
                            txtPayment.Text = "";
                            txtDiscount.Text = "";

                        }
                        catch (Exception ee)
                        {
                            MessageBox.Show(ee.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled payment.", "Payment failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDescription.Text = "";
                        txtPayment.Text = "";
                        txtDiscount.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Please enter description before we proceed.", "Empty description", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                main = (frmMain)Application.OpenForms["frmMain"];
                main.OpenChildForm(new FrmPackages());
                main.panelTitleBar.Visible = false;
            }
        }

        public int countPay(int count)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(*) FROM PAYMENT";

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    count = Convert.ToInt32(result);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
            return count;
        }
    }
}
