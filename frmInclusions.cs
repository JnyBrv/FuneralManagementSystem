using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuneralManagementSystem
{
    public partial class frmInclusions : Form
    {
        frmMain main;
        string total;
        String formattedSum = "0.0";
        public int id { get; set; }
        public int package { get; set; }

        public int user;
        String addinclu;


        public int back { get; set; }
        //SQL Connection
        SqlConnection con = new SqlConnection(@"Data Source=JIANNESANTOS\SQLEXPRESS;Initial Catalog=FuneralManagementSystem;Integrated Security=True");

        public frmInclusions()
        {
            InitializeComponent();
            loadComponents();
            //initialBalance();
            populateCmb();
            loadHistory();

            dataGridAddInclu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridAddInclu.DefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Regular);
            dataGridAddInclu.ColumnHeadersDefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Bold);
            addtotal();

            
        }

        public void loadHistory()
        {
            try
            {
                con.Open();

                string query = "SELECT addInclusions FROM CLIENT WHERE clientID = @clientID";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@clientID", user);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string columnValue = reader.GetString(0);
                            string[] values = columnValue.Split(',');

                            foreach (string value in values)
                            {
                                DataGridViewRow row = new DataGridViewRow();
                                row.Cells.Add(new DataGridViewTextBoxCell() { Value = value });
                                dataGridAddInclu.Rows.Add(row);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        public void populateCmb()
        {
            try
            {
                con.Open();
                string query = "SELECT packageName FROM PACKAGE WHERE archive = 0";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtPackage.Items.Add(reader[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void loadComponents()
        {

            try
            {

                String query = "SELECT CLIENT.dateOfPurchase, PACKAGE.packageName, PACKAGE.packageInclusions, PACKAGE.packageAmount FROM CLIENT " +
                    "INNER JOIN PACKAGE ON CLIENT.packageID = PACKAGE.packageID WHERE CLIENT.clientID = " + id;

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);

                    SqlDataReader read = cmd.ExecuteReader();
                    read.Read();

                    if (read.HasRows)
                    {
                        txtPackage.Text = read[1].ToString();
                        richTextBox1.Text = read[2].ToString();
                        lblPackage.Text = read[3].ToString();

                        string textBoxValue = read[3].ToString();
                        decimal decimalValue = decimal.Parse(textBoxValue);
                        string formattedValue = decimalValue.ToString("N2", CultureInfo.InvariantCulture);
                        lblPackage.Text = formattedValue;

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

       

        private void pbExit_Click(object sender, EventArgs e)
        {
            //Confirmation message dialog
            DialogResult result = MessageBox.Show("Are you sure you want to close the system? ",
                "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                main = (frmMain)Application.OpenForms["frmMain"];
                main.Close();
                frmLogIn log = (frmLogIn)Application.OpenForms["frmLogIn"];
                log.Close();
                Close();
            }
        }


        private void txtAddPayment_Leave(object sender, EventArgs e)
        {

        }


        string newp;
        private void txtPackage_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnPayment_Click_1(object sender, EventArgs e)
        {
            
        }



        private void dataGridAddInclu_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void dataGridAddInclu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void addtotal()
        {
            if (formattedSum == null)
            {
                formattedSum = "0.0";
            }
            decimal value1 = decimal.Parse(formattedSum);
            decimal value2 = decimal.Parse(total);



            decimal sum = value1 + value2;

            // Format the sum as currency
            string formatSum = sum.ToString("N2");

            // Display the formatted sum in a label or other control
            lblTotal.Text = formatSum;
        }

        private void dataGridAddInclu_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnPayment_Click_2(object sender, EventArgs e)
        {
            try
            {


                con.Open();

                decimal inclsn = decimal.Parse(lbllnclu.Text);
                decimal ttl = decimal.Parse(lblTotal.Text);
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE CLIENT SET addInclusions = '" + addinclu + "', inclusionsTotal = '" + inclsn + "' WHERE clientID = " + id +
                    "UPDATE CLIENT SET balance = '" + ttl + "' WHERE clientID = " + id;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

            MessageBox.Show("Saved successfully! ",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            main = (frmMain)Application.OpenForms["frmMain"];
            main.OpenChildForm(new FrmClients());
            main.panelTitleBar.Visible = false;

            frmInclusions inclusions = new frmInclusions();
            inclusions.Close();
        }

        private void dataGridAddInclu_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            StringBuilder sbLabel1 = new StringBuilder();
            decimal sumColumn2 = 0;

            foreach (DataGridViewRow row in dataGridAddInclu.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    sbLabel1.Append(row.Cells[0].Value.ToString());
                    sbLabel1.Append(", ");
                }

                if (row.Cells[1].Value != null)
                {
                    if (decimal.TryParse(row.Cells[1].Value.ToString(), out decimal decimalValue))
                    {
                        sumColumn2 += decimalValue;

                        formattedSum = sumColumn2.ToString("N2");

                        addinclu = sbLabel1.ToString();
                        lbllnclu.Text = formattedSum;
                        addtotal();

                    }
                    else
                    {
                        MessageBox.Show("Invalid decimal input in column 2: " + row.Cells[1].Value.ToString());
                        row.Cells[1].Value = "";
                    }
                }
            }
        }

        private void txtPackage_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            string selectedItem = txtPackage.SelectedItem.ToString();

            try
            {
                String query = "SELECT packageAmount, packageInclusions, packageID  FROM PACKAGE WHERE packageName = '" + selectedItem + "'; ";

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);

                    SqlDataReader read = cmd.ExecuteReader();
                    read.Read();

                    if (read.HasRows)
                    {
                        richTextBox1.Text = read[1].ToString();
                        lblPackage.Text = read[0].ToString();
                        total = read[0].ToString();
                        newp = read[2].ToString();

                        con.Close();

                        con.Open();
                        SqlCommand c = con.CreateCommand();
                        c.CommandType = CommandType.Text;
                        c.CommandText = "UPDATE CLIENT SET packageID = " + newp + " WHERE clientID = " + id;
                        c.ExecuteNonQuery();
                        con.Close();

                        addtotal();

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
    }
}


