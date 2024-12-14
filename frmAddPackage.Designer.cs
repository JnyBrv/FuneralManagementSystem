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
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtInclusions = new System.Windows.Forms.TextBox();
            this.pbPackage = new System.Windows.Forms.PictureBox();
            this.lblInclusions = new System.Windows.Forms.Label();
            this.btnPackage = new System.Windows.Forms.Button();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPackageId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPackage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(19, 624);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 25);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Price";
            // 
            // txtInclusions
            // 
            this.txtInclusions.Location = new System.Drawing.Point(24, 358);
            this.txtInclusions.Multiline = true;
            this.txtInclusions.Name = "txtInclusions";
            this.txtInclusions.Size = new System.Drawing.Size(355, 249);
            this.txtInclusions.TabIndex = 15;
            // 
            // pbPackage
            // 
            this.pbPackage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPackage.Image = global::FuneralManagementSystem.Properties.Resources.packageIcon;
            this.pbPackage.Location = new System.Drawing.Point(24, 55);
            this.pbPackage.Name = "pbPackage";
            this.pbPackage.Size = new System.Drawing.Size(355, 179);
            this.pbPackage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPackage.TabIndex = 13;
            this.pbPackage.TabStop = false;
            // 
            // lblInclusions
            // 
            this.lblInclusions.AutoSize = true;
            this.lblInclusions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInclusions.Location = new System.Drawing.Point(19, 330);
            this.lblInclusions.Name = "lblInclusions";
            this.lblInclusions.Size = new System.Drawing.Size(140, 25);
            this.lblInclusions.TabIndex = 16;
            this.lblInclusions.Text = "Add Inclusions";
            // 
            // btnPackage
            // 
            this.btnPackage.Location = new System.Drawing.Point(161, 675);
            this.btnPackage.Name = "btnPackage";
            this.btnPackage.Size = new System.Drawing.Size(75, 23);
            this.btnPackage.TabIndex = 17;
            this.btnPackage.Text = "Add";
            this.btnPackage.UseVisualStyleBackColor = true;
            this.btnPackage.Click += new System.EventHandler(this.btnPackage_Click);
            // 
            // txtPackageName
            // 
            this.txtPackageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageName.Location = new System.Drawing.Point(143, 273);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(224, 30);
            this.txtPackageName.TabIndex = 18;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(98, 624);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(25, 25);
            this.lblCurrency.TabIndex = 16;
            this.lblCurrency.Text = "₱";
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(343, 55);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(36, 23);
            this.btnAddPicture.TabIndex = 19;
            this.btnAddPicture.Text = "+";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "PackageID:";
            // 
            // txtPackageId
            // 
            this.txtPackageId.Location = new System.Drawing.Point(91, 240);
            this.txtPackageId.Name = "txtPackageId";
            this.txtPackageId.Size = new System.Drawing.Size(145, 20);
            this.txtPackageId.TabIndex = 21;
            this.txtPackageId.Text = "Auto Generated PackageId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Package Name";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(161, 628);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(218, 20);
            this.txtPrice.TabIndex = 22;
            // 
            // frmAddPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(407, 704);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtPackageId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPicture);
            this.Controls.Add(this.txtPackageName);
            this.Controls.Add(this.btnPackage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInclusions);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtInclusions);
            this.Controls.Add(this.pbPackage);
            this.Name = "frmAddPackage";
            this.Text = "/";
            ((System.ComponentModel.ISupportInitialize)(this.pbPackage)).EndInit();
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
    }
}