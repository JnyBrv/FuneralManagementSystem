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
    public partial class FrmEmployees : Form
    {
        frmMain main;
        String selectedUser;
        public int user, id;
        String userid, status;

        //SQL Connection
        SqlConnection con = new SqlConnection(@"Data Source=JIANNESANTOS\SQLEXPRESS;Initial Catalog=FuneralManagementSystem;Integrated Security=True");

        public FrmEmployees()
        {
            InitializeComponent();
            loadTable();

            dataGridEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridEmployee.DefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Regular);
            dataGridEmployee.ColumnHeadersDefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Bold);
            cellDisplay();

        }

        public void loadTable()
        {
            txtSearch.Text = "";
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT userID AS 'User ID', userName AS 'Username', userPassword AS 'Password', hierarchy AS 'Class', archive AS ' Account Status' FROM ACCOUNTS";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridEmployee.DataSource = dt;


                con.Close();


                if (dataGridEmployee.Rows.Count == 0)
                {
                    pnlPreview.Visible = false;
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
                frmLogIn log = (frmLogIn)Application.OpenForms["frmLogIn"];
                log.Close();
                Close();
            }
        }

        public void cellDisplay()
        {

            if (dataGridEmployee.Rows.Count == 0)
            {
                MessageBox.Show("There's no employee listed.",
                        "On service client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataGridViewRow row = dataGridEmployee.Rows[0];

                selectedUser = row.Cells[0].Value.ToString();

                try
                {
                    String query = " SELECT * FROM ACCOUNTS WHERE userID = '" +selectedUser + "'";
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(query, con);

                        SqlDataReader read = cmd.ExecuteReader();
                        read.Read();

                        if (read.HasRows)
                        {
                            txtUsername.Text = read[1].ToString();
                            txtPassword.Text = read[2].ToString();
                            status = read[3].ToString();
                            cmbRank.Text = read[4].ToString();

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbRank.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtSearch.Text = "";

        }

        public int getCount(int count)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(*) FROM ACCOUNTS";

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    count = Convert.ToInt32(result) +1;
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return count;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" || txtPassword.Text == "" || cmbRank.Text == "" )
                {
                    MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    id = getCount(-1);
                    
                    //employee information
                    if(cmbRank.Text == "Admin")
                    {
                        userid = "AD" + (1000 + id);
                    }
                    else if(cmbRank.Text == "Staff")
                    {
                        userid = "ST" + (1000 + id);
                    }
                    String username = txtUsername.Text;
                    String userpass = txtPassword.Text;


                    //insert into database
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText =
                        "INSERT INTO ACCOUNTS (userID, userName, userPassword, archive, hierarchy)" +
                        " VALUES ('" + userid + "', '" + username + "', '" + userpass + "', 0 , '" + cmbRank.Text + "')";
                    cmd.ExecuteNonQuery();

                    con.Close();

                    loadTable();
                    cellDisplay();

                    MessageBox.Show("New account added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" || txtPassword.Text == "" || cmbRank.Text == "")
                {
                    MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    id = getCount(-1);

                    //employee information
                    if (cmbRank.Text == "Admin")
                    {
                        userid = "AD" + (1000 + id);
                    }
                    else if (cmbRank.Text == "Staff")
                    {
                        userid = "ST" + (1000 + id);
                    }
                    String username = txtUsername.Text;
                    String userpass = txtPassword.Text;

                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText =
                        "UPDATE ACCOUNTS SET userName = '" + username +"', userPassword= '" + userpass +"',  hierarchy= '" + cmbRank.Text +"' WHERE userID = '" + selectedUser + "'";
                    cmd.ExecuteNonQuery();

                    con.Close();

                    loadTable();
                    cellDisplay();
                    MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void dataGridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dataGridEmployee.Rows[e.RowIndex];

                selectedUser = row.Cells[0].Value.ToString();

                try
                {
                    String query = " SELECT * FROM ACCOUNTS WHERE userID = '" + selectedUser + "'";
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(query, con);

                        SqlDataReader read = cmd.ExecuteReader();
                        read.Read();

                        if (read.HasRows)
                        {
                            txtUsername.Text = read[1].ToString();
                            txtPassword.Text = read[2].ToString();
                            status = read[3].ToString();
                            cmbRank.Text = read[4].ToString();

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

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (status == "Active")
                {
                    MessageBox.Show("This account is already active.", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    id = getCount(-1);

                    //employee information
                    if (cmbRank.Text == "Admin")
                    {
                        userid = "AD" + (1000 + id);
                    }
                    else if (cmbRank.Text == "Staff")
                    {
                        userid = "ST" + (1000 + id);
                    }
                    String username = txtUsername.Text;
                    String userpass = txtPassword.Text;

                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText =
                        "UPDATE ACCOUNTS SET archive = 'Active' WHERE userID = '" + selectedUser + "'";
                    cmd.ExecuteNonQuery();

                    con.Close();

                    loadTable();
                    cellDisplay();
                    MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
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
                    cmd.CommandText = "SELECT * FROM ACCOUNTS WHERE userID LIKE '%" + keyword + "%' OR userName LIKE '%" + keyword + "%' " +
                                "OR userPassword LIKE '%" + keyword + "%' OR hierarchy LIKE '%" + keyword + "%' " +
                                "OR archive LIKE '%" + keyword + "%' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    con.Close();
                    if (da.Fill(dt) > 0)
                    {
                        dataGridEmployee.DataSource = dt;
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

        private void dataGridEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            try
            {
                if (status == "Deactivated")
                {
                    MessageBox.Show("This account is already archived/deactivated.", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    id = getCount(-1);

                    //employee information
                    if (cmbRank.Text == "Admin")
                    {
                        userid = "AD" + (1000 + id);
                    }
                    else if (cmbRank.Text == "Staff")
                    {
                        userid = "ST" + (1000 + id);
                    }
                    String username = txtUsername.Text;
                    String userpass = txtPassword.Text;

                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText =
                        "UPDATE ACCOUNTS SET archive = 'Deactivated' WHERE userID = '" + selectedUser + "'";
                    cmd.ExecuteNonQuery();

                    con.Close();

                    loadTable();
                    cellDisplay();
                    MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
