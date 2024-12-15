namespace FuneralManagementSystem
{
    partial class frmAddPackage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPackage));
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtInclusions = new System.Windows.Forms.TextBox();
            this.lblInclusions = new System.Windows.Forms.Label();
            this.btnPackage = new System.Windows.Forms.Button();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPackageId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.pbPackage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(50, 638);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(68, 24);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Price: ";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // txtInclusions
            // 
            this.txtInclusions.Location = new System.Drawing.Point(52, 383);
            this.txtInclusions.Multiline = true;
            this.txtInclusions.Name = "txtInclusions";
            this.txtInclusions.Size = new System.Drawing.Size(405, 237);
            this.txtInclusions.TabIndex = 15;
            this.txtInclusions.TextChanged += new System.EventHandler(this.txtInclusions_TextChanged);
            // 
            // lblInclusions
            // 
            this.lblInclusions.AutoSize = true;
            this.lblInclusions.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInclusions.Location = new System.Drawing.Point(51, 361);
            this.lblInclusions.Name = "lblInclusions";
            this.lblInclusions.Size = new System.Drawing.Size(110, 19);
            this.lblInclusions.TabIndex = 16;
            this.lblInclusions.Text = "Add Inclusions";
            // 
            // btnPackage
            // 
            this.btnPackage.BackColor = System.Drawing.Color.Gold;
            this.btnPackage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPackage.FlatAppearance.BorderSize = 0;
            this.btnPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPackage.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackage.Location = new System.Drawing.Point(339, 634);
            this.btnPackage.Name = "btnPackage";
            this.btnPackage.Size = new System.Drawing.Size(118, 28);
            this.btnPackage.TabIndex = 17;
            this.btnPackage.Text = "Add";
            this.btnPackage.UseVisualStyleBackColor = false;
            this.btnPackage.Click += new System.EventHandler(this.btnPackage_Click);
            // 
            // txtPackageName
            // 
            this.txtPackageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageName.Location = new System.Drawing.Point(55, 304);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(206, 30);
            this.txtPackageName.TabIndex = 18;
            this.txtPackageName.TextChanged += new System.EventHandler(this.txtPackageName_TextChanged);
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(123, 636);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(27, 25);
            this.lblCurrency.TabIndex = 16;
            this.lblCurrency.Text = "₱";
            this.lblCurrency.Click += new System.EventHandler(this.lblCurrency_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Package ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPackageId
            // 
            this.txtPackageId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageId.Location = new System.Drawing.Point(281, 306);
            this.txtPackageId.Multiline = true;
            this.txtPackageId.Name = "txtPackageId";
            this.txtPackageId.Size = new System.Drawing.Size(176, 28);
            this.txtPackageId.TabIndex = 21;
            this.txtPackageId.Text = "Auto Generated PackageId";
            this.txtPackageId.TextChanged += new System.EventHandler(this.txtPackageId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Package Name";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(156, 635);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(173, 30);
            this.txtPrice.TabIndex = 22;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged_1);
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddPicture.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPicture.Image")));
            this.btnAddPicture.Location = new System.Drawing.Point(418, 56);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(39, 41);
            this.btnAddPicture.TabIndex = 19;
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // pbPackage
            // 
            this.pbPackage.BackColor = System.Drawing.Color.White;
            this.pbPackage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPackage.Image = global::FuneralManagementSystem.Properties.Resources.inputimage;
            this.pbPackage.Location = new System.Drawing.Point(55, 56);
            this.pbPackage.Name = "pbPackage";
            this.pbPackage.Size = new System.Drawing.Size(402, 196);
            this.pbPackage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPackage.TabIndex = 13;
            this.pbPackage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FuneralManagementSystem.Properties.Resources.goldEdge1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::FuneralManagementSystem.Properties.Resources.goldEdge2;
            this.pictureBox2.Location = new System.Drawing.Point(268, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(239, 252);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // frmAddPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(507, 679);
            this.Controls.Add(this.btnAddPicture);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtPackageId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPackageName);
            this.Controls.Add(this.btnPackage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInclusions);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtInclusions);
            this.Controls.Add(this.pbPackage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmAddPackage";
            this.Text = "/";
            this.Load += new System.EventHandler(this.frmAddPackage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPackage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtInclusions;
        private System.Windows.Forms.PictureBox pbPackage;
        private System.Windows.Forms.Label lblInclusions;
        private System.Windows.Forms.Button btnPackage;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPackageId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}