namespace FuneralManagementSystem
{
    partial class FrmPackages
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPackages));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnpackageB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDetailsPackage2 = new System.Windows.Forms.Label();
            this.lblPackage2 = new System.Windows.Forms.Label();
            this.pbPackage2 = new System.Windows.Forms.PictureBox();
            this.panelPackage1 = new System.Windows.Forms.Panel();
            this.lblDetailsPackage1 = new System.Windows.Forms.Label();
            this.lblPackage1Title = new System.Windows.Forms.Label();
            this.btnOmsAvail = new System.Windows.Forms.Button();
            this.pbPackage1 = new System.Windows.Forms.PictureBox();
            this.lblPricePackage1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPackage2)).BeginInit();
            this.panelPackage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPackage1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pbExit);
            this.panel2.Controls.Add(this.btnAddClient);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1305, 81);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 43);
            this.label3.TabIndex = 0;
            this.label3.Text = "PACKAGES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FuneralManagementSystem.Properties.Resources.packageIcon;
            this.pictureBox1.Location = new System.Drawing.Point(20, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pbExit
            // 
            this.pbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.Image = global::FuneralManagementSystem.Properties.Resources.exit;
            this.pbExit.Location = new System.Drawing.Point(1267, 0);
            this.pbExit.Margin = new System.Windows.Forms.Padding(2);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(38, 41);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 16;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddClient.BackColor = System.Drawing.Color.Gold;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.ForeColor = System.Drawing.Color.Black;
            this.btnAddClient.Image = ((System.Drawing.Image)(resources.GetObject("btnAddClient.Image")));
            this.btnAddClient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddClient.Location = new System.Drawing.Point(1031, 19);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(206, 50);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "   Add Packages ";
            this.btnAddClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnpackageB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDetailsPackage2);
            this.panel1.Controls.Add(this.lblPackage2);
            this.panel1.Controls.Add(this.pbPackage2);
            this.panel1.Location = new System.Drawing.Point(636, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 691);
            this.panel1.TabIndex = 9;
            // 
            // btnpackageB
            // 
            this.btnpackageB.BackColor = System.Drawing.Color.Gold;
            this.btnpackageB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpackageB.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpackageB.ForeColor = System.Drawing.Color.Black;
            this.btnpackageB.Location = new System.Drawing.Point(319, 610);
            this.btnpackageB.Name = "btnpackageB";
            this.btnpackageB.Size = new System.Drawing.Size(184, 39);
            this.btnpackageB.TabIndex = 6;
            this.btnpackageB.Text = "PURCHASE";
            this.btnpackageB.UseVisualStyleBackColor = false;
            this.btnpackageB.Click += new System.EventHandler(this.btnpackageB_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(147, 612);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "₱ 65,000.00";
            // 
            // lblDetailsPackage2
            // 
            this.lblDetailsPackage2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsPackage2.ForeColor = System.Drawing.Color.Black;
            this.lblDetailsPackage2.Location = new System.Drawing.Point(49, 254);
            this.lblDetailsPackage2.Name = "lblDetailsPackage2";
            this.lblDetailsPackage2.Size = new System.Drawing.Size(469, 353);
            this.lblDetailsPackage2.TabIndex = 2;
            this.lblDetailsPackage2.Text = resources.GetString("lblDetailsPackage2.Text");
            // 
            // lblPackage2
            // 
            this.lblPackage2.AutoSize = true;
            this.lblPackage2.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPackage2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackage2.ForeColor = System.Drawing.Color.White;
            this.lblPackage2.Location = new System.Drawing.Point(196, 12);
            this.lblPackage2.Name = "lblPackage2";
            this.lblPackage2.Size = new System.Drawing.Size(160, 29);
            this.lblPackage2.TabIndex = 0;
            this.lblPackage2.Text = "PACKAGE 2";
            this.lblPackage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPackage2
            // 
            this.pbPackage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPackage2.Image = global::FuneralManagementSystem.Properties.Resources.package2Image;
            this.pbPackage2.Location = new System.Drawing.Point(109, 44);
            this.pbPackage2.Name = "pbPackage2";
            this.pbPackage2.Size = new System.Drawing.Size(355, 179);
            this.pbPackage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPackage2.TabIndex = 1;
            this.pbPackage2.TabStop = false;
            // 
            // panelPackage1
            // 
            this.panelPackage1.BackColor = System.Drawing.Color.Gainsboro;
            this.panelPackage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPackage1.Controls.Add(this.lblDetailsPackage1);
            this.panelPackage1.Controls.Add(this.lblPackage1Title);
            this.panelPackage1.Controls.Add(this.btnOmsAvail);
            this.panelPackage1.Controls.Add(this.pbPackage1);
            this.panelPackage1.Controls.Add(this.lblPricePackage1);
            this.panelPackage1.Location = new System.Drawing.Point(20, 107);
            this.panelPackage1.Name = "panelPackage1";
            this.panelPackage1.Size = new System.Drawing.Size(552, 691);
            this.panelPackage1.TabIndex = 8;
            // 
            // lblDetailsPackage1
            // 
            this.lblDetailsPackage1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsPackage1.ForeColor = System.Drawing.Color.Black;
            this.lblDetailsPackage1.Location = new System.Drawing.Point(42, 254);
            this.lblDetailsPackage1.Name = "lblDetailsPackage1";
            this.lblDetailsPackage1.Size = new System.Drawing.Size(469, 326);
            this.lblDetailsPackage1.TabIndex = 2;
            this.lblDetailsPackage1.Text = resources.GetString("lblDetailsPackage1.Text");
            // 
            // lblPackage1Title
            // 
            this.lblPackage1Title.AutoSize = true;
            this.lblPackage1Title.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPackage1Title.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackage1Title.ForeColor = System.Drawing.Color.White;
            this.lblPackage1Title.Location = new System.Drawing.Point(196, 12);
            this.lblPackage1Title.Name = "lblPackage1Title";
            this.lblPackage1Title.Size = new System.Drawing.Size(157, 29);
            this.lblPackage1Title.TabIndex = 0;
            this.lblPackage1Title.Text = "PACKAGE 1";
            this.lblPackage1Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOmsAvail
            // 
            this.btnOmsAvail.BackColor = System.Drawing.Color.Gold;
            this.btnOmsAvail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOmsAvail.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOmsAvail.ForeColor = System.Drawing.Color.Black;
            this.btnOmsAvail.Location = new System.Drawing.Point(326, 612);
            this.btnOmsAvail.Name = "btnOmsAvail";
            this.btnOmsAvail.Size = new System.Drawing.Size(184, 39);
            this.btnOmsAvail.TabIndex = 4;
            this.btnOmsAvail.Text = "PURCHASE";
            this.btnOmsAvail.UseVisualStyleBackColor = false;
            this.btnOmsAvail.Click += new System.EventHandler(this.btnOmsAvail_Click_1);
            // 
            // pbPackage1
            // 
            this.pbPackage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPackage1.Image = global::FuneralManagementSystem.Properties.Resources.package1Image;
            this.pbPackage1.Location = new System.Drawing.Point(92, 55);
            this.pbPackage1.Name = "pbPackage1";
            this.pbPackage1.Size = new System.Drawing.Size(355, 179);
            this.pbPackage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPackage1.TabIndex = 1;
            this.pbPackage1.TabStop = false;
            // 
            // lblPricePackage1
            // 
            this.lblPricePackage1.AutoSize = true;
            this.lblPricePackage1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePackage1.ForeColor = System.Drawing.Color.Black;
            this.lblPricePackage1.Location = new System.Drawing.Point(154, 613);
            this.lblPricePackage1.Name = "lblPricePackage1";
            this.lblPricePackage1.Size = new System.Drawing.Size(167, 29);
            this.lblPricePackage1.TabIndex = 3;
            this.lblPricePackage1.Text = "₱ 45,000.00";
            // 
            // FrmPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1305, 857);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPackage1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmPackages";
            this.Text = "FrmPackages";
            this.Load += new System.EventHandler(this.FrmPackages_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPackage2)).EndInit();
            this.panelPackage1.ResumeLayout(false);
            this.panelPackage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPackage1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnpackageB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDetailsPackage2;
        private System.Windows.Forms.Label lblPackage2;
        private System.Windows.Forms.PictureBox pbPackage2;
        private System.Windows.Forms.Panel panelPackage1;
        private System.Windows.Forms.Label lblDetailsPackage1;
        private System.Windows.Forms.Label lblPackage1Title;
        private System.Windows.Forms.Button btnOmsAvail;
        private System.Windows.Forms.PictureBox pbPackage1;
        private System.Windows.Forms.Label lblPricePackage1;
    }
}