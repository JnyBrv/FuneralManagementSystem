﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuneralManagementSystem
{
    public partial class FrmPackages : Form
    {
        public FrmPackages()
        {
            InitializeComponent();
        }

        private void FrmPackages_Load(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();   
            main.Hide();
            frmAvail clientContractForm = new frmAvail();
            
            clientContractForm.Show();
        }
    }
}
