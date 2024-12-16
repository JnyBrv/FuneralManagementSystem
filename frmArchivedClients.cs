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
    public partial class frmArchivedClients : Form
    {
        frmMain main;
        String selectedUser;
        public int user;

        //SQL Connection
        SqlConnection con = new SqlConnection(@"Data Source=JIANNESANTOS\SQLEXPRESS;Initial Catalog=FuneralManagementSystem;Integrated Security=True");

        public frmArchivedClients()
        {
            InitializeComponent();
            loadCompletedTable();
            loadDeletedTable();

            dataGridCompleted.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCompleted.DefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Regular);
            dataGridCompleted.ColumnHeadersDefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Bold);
            dataGridCompleted.Columns[0].Visible = false;
            cellDisplayCompleted();

            dataGridDeleted.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDeleted.DefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Regular);
            dataGridDeleted.ColumnHeadersDefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Bold);
            dataGridDeleted.Columns[0].Visible = false;
            cellDisplayDeleted();

        }

        public void loadCompletedTable()
        {
            txtCSearch.Text = "";
            txtDSearch.Text = "";
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT CLIENT.clientID AS 'Client ID', CONCAT(CLIENT.clientFname, ' ', CLIENT.clientMname, ' ', CLIENT.clientLname) AS 'Client Name', " +
                            "CONCAT(DECEASED.deceasedFname, ' ', DECEASED.deceasedMname, ' ', DECEASED.deceasedLname) AS 'Decedent Name', " +
                            "PACKAGE.packageName AS 'Package Type', CLIENT.dateOfPurchase AS 'Date of Purchase' FROM DECEASED INNER JOIN CLIENT ON CLIENT.deceasedID = DECEASED.deceasedID " +
                            "INNER JOIN PACKAGE ON CLIENT.packageID = PACKAGE.packageID WHERE CLIENT.archive = 3";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridCompleted.DataSource = dt;
                con.Close();


                if (dataGridDeleted.Rows.Count == 0 && dataGridCompleted.Rows.Count == 0)
                {
                    pnlPreview.Visible = false;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        public void loadDeletedTable()
        {
            txtCSearch.Text = "";
            txtDSearch.Text = "";
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT CLIENT.clientID AS 'Client ID', CONCAT(CLIENT.clientFname, ' ', CLIENT.clientMname, ' ', CLIENT.clientLname) AS 'Client Name', " +
                            "CONCAT(DECEASED.deceasedFname, ' ', DECEASED.deceasedMname, ' ', DECEASED.deceasedLname) AS 'Decedent Name', " +
                            "PACKAGE.packageName AS 'Package Type', CLIENT.dateOfPurchase AS 'Date of Purchase' FROM DECEASED INNER JOIN CLIENT ON CLIENT.deceasedID = DECEASED.deceasedID " +
                            "INNER JOIN PACKAGE ON CLIENT.packageID = PACKAGE.packageID WHERE CLIENT.archive = 1";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridDeleted.DataSource = dt;
                con.Close();


                if (dataGridDeleted.Rows.Count == 0 && dataGridCompleted.Rows.Count == 0)
                {
                    pnlPreview.Visible = false;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        public void cellDisplayCompleted()
        {

            if (dataGridCompleted.Rows.Count == 0)
            {
                MessageBox.Show("There's no completed client listed.",
                        "On service client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataGridViewRow row = dataGridCompleted.Rows[0];

                selectedUser = row.Cells[0].Value.ToString();

                user = Convert.ToInt32(selectedUser);
                try
                {
                    String query = " SELECT CONCAT(CLIENT.clientFname, ' ', CLIENT.clientMname, ' ', CLIENT.clientLname) AS ClientName, " +
                                "CONCAT(DECEASED.deceasedFname, ' ', DECEASED.deceasedMname, ' ', DECEASED.deceasedLname) AS DeceasedName, " +
                                "CLIENT.clientContactNo, DECEASED.dateOfInternment, DECEASED.placeOfInternment, PACKAGE.packageName FROM DECEASED " +
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
                            lblDeceased.Text = read[1].ToString();
                            lblContact.Text = read[2].ToString();
                            String d = read[3].ToString();
                            string[] word = d.Split(' ');
                            lblDate.Text = word[0];
                            lblPlace.Text = read[4].ToString();
                            String package = read[5].ToString();

                            if (package.Equals("Package A"))
                            {
                                Image image = Properties.Resources.package1Image;

                                picPackage.Image = image;
                            }
                            else if (package.Equals("Package B"))
                            {
                                Image image = Properties.Resources.package2Image;

                                picPackage.Image = image;
                            }
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

        public void cellDisplayDeleted()
        {

            if (dataGridDeleted.Rows.Count == 0)
            {
                MessageBox.Show("There's no deleted client listed.",
                        "On service client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataGridViewRow row = dataGridDeleted.Rows[0];

                selectedUser = row.Cells[0].Value.ToString();

                user = Convert.ToInt32(selectedUser);
                try
                {
                    String query = " SELECT CONCAT(CLIENT.clientFname, ' ', CLIENT.clientMname, ' ', CLIENT.clientLname) AS ClientName, " +
                                "CONCAT(DECEASED.deceasedFname, ' ', DECEASED.deceasedMname, ' ', DECEASED.deceasedLname) AS DeceasedName, " +
                                "CLIENT.clientContactNo, DECEASED.dateOfInternment, DECEASED.placeOfInternment, PACKAGE.packageName FROM DECEASED " +
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
                            lblDeceased.Text = read[1].ToString();
                            lblContact.Text = read[2].ToString();
                            String d = read[3].ToString();
                            string[] word = d.Split(' ');
                            lblDate.Text = word[0];
                            lblPlace.Text = read[4].ToString();
                            String package = read[5].ToString();

                            if (package.Equals("Package A"))
                            {
                                Image image = Properties.Resources.package1Image;

                                picPackage.Image = image;
                            }
                            else if (package.Equals("Package B"))
                            {
                                Image image = Properties.Resources.package2Image;

                                picPackage.Image = image;
                            }
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

        private void dataGridCompleted_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dataGridCompleted.Rows[e.RowIndex];

                selectedUser = row.Cells[0].Value.ToString();

                user = Convert.ToInt32(selectedUser);
                try
                {
                    String query = " SELECT CONCAT(CLIENT.clientFname, ' ', CLIENT.clientMname, ' ', CLIENT.clientLname) AS ClientName, " +
                                "CONCAT(DECEASED.deceasedFname, ' ', DECEASED.deceasedMname, ' ', DECEASED.deceasedLname) AS DeceasedName, " +
                                "CLIENT.clientContactNo, DECEASED.dateOfInternment, DECEASED.placeOfInternment, PACKAGE.packageName FROM DECEASED " +
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
                            lblDeceased.Text = read[1].ToString();
                            lblContact.Text = read[2].ToString();
                            String d = read[3].ToString();
                            string[] word = d.Split(' ');
                            lblDate.Text = word[0];
                            lblPlace.Text = read[4].ToString();

                            String package = read[5].ToString();

                            if (package.Equals("Package A"))
                            {
                                Image image = Properties.Resources.package1Image;
                                picPackage.Image = image;
                            }
                            else if (package.Equals("Package B"))
                            {
                                Image image = Properties.Resources.package2Image;
                                picPackage.Image = image;
                            }
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

        private void dataGridDeleted_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dataGridDeleted.Rows[e.RowIndex];

                selectedUser = row.Cells[0].Value.ToString();

                user = Convert.ToInt32(selectedUser);
                try
                {
                    String query = " SELECT CONCAT(CLIENT.clientFname, ' ', CLIENT.clientMname, ' ', CLIENT.clientLname) AS ClientName, " +
                                "CONCAT(DECEASED.deceasedFname, ' ', DECEASED.deceasedMname, ' ', DECEASED.deceasedLname) AS DeceasedName, " +
                                "CLIENT.clientContactNo, DECEASED.dateOfInternment, DECEASED.placeOfInternment, PACKAGE.packageName FROM DECEASED " +
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
                            lblDeceased.Text = read[1].ToString();
                            lblContact.Text = read[2].ToString();
                            String d = read[3].ToString();
                            string[] word = d.Split(' ');
                            lblDate.Text = word[0];
                            lblPlace.Text = read[4].ToString();

                            String package = read[5].ToString();

                            if (package.Equals("Package A"))
                            {
                                Image image = Properties.Resources.package1Image;
                                picPackage.Image = image;
                            }
                            else if (package.Equals("Package B"))
                            {
                                Image image = Properties.Resources.package2Image;
                                picPackage.Image = image;
                            }
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

        private void txtCSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCSearch.Text))
            {
                loadCompletedTable();
            }
        }

        private void txtDSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDSearch.Text))
            {
                loadDeletedTable();
            }
        }

        private void btnCSearch_Click(object sender, EventArgs e)
        {

            string keyword = txtCSearch.Text;

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
                                "WHERE (CLIENT.archive = 3) AND (CLIENT.clientFname LIKE '%" + keyword + "%' OR CLIENT.clientMname LIKE '%" + keyword + "%' " +
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
                        dataGridCompleted.DataSource = dt;
                    }
                    else
                    {
                        txtCSearch.Text = "";
                        MessageBox.Show("No data found.",
                        "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }



                    cellDisplayCompleted();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void btnDSearch_Click(object sender, EventArgs e)
        {

            string keyword = txtDSearch.Text;

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
                                "WHERE (CLIENT.archive = 1) AND (CLIENT.clientFname LIKE '%" + keyword + "%' OR CLIENT.clientMname LIKE '%" + keyword + "%' " +
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
                        dataGridDeleted.DataSource = dt;
                    }
                    else
                    {
                        txtDSearch.Text = "";
                        MessageBox.Show("No data found.",
                        "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }



                    cellDisplayDeleted();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            main = (frmMain)Application.OpenForms["frmMain"];
            frmUpdateDetails updateForm = new frmUpdateDetails();
            updateForm.client = user;
            updateForm.back = 1;
            //updateForm.btnCompleteTransaction.Visible = false;
            main.OpenChildForm(updateForm);
        }

        private void btnCompleteService_Click(object sender, EventArgs e)
        {
            txtDSearch.Text = "";
            txtCSearch.Text = "";
            DialogResult result = MessageBox.Show("The client will then be directed to on service form.",
                "Restore Client Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE CLIENT SET archive = 0 WHERE clientID = " + user +
                                    "UPDATE DECEASED SET archive = 0 WHERE deceasedID = " + user +
                                    "UPDATE PAYMENT SET archive = 0 WHERE clientID = " + user;
                    cmd.ExecuteNonQuery();

                    con.Close();
                    loadCompletedTable();
                    cellDisplayCompleted();
                    loadDeletedTable();
                    cellDisplayDeleted();
                    MessageBox.Show("Changes saved successfully.",
                "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }
    }
}
