using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuneralManagementSystem
{
    public partial class frmUpdateDetails : Form
    {
        frmMain main;


        //SQL Connection
        SqlConnection con = new SqlConnection(@"Data Source=JIANNESANTOS\SQLEXPRESS;Initial Catalog=FuneralManagementSystem;Integrated Security=True");

        public int client { get; set; }

        public int back { get; set; }
        public frmUpdateDetails()
        {
            InitializeComponent();
        }

        private void frmUpdateDetails_Load(object sender, EventArgs e)
        {
            clientDetails();
            deceasedDetails();
            attachmentsDetails();
            displayImg();
            //paymentDetails();
            getRecords();
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


        public void clientDetails()
        {
            dateOfPurchase.Format = DateTimePickerFormat.Custom;
            dateOfPurchase.CustomFormat = "yyyy/MM/dd";
            try
            {
                String query = "SELECT clientFname, clientMname, clientLname, clientRelation, clientContactNo, dateOfPurchase, clientAddress FROM CLIENT WHERE clientID = " + client;
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);

                    SqlDataReader read = cmd.ExecuteReader();
                    read.Read();

                    if (read.HasRows)
                    {
                        txtClientFirstname.Text = read[0].ToString();
                        txtClientMiddlename.Text = read[1].ToString();
                        txtClientLastname.Text = read[2].ToString();
                        txtRelation.Text = read[3].ToString();
                        txtContactno.Text = splitPhoneNumber(read[4].ToString());
                        DateTime dateTimeValue = (DateTime)read[5];
                        dateOfPurchase.Value = dateTimeValue;
                        string address = read[6].ToString();
                        string[] addressParts = address.Split(new[] { ", " }, StringSplitOptions.None);

                        txtClientHouseStreet.Text = addressParts[0];
                        txtClientBrgy.Text = addressParts[1];
                        txtClientCity.Text = addressParts[2];
                        txtClientProvince.Text = addressParts[3];

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

        public void deceasedDetails()
        {
            datepickDateofDeath.Format = DateTimePickerFormat.Custom;
            datepickDateofDeath.CustomFormat = "yyyy/MM/dd";
            datepickDateofInternment.Format = DateTimePickerFormat.Custom;
            datepickDateofInternment.CustomFormat = "yyyy/MM/dd";
            
            try
            {
                String query = "SELECT deceasedFname, deceasedMname, deceasedLname, dateOfDeath, dateOfInternment, timeOfInternment, placeOfInternment, sex FROM DECEASED WHERE deceasedID = " + client;
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);

                    SqlDataReader read = cmd.ExecuteReader();
                    read.Read();

                    if (read.HasRows)
                    {
                        txtDeceasedFirstName.Text = read[0].ToString();
                        txtDeceasedMiddleName.Text = read[1].ToString();
                        txtDeceasedLastName.Text = read[2].ToString();
                        DateTime dateofDeath = (DateTime)read[3];
                        datepickDateofDeath.Value = dateofDeath;
                        DateTime dateofInt = (DateTime)read[4];
                        datepickDateofInternment.Value = dateofInt;

                        string timeString = read[5].ToString();
                        DateTime timeValue;
                        if (DateTime.TryParseExact(timeString, "h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out timeValue))
                        {
                            timeOfInternment.Value = timeValue;
                            timeOfInternment.Format = DateTimePickerFormat.Time;
                        }
                        else if (DateTime.TryParseExact(timeString, "HH:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out timeValue))
                        {
                            timeOfInternment.Value = timeValue;
                            timeOfInternment.Format = DateTimePickerFormat.Time;
                        }

                        string address = read[6].ToString();
                        string[] addressParts = address.Split(new[] { ", " }, StringSplitOptions.None);

                        txtInternmentStreet.Text = addressParts[0];
                        txtInternmentBrgy.Text = addressParts[1];
                        txtInternmentCity.Text = addressParts[2];
                        txtInternmentProvince.Text = addressParts[3];

                        cmbSex.Text = read[7].ToString();
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

        public void attachmentsDetails()
        {
            dataGridAttachments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridAttachments.DefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Regular);
            dataGridAttachments.ColumnHeadersDefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Bold);
            
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT attachmentID, attachmentName AS 'File Name' FROM ATTACHMENT WHERE clientID =" + client + " AND archive = 0";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridAttachments.DataSource = dt;
                con.Close();

                dataGridAttachments.Columns["attachmentID"].Visible = false;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            

        }

        //public void paymentDetails()
        //{
        //    dataGridPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    dataGridPayments.DefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Regular);
        //    dataGridPayments.ColumnHeadersDefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Bold);
        //    try
        //    {
        //        con.Open();
        //        SqlCommand cmd = con.CreateCommand();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "SELECT payDescription, paydate, payamount FROM PAYMENT WHERE clientID =" + client + " AND archive = 0";
        //        cmd.ExecuteNonQuery();
        //        DataTable dt = new DataTable();
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(dt);
        //        dataGridPayments.DataSource = dt;
        //        con.Close();

        //    }
        //    catch (Exception ee)
        //    {
        //        MessageBox.Show(ee.ToString());
        //    }
        //}

        public static string splitPhoneNumber(string phoneNumber, string prefixToRemove = "+639")
        {
            if (!phoneNumber.StartsWith(prefixToRemove))
            {
                return phoneNumber; 
            }

            return phoneNumber.Substring(prefixToRemove.Length);
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            main = (frmMain)Application.OpenForms["frmMain"];

            if (back == 1)
            {
                main.OpenChildForm(new frmArchivedClients());
                main.panelTitleBar.Visible = false;
            }
            else if (back == 0)
            {
                main.OpenChildForm(new FrmClients());
                main.panelTitleBar.Visible = false;
            }else if(back == 2)
            {
                main.OpenChildForm(new frmPaying());
                main.panelTitleBar.Visible = false;
            }
            

        }

        private void txtClientLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtClientFirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtClientMiddlename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRelation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtClientBrgy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtClientCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtClientProvince_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDeceasedLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDeceasedFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDeceasedMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtInternmentBrgy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtInternmentCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtInternmentProvince_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContactno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtContactno.Text.Length >= 9 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txtFileName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void txtDescription_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
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

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtClientFirstname.Text == "" || txtClientMiddlename.Text == "" || txtClientLastname.Text == "" || txtRelation.Text == "" || txtContactno.Text == ""
                    || txtClientHouseStreet.Text == "" || txtClientBrgy.Text == "" || txtClientCity.Text == "" || txtClientProvince.Text == "" || dateOfPurchase.Text == "")
                {
                    MessageBox.Show("Please fill all text box field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtContactno.Text.Length < 9)
                {
                    MessageBox.Show("Phone number must be at least 12 digits.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //client information
                    String fname = txtClientFirstname.Text;
                    String mname = txtClientMiddlename.Text;
                    String lname = txtClientLastname.Text;
                    String relation = txtRelation.Text;
                    String contact = "+639" + txtContactno.Text;
                    String address = txtClientHouseStreet.Text + ", " + txtClientBrgy.Text + ", " + txtClientCity.Text + ", " + txtClientProvince.Text;
                    dateOfPurchase.Format = DateTimePickerFormat.Custom;
                    dateOfPurchase.CustomFormat = "yyyy/MM/dd";

                    //update database
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText =
                        "UPDATE CLIENT SET clientFname = '" + fname +"'  , clientMname = '" + mname +"', clientLname= '" + lname +"', clientRelation= '" + relation +
                        "', clientContactNo= '" + contact +"', dateOfPurchase= '" + dateOfPurchase.Text +"', clientAddress= '" +  address+ "' WHERE clientID = " + client;
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void btnSaveDeceased_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDeceasedFirstName.Text == "" || txtDeceasedMiddleName.Text == "" || txtDeceasedLastName.Text == "" || datepickDateofDeath.Text == "" || datepickDateofInternment.Text == ""
                    || timeOfInternment.Text == "" || cmbSex.Text == "" || txtInternmentStreet.Text == "" || txtInternmentBrgy.Text == "" || txtInternmentCity.Text == "" || txtInternmentProvince.Text == "")
                {
                    MessageBox.Show("Please fill all text box field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //deceased information
                    String dfname = txtDeceasedFirstName.Text;
                    String dmname = txtDeceasedMiddleName.Text;
                    String dlname = txtDeceasedLastName.Text;
                    datepickDateofDeath.Format = DateTimePickerFormat.Custom;
                    datepickDateofDeath.CustomFormat = "yyyy/MM/dd";
                    datepickDateofInternment.Format = DateTimePickerFormat.Custom;
                    datepickDateofInternment.CustomFormat = "yyyy/MM/dd";
                    timeOfInternment.Format = DateTimePickerFormat.Time;
                    timeOfInternment.CustomFormat = "hh:mm tt";
                    String sex = cmbSex.Text;
                    String place = txtInternmentStreet.Text + ", " + txtInternmentBrgy.Text + ", " + txtInternmentCity.Text + ", " + txtInternmentProvince.Text;


                    //update database
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText =
                        "UPDATE DECEASED SET deceasedFname= '" + dfname + "', deceasedMname= '" + dmname + "', deceasedLname= '" + dlname + "', dateOfDeath= '" + datepickDateofDeath.Text +
                        "', dateOfInternment= '" + datepickDateofInternment.Text + "', timeOfInternment= '" + timeOfInternment.Text + "', placeOfInternment= '" + place + "', sex= '" + sex + "' " +
                        " WHERE deceasedID = " + client;
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        //image
        public String imgLocation = "";
        public String selectedUser;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            txtFileName.Text = "";
            lblfPath.Text = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PNG files (*.png)|*.png|JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                lblfPath.Text = imgLocation;
            }
        }

        public Image picture = null;
        private void dataGridAttachments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dataGridAttachments.Rows[e.RowIndex];

                selectedUser = row.Cells[0].Value.ToString();
            }
            displayImg();
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] images = null;
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);

                int id = getLength(0);

                con.Open();
                String query = "INSERT INTO ATTACHMENT (attachmentId, attachmentName, attachment, archive, clientID) VALUES ('" + client + "-" + id + "', '" + txtFileName.Text + "', @images, 0, "+ client +")";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                int n = cmd.ExecuteNonQuery();
                con.Close();

                lblfPath.Text = "";
                txtFileName.Clear();
                MessageBox.Show("Attachment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                attachmentsDetails();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        public int getLength(int length)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(*) FROM ATTACHMENT";

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    length = Convert.ToInt32(result);
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
            return length;
        }

        public void displayImg()
        {
            pboxAttachments.Image = null;
            try
            {

                String query = "SELECT attachment FROM ATTACHMENT WHERE attachmentID = '" + selectedUser + "' AND clientID = " + client;
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);

                    SqlDataReader read = cmd.ExecuteReader();
                    read.Read();

                    if (read.HasRows)
                    {
                        byte[] img = (byte[])(read[0]);

                        if (img == null)
                        {
                            pboxAttachments.Image = null;
                        }
                        else
                        {
                            MemoryStream ms = new MemoryStream(img);
                            pboxAttachments.Image = Image.FromStream(ms);

                            picture = pboxAttachments.Image;
                        }
                    }

                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this attachment? ",
                "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE ATTACHMENT SET archive = 1 WHERE attachmentID = '" + selectedUser+"'";
                    cmd.ExecuteNonQuery();

                    con.Close();
                    attachmentsDetails();
                    MessageBox.Show("Attachment deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pboxAttachments.Image = null;
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            main = (frmMain)Application.OpenForms["frmMain"];
            frmPrintImg print = new frmPrintImg();
            print.img = picture;
            print.client = client;
            main.OpenChildForm(print);
            main.panelTitleBar.Visible = false;
        }


        //inclusions
        String items;
        float inctotal, balance;
        decimal value;

        public void getRecords()
        {
            String query = "SELECT addInclusions, inclusionsTotal, balance FROM CLIENT WHERE clientID = " + client;
            if (con.State != ConnectionState.Open)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader read = cmd.ExecuteReader();
                read.Read();

                if (read.HasRows)
                {
                    items = read[0].ToString();
                    inctotal = float.Parse(read[1].ToString());
                    balance = float.Parse(read[2].ToString());

                    
                    if (read[2] is decimal)
                    {
                        value = (decimal)read[2];
                    }
                    else if (read[2] is int || read[2] is long || read[2] is float || read[2] is double)
                    {
                        value = Convert.ToDecimal(read[2]);
                    }

                    string formattedValue = value.ToString("N2");

                    //lblBalance.Text = formattedValue;


                }
                else
                {
                    con.Close();
                    MessageBox.Show("Data doesn't exist.");
                }
                con.Close();


            }
        }

        //private void btnConfirmPayment_Click(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(txtPayment.Text))
        //    {
        //        if (!string.IsNullOrEmpty(txtDescription.Text))
        //        {
        //            DialogResult result = MessageBox.Show("Confirm Payment and Print Receipt?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //            if (result == DialogResult.Yes)
        //            {
        //                getRecords();
        //                int pitems = countPay(-1);
        //                String paymentID = client + "-" + pitems;

        //                DateTime today = DateTime.Today;
        //                String date = today.ToString("yyyy-MM-dd");



        //                String desc = txtDescription.Text;
        //                float payamount = float.Parse(txtPayment.Text);
        //                float newbal = balance - payamount;
        //                try
        //                {
        //                    con.Open();

        //                    SqlCommand cmd = con.CreateCommand();
        //                    cmd.CommandType = CommandType.Text;
        //                    cmd.CommandText = "UPDATE CLIENT SET balance = '" + newbal + "' WHERE clientID = " + client +
        //                        "INSERT INTO PAYMENT (paymentID, payAmount, payDescription, paydate, archive, clientID) VALUES('" + paymentID + "'," + payamount + ", '" + desc + "', '" + date + "',0, " + client + "); ";
        //                    cmd.ExecuteNonQuery();

        //                    con.Close();

        //                    MessageBox.Show("Payment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    getRecords();
        //                    paymentDetails();


        //                    //receipt
        //                    String fname = txtClientFirstname.Text;
        //                    String mname = txtClientMiddlename.Text;
        //                    String lname = txtClientLastname.Text;
        //                    String num = txtContactno.Text;


        //                    main = (frmMain)Application.OpenForms["frmMain"];
        //                    frmReceipt rec = new frmReceipt();
        //                    rec.clientName = fname + " " + mname + " " + lname;
        //                    rec.contact = "+639" + num;
        //                    rec.date = date;
        //                    rec.description = desc;
        //                    rec.amount = payamount.ToString();
        //                    rec.rbal = newbal.ToString();
        //                    rec.client = client;

        //                    main.OpenChildForm(rec);

        //                    txtDescription.Text = "";
        //                    txtPayment.Text = "";
        //                }
        //                catch (Exception ee)
        //                {
        //                    MessageBox.Show(ee.ToString());
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Cancelled payment.", "Payment failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                txtDescription.Text = "";
        //                txtPayment.Text = "";
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Please enter description before we proceed.", "Empty description", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please enter payment before we proceed.", "Empty payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        main = (frmMain)Application.OpenForms["frmMain"];
        //        main.OpenChildForm(new FrmPackages());
        //        main.panelTitleBar.Visible = false;
        //    }

        //}

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

        //private void btnCompleteTransaction_Click(object sender, EventArgs e)
        //{
        //    decimal bal = decimal.Parse(lblBalance.Text);
        //    if (bal > 0)
        //    {
        //        DialogResult res = MessageBox.Show("There are still remaining balances to be paid. Are you sure you still want to complete the transaction?", "Remaining balance", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //        if (res == DialogResult.Yes)
        //        {
        //            try
        //            {
        //                con.Open();

        //                SqlCommand cmd = con.CreateCommand();
        //                cmd.CommandType = CommandType.Text;
        //                cmd.CommandText = "UPDATE CLIENT SET archive = 3 WHERE clientID = " + client +
        //                                "UPDATE DECEASED SET archive = 3 WHERE deceasedID = " + client +
        //                                "UPDATE PAYMENT SET archive = 3 WHERE clientID = " + client;
        //                cmd.ExecuteNonQuery();
        //                con.Close();
        //                MessageBox.Show("Changes saved successfully!",
        //            "Complete Transaction Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //                main = (frmMain)Application.OpenForms["frmMain"];
        //                main.OpenChildForm(new FrmClients());
        //                main.panelTitleBar.Visible = false;
        //            }
        //            catch (Exception ee)
        //            {
        //                MessageBox.Show(ee.ToString());
        //            }
        //        }
        //    }
        //    else
        //    {
        //        DialogResult result = MessageBox.Show("Are you sure you want to complete the transaction? This record will now be archived.",
        //            "Complete Transaction Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (result == DialogResult.Yes)
        //        {
        //            try
        //            {
        //                con.Open();

        //                SqlCommand cmd = con.CreateCommand();
        //                cmd.CommandType = CommandType.Text;
        //                cmd.CommandText = "UPDATE CLIENT SET archive = 3 WHERE clientID = " + client +
        //                                "UPDATE DECEASED SET archive = 3 WHERE deceasedID = " + client +
        //                                "UPDATE PAYMENT SET archive = 3 WHERE clientID = " + client;
        //                cmd.ExecuteNonQuery();
        //                con.Close();
        //                MessageBox.Show("Changes saved successfully!",
        //            "Complete Transaction Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //                main = (frmMain)Application.OpenForms["frmMain"];
        //                main.OpenChildForm(new FrmClients());
        //                main.panelTitleBar.Visible = false;
        //            }
        //            catch (Exception ee)
        //            {
        //                MessageBox.Show(ee.ToString());
        //            }
        //        }
        //    }

        //}

        //private void btnUpdateInclusions_Click(object sender, EventArgs e)
        //{
        //    getRecords();
        //    try
        //    {
                
        //            String item = txtAddInclusions.Text;
        //            float bal = float.Parse(txtAddPayment.Text);

        //            float itotal = inctotal + bal;
        //            float baltotal = balance + bal;
        //            con.Open();

        //            SqlCommand cmd1 = con.CreateCommand();
        //            cmd1.CommandType = CommandType.Text;
        //            cmd1.CommandText = "UPDATE CLIENT SET addInclusions = '" + items + " " + item + "' WHERE clientID = " + client +
        //                "UPDATE CLIENT SET inclusionsTotal = '" + itotal + "' WHERE clientID = " + client +
        //                "UPDATE CLIENT SET balance = '" + baltotal + "' WHERE clientID = " + client;
        //            cmd1.ExecuteNonQuery();

        //            con.Close();
        //            MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            txtAddInclusions.Text = "";
        //            txtAddPayment.Text = "";
        //        getRecords();
        //    }
        //    catch (Exception ee)
        //    {
        //        MessageBox.Show(ee.ToString());
        //    }
        //}

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            //calculate();
        }

        //public void calculate()
        //{
        //    decimal  num2, num3, result;


        //    if (string.IsNullOrEmpty(txtPayment.Text))
        //    {
        //        num2 = 0;
        //    }
        //    else
        //    {
        //        num2 = decimal.Parse(txtPayment.Text);
        //    }

        //    num3 = decimal.Parse(lblBalance.Text);


        //    result = num3 - num2;

        //    if (result < 0)
        //    {
        //        MessageBox.Show("You've entered an exceeding amount.", "Payment error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        txtPayment.Text = "";
        //    }
        //    else
        //    {
        //        result = Math.Round(result, 2);
        //    }

        //}
    }
}
