﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace FuneralManagementSystem
{
    public partial class frmLogIn : Form
    {
        String status;
        public frmLogIn()
        {
            InitializeComponent();

            
            lblWarning.Hide(); //Wrong login credentials warning.
            txtPassword.PasswordChar = '•'; //To hide password letters.
            
        }

        //SQL Connection
        SqlConnection con = new SqlConnection(@"Data Source=JIANNESANTOS\SQLEXPRESS;Initial Catalog=FuneralManagementSystem;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Normal;

        }




        //Login button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            try
            {
                con.Open();
                String query = "SELECT * FROM ACCOUNTS WHERE userName = '" + username +
                    "' AND userPassword = '" + password + "'";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                   

                    //Login History
                    String log = "LoginHistory.txt";

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT userId, hierarchy FROM ACCOUNTS WHERE userName = '" + username +
                                            "' AND userPassword = '" + password + "' ";

                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        StreamWriter write = File.AppendText(log);
                        write.WriteLine("ID: " + read[0] + ", NAME: " + username + ", DATE: " + DateTime.Now.ToString());
                        write.Close();
                        status = read[1].ToString();

                        //Open Home form
                        frmMain sysar = new frmMain();

                        if(status == "Staff")
                        {
                            sysar.btnArchive.Visible = false;
                        }

                        sysar.Show();
                        this.Hide();
                    }
                }
                else
                {
                    lblWarning.Show();
                    txtPassword.Clear();
                    txtUsername.Clear();
                }
            }
            catch
            {
                lblWarning.Show();
                txtPassword.Clear();
                txtUsername.Clear();
            }
            finally
            {
                con.Close();
            }
        }

        //Show Password checkbox
        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbShowPassword.Checked ? '\0' : '•';
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            //Confirmation message dialog
            DialogResult result = MessageBox.Show("Are you sure you want to close the system? ",
                "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
                frmLogIn log = (frmLogIn)Application.OpenForms["frmLogIn"];
                log.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
