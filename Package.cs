using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FuneralManagementSystem.AddPackageClass;

namespace FuneralManagementSystem
{
    public partial class Package : UserControl
    {
        private DelegateText DelPackage, DelInclustions;
        private DelegateNumber DelPrice;
        frmMain main;
        frmClientContractForm ccf;

        private void btnOmsAvail_Click(object sender, EventArgs e)
        {
            main = (frmMain)Application.OpenForms["frmMain"];
            main.OpenChildForm(new frmClientContractForm());
            ccf = (frmClientContractForm)Application.OpenForms["frmClientContractForm"];
            ccf.package = 0;
            main.panelTitleBar.Visible = false;
        }


        private void applyRoundEdge()
        {
            // PANG ROUND NG EDGESS!!
            roundEdge(btnOmsAvail, 20); 
            roundEdge(txtInclusions, 15); 
            roundEdge(lblPackageName, 10);

            roundEdgeForm();
        }
            
        private void roundEdgeForm()
        {
            int borderRadius = 30; 
            GraphicsPath path = new GraphicsPath();

            // Add arcs to the corners 
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }

        private void roundEdge(Control control, int borderRadius)
        {
      


            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(control.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90); 
            path.AddArc(control.Width - borderRadius, control.Height - borderRadius, borderRadius, borderRadius, 0, 90); 
            path.AddArc(0, control.Height - borderRadius, borderRadius, borderRadius, 90, 90); 
            path.CloseFigure();

            control.Region = new Region(path);
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void Package_Load(object sender, EventArgs e)
        {
            roundEdgeForm();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtInclusions_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public Package()
      
        {
            InitializeComponent();
            DelPackage = new DelegateText(AddPackageClass.GetPackage);
            DelInclustions = new DelegateText(AddPackageClass.GetInclusions);
            DelPrice = new DelegateNumber(AddPackageClass.GetPrice);

            lblPackageName.Text = DelPackage(AddPackageClass.PackageName);
            txtInclusions.Text = DelInclustions(AddPackageClass.Inclusions);
            lblPrice.Text = DelPrice(AddPackageClass.Price).ToString();

            applyRoundEdge();
        }
    }
}
