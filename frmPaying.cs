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
    public partial class frmPaying : Form
    {
        frmMain main;
        String selectedUser;
        public int user;
        frmUpdateDetails upd;

        //SQL Connection
        SqlConnection con = new SqlConnection(@"Data Source=JIANNESANTOS\SQLEXPRESS;Initial Catalog=FuneralManagementSystem;Integrated Security=True");

        public frmPaying()
        {
            InitializeComponent();
            if (dataGridPaying.Rows.Count == 0)
            {
                pnlPreview.Visible = false;
            }

            loadTable();

            dataGridPaying.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPaying.DefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Regular);
            dataGridPaying.ColumnHeadersDefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Bold);
            dataGridPaying.Columns[0].Visible = false;
            cellDisplay();
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

        public void loadTable()
        {
            txtSearch.Text = "";
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT CLIENT.clientID AS 'Client ID', CONCAT(CLIENT.clientFname, ' ', CLIENT.clientMname, ' ', CLIENT.clientLname) AS 'Client Name', " +
                            "CONCAT(DECEASED.deceasedFname, ' ', DECEASED.deceasedMname, ' ', DECEASED.deceasedLname) AS 'Decedent Name', " +
                            "PACKAGE.packageName AS 'Package Type', CLIENT.dateOfPurchase AS 'Date of Purchase' FROM DECEASED INNER JOIN CLIENT ON CLIENT.deceasedID = DECEASED.deceasedID " +
                            "INNER JOIN PACKAGE ON CLIENT.packageID = PACKAGE.packageID WHERE CLIENT.archive = 2";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridPaying.DataSource = dt;
                con.Close();

                if (dataGridPaying.Rows.Count == 0)
                {
                    pnlPreview.Visible = false;
                }
                else
                {
                    pnlPreview.Visible = true;
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        public void cellDisplay()
        {
            if (dataGridPaying.Rows.Count == 0)
            {
                MessageBox.Show("There's no paying client listed.",
                        "Paying client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataGridViewRow row = dataGridPaying.Rows[0];

                selectedUser = row.Cells[0].Value.ToString();

                user = Convert.ToInt32(selectedUser);
                try
                {
                    String query = " SELECT CONCAT(CLIENT.clientFname, ' ', CLIENT.clientMname, ' ', CLIENT.clientLname) AS ClientName, " +
                                " PACKAGE.packageName FROM DECEASED " +
                                "INNER JOIN CLIENT ON CLIENT.deceasedID = DECEASED.deceasedID INNER JOIN PACKAGE ON CLIENT.packageID = " +
                                "PACKAGE.packageID  WHERE CLIENT.clientID = " + user;
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(query, con);

                        SqlDataReader read = cmd.ExecuteReader();
                        read.Read();

                        if (read.HasRows)
                        {
                            lblClient.Text = read[0].ToString();
                            lblPackage.Text = read[1].ToString();
                           
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

        }

        private void dataGridPaying_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dataGridPaying.Rows[e.RowIndex];

                selectedUser = row.Cells[0].Value.ToString();

                user = Convert.ToInt32(selectedUser);
                try
                {
                    String query = " SELECT CONCAT(CLIENT.clientFname, ' ', CLIENT.clientMname, ' ', CLIENT.clientLname) AS ClientName, " +
                                " PACKAGE.packageName FROM DECEASED " +
                                "INNER JOIN CLIENT ON CLIENT.deceasedID = DECEASED.deceasedID INNER JOIN PACKAGE ON CLIENT.packageID = " +
                                "PACKAGE.packageID  WHERE CLIENT.clientID = " + user;
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(query, con);

                        SqlDataReader read = cmd.ExecuteReader();
                        read.Read();

                        if (read.HasRows)
                        {
                            lblClient.Text = read[0].ToString();
                            lblPackage.Text = read[1].ToString();
                           
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
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                loadTable();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT CLIENT.clientID AS 'Client ID', CONCAT(CLIENT.clientFname, ' ', CLIENT.clientMname, ' ', CLIENT.clientLname) AS 'Client Name', " +
                                "CONCAT(DECEASED.deceasedFname, ' ', DECEASED.deceasedMname, ' ', DECEASED.deceasedLname) AS 'Decedent Name', " +
                                "PACKAGE.packageName AS 'Package Type', CLIENT.dateOfPurchase AS 'Date of Purchase' FROM DECEASED INNER JOIN CLIENT ON CLIENT.deceasedID = DECEASED.deceasedID " +
                                "INNER JOIN PACKAGE ON CLIENT.packageID = PACKAGE.packageID " +
                                "WHERE (CLIENT.archive = 2) AND (CLIENT.clientFname LIKE '%" + keyword + "%' OR CLIENT.clientMname LIKE '%" + keyword + "%' " +
                                "OR CLIENT.clientLname LIKE '%" + keyword + "%' OR DECEASED.deceasedFname LIKE '%" + keyword + "%' " +
                                "OR DECEASED.deceasedMname LIKE '%" + keyword + "%' OR DECEASED.deceasedLname LIKE '%" + keyword + "%' " +
                                "OR CLIENT.clientContactNo LIKE '%" + keyword + "%' OR DECEASED.dateOfInternment LIKE '%" + keyword + "%' " +
                                "OR DECEASED.placeOfInternment LIKE '%" + keyword + "%' OR PACKAGE.packageName LIKE '%" + keyword + "%') ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    con.Close();
                    if (da.Fill(dt) > 0)
                    {
                        dataGridPaying.DataSource = dt;
                    }
                    else
                    {
                        txtSearch.Text = "";
                        MessageBox.Show("No data found.",
                        "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }



                    cellDisplay();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            main = (frmMain)Application.OpenForms["frmMain"];
            frmBill fb = new frmBill();
            fb.client = user;
            fb.back = 2;
            main.OpenChildForm(fb);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            main = (frmMain)Application.OpenForms["frmMain"];
            frmUpdateDetails updateForm = new frmUpdateDetails();
            updateForm.client = user;
            updateForm.back = 2;
            main.OpenChildForm(updateForm);

        }

        private void dataGridPaying_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlPreview_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbInstallment_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInstallment.Checked)
            {
                rbFullPayment.Checked = false;
                txtYears.Enabled = true;
                txtDiscount.Enabled = true;
                cbMonths.Enabled = true;

            }
        }

        private void rbFullPayment_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFullPayment.Checked)
            {
                txtYears.Enabled = false;
                rbInstallment.Checked = false;
                txtDiscount.Enabled = false;
                cbMonths.Enabled = false;

            }
        }

        private void txtYears_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Limit to 2 digits
            if (txtDiscount.Text.Length >= 2 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Limit to 2 digits
            if (txtDiscount.Text.Length >= 3 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
