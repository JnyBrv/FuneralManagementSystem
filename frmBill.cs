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
    public partial class frmBill : Form
    {
        public int client { get; set; }
        public int back { get; set; }

        public int totalmonth { get; set; }

        public decimal mona { get; set; }

        //SQL Connection
        SqlConnection con = new SqlConnection(@"Data Source=JIANNESANTOS\SQLEXPRESS;Initial Catalog=FuneralManagementSystem;Integrated Security=True");

        public frmBill()
        {
            InitializeComponent();

            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("MM/dd/yyyy");
            lblDate.Text = formattedDate;
            lblRefNumber.Text = client.ToString();
            lblMonthlyPay.Text = totalmonth.ToString();



        }

        public void load()
        {
            try
            {
                String query = " SELECT CONCAT(CLIENT.clientFname, ' ', CLIENT.clientMname, ' ', CLIENT.clientLname) AS ClientName, " +
                            "PACKAGE.packageName FROM DECEASED " +
                            "INNER JOIN CLIENT ON CLIENT.deceasedID = DECEASED.deceasedID INNER JOIN PACKAGE ON CLIENT.packageID = " +
                            "PACKAGE.packageID  WHERE CLIENT.clientID = " + client;
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);

                    SqlDataReader read = cmd.ExecuteReader();
                    read.Read();

                    if (read.HasRows)
                    {
                        lblName.Text = read[0].ToString();
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

        public void Computation()
        {



        }
        private void dgridInclusion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
