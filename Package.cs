using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public Package()
      
        {
            InitializeComponent();
            DelPackage = new DelegateText(AddPackageClass.GetPackage);
            DelInclustions = new DelegateText(AddPackageClass.GetInclusions);
            DelPrice = new DelegateNumber(AddPackageClass.GetPrice);

            lblPackageName.Text = DelPackage(AddPackageClass.PackageName);
            txtInclusions.Text = DelInclustions(AddPackageClass.Inclusions);
            lblPrice.Text = DelPrice(AddPackageClass.Price).ToString();

        }
    }
}
