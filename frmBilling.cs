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
    public partial class frmBilling : Form
    {
        frmMain main;
        String selectedUser;
        public int user;
        frmUpdateDetails upd;

        //SQL Connection
        SqlConnection con = new SqlConnection(@"Data Source=JIANNESANTOS\SQLEXPRESS;Initial Catalog=FuneralManagementSystem;Integrated Security=True");

        public frmBilling()
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


        private void dataGridPaying_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
