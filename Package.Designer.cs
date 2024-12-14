namespace FuneralManagementSystem
{
    partial class Package
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPackageName = new System.Windows.Forms.Label();
            this.btnOmsAvail = new System.Windows.Forms.Button();
            this.txtInclusions = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.pbPackage1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPackage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.BackColor = System.Drawing.Color.Transparent;
            this.lblPackageName.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageName.ForeColor = System.Drawing.Color.Black;
            this.lblPackageName.Location = new System.Drawing.Point(237, 45);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(121, 32);
            this.lblPackageName.TabIndex = 5;
            this.lblPackageName.Text = "Pacakge";
            this.lblPackageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOmsAvail
            // 
            this.btnOmsAvail.BackColor = System.Drawing.Color.Gold;
            this.btnOmsAvail.FlatAppearance.BorderSize = 0;
            this.btnOmsAvail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOmsAvail.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOmsAvail.ForeColor = System.Drawing.Color.Black;
            this.btnOmsAvail.Location = new System.Drawing.Point(409, 633);
            this.btnOmsAvail.Name = "btnOmsAvail";
            this.btnOmsAvail.Size = new System.Drawing.Size(115, 39);
            this.btnOmsAvail.TabIndex = 9;
            this.btnOmsAvail.Text = "Avail  ▶";
            this.btnOmsAvail.UseVisualStyleBackColor = false;
            this.btnOmsAvail.Click += new System.EventHandler(this.btnOmsAvail_Click);
            // 
            // txtInclusions
            // 
            this.txtInclusions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtInclusions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInclusions.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInclusions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtInclusions.Location = new System.Drawing.Point(116, 302);
            this.txtInclusions.Multiline = true;
            this.txtInclusions.Name = "txtInclusions";
            this.txtInclusions.Size = new System.Drawing.Size(367, 280);
            this.txtInclusions.TabIndex = 10;
            this.txtInclusions.TextChanged += new System.EventHandler(this.txtInclusions_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(283, 639);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 25);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Price";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblPrice2
            // 
            this.lblPrice2.AutoSize = true;
            this.lblPrice2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice2.Location = new System.Drawing.Point(171, 639);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(106, 25);
            this.lblPrice2.TabIndex = 12;
            this.lblPrice2.Text = "Price:   ₱";
            this.lblPrice2.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbPackage1
            // 
            this.pbPackage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPackage1.Image = global::FuneralManagementSystem.Properties.Resources.package1Image;
            this.pbPackage1.Location = new System.Drawing.Point(128, 95);
            this.pbPackage1.Name = "pbPackage1";
            this.pbPackage1.Size = new System.Drawing.Size(355, 179);
            this.pbPackage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPackage1.TabIndex = 6;
            this.pbPackage1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FuneralManagementSystem.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(476, -38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Package
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblPrice2);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtInclusions);
            this.Controls.Add(this.lblPackageName);
            this.Controls.Add(this.btnOmsAvail);
            this.Controls.Add(this.pbPackage1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Package";
            this.Size = new System.Drawing.Size(627, 721);
            this.Load += new System.EventHandler(this.Package_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPackage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPackageName;
        private System.Windows.Forms.Button btnOmsAvail;
        private System.Windows.Forms.PictureBox pbPackage1;
        private System.Windows.Forms.TextBox txtInclusions;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPrice2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
