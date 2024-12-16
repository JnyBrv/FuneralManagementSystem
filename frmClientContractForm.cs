
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
    public partial class frmClientContractForm : Form
    {
        frmMain main;
        public frmClientContractForm()
        {
            InitializeComponent();

            dateOfPurchase.Value = DateTime.Today;
            datepickDateofDeath.Value = DateTime.Today;
            datepickDateofInternment.Value = DateTime.Today;
            timeOfInternment.Value = DateTime.Today;

        }
        private void frmClientContractForm_Load(object sender, EventArgs e)
        {

        }

        //SQL Connection
        SqlConnection con = new SqlConnection(@"Data Source=JIANNESANTOS\SQLEXPRESS;Initial Catalog=FuneralManagementSystem;Integrated Security=True");
        


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
                    count = Convert.ToInt32(result);
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return count;
        }

        public int package;
        public int id;

        private void btnNext_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtClientFirstname.Text == "" || txtClientLastname.Text == "" || txtRelation.Text == "" || txtContactno.Text == ""
                    || txtClientHouseStreet.Text == "" || txtClientBrgy.Text == "" || txtClientCity.Text == "" || txtClientProvince.Text == "" || dateOfPurchase.Text == ""
                    || txtDeceasedFirstName.Text == "" || txtDeceasedLastName.Text == "" || datepickDateofDeath.Text == "" || datepickDateofInternment.Text == ""
                    || timeOfInternment.Text == "" || cmbSex.Text == "" || txtInternmentStreet.Text == "" || txtInternmentBrgy.Text == "" || txtInternmentCity.Text == "" || txtInternmentProvince.Text == "")
                {
                    MessageBox.Show("Please fill all text box field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtContactno.Text.Length < 9)
                {
                    MessageBox.Show("Phone number must be at least 12 digits.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    id = getCount(-1);

                    //client information
                    String fname = txtClientFirstname.Text;
                    String mname = txtClientMiddlename.Text;
                    if (txtClientMiddlename.Text == null || txtClientMiddlename.Text.Trim() == "")
                    {
                        txtClientMiddlename.Text = "";
                    }
                    String lname = txtClientLastname.Text;
                    String relation = txtRelation.Text;
                    String contact = "+639" + txtContactno.Text;
                    String address = txtClientHouseStreet.Text + ", " + txtClientBrgy.Text + ", " + txtClientCity.Text + ", " + txtClientProvince.Text;
                    dateOfPurchase.Format = DateTimePickerFormat.Custom;
                    dateOfPurchase.CustomFormat = "yyyy/MM/dd";


                    //deceased information
                    String dfname = txtDeceasedFirstName.Text;
                    String dmname = txtDeceasedMiddleName.Text;
                    if (txtClientMiddlename.Text == null || txtClientMiddlename.Text.Trim() == "")
                    {
                        txtClientMiddlename.Text = "";
                    }
                    String dlname = txtDeceasedLastName.Text;
                    datepickDateofDeath.Format = DateTimePickerFormat.Custom;
                    datepickDateofDeath.CustomFormat = "yyyy/MM/dd";
                    datepickDateofInternment.Format = DateTimePickerFormat.Custom;
                    datepickDateofInternment.CustomFormat = "yyyy/MM/dd";
                    timeOfInternment.Format = DateTimePickerFormat.Time;
                    timeOfInternment.CustomFormat = "hh:mm tt";
                    String sex = cmbSex.Text;
                    String place = txtInternmentStreet.Text + ", " + txtInternmentBrgy.Text + ", " + txtInternmentCity.Text + ", " + txtInternmentProvince.Text;

                    //insert into database
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText =
                        "INSERT INTO DECEASED (deceasedID, deceasedFname, deceasedMname, deceasedLname, dateOfDeath, dateOfInternment, timeOfInternment, placeOfInternment, sex, archive)" +
                        " VALUES (" + id + ", '" + dfname + "', '" + dmname + "', '" + dlname + "', '" + datepickDateofDeath.Text + "', '" + datepickDateofInternment.Text + "', '" + timeOfInternment.Text + "', '" + place + "', '" + sex + "', 0) " +
                        " INSERT INTO CLIENT (clientID, clientFname, clientMname, clientLname, clientRelation, clientAddress, clientContactNo, dateOfPurchase, archive, packageID, deceasedID)" +
                        " VALUES(" + id + ", '" + fname + "', '" + mname + "', '" + lname + "', '" + relation + "', '" + address + "', '" + contact + "', '" + dateOfPurchase.Text + "', 0, " + package + ", " + id + ") ";
                    cmd.ExecuteNonQuery();

                    con.Close();


                    main = (frmMain)Application.OpenForms["frmMain"];
                    frmInclusions inclu = new frmInclusions();
                    inclu.id = id;
                    inclu.package = package;
                    main.OpenChildForm(inclu);
                    main.panelTitleBar.Visible = false;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
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

        private void dateOfPurchase_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
