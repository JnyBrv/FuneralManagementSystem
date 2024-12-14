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
            this.pbPackage1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPackage1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPackageName.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageName.ForeColor = System.Drawing.Color.White;
            this.lblPackageName.Location = new System.Drawing.Point(245, 50);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(114, 29);
            this.lblPackageName.TabIndex = 5;
            this.lblPackageName.Text = "Pacakge";
            this.lblPackageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOmsAvail
            // 
            this.btnOmsAvail.BackColor = System.Drawing.Color.Gold;
            this.btnOmsAvail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOmsAvail.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOmsAvail.ForeColor = System.Drawing.Color.Black;
            this.btnOmsAvail.Location = new System.Drawing.Point(368, 633);
            this.btnOmsAvail.Name = "btnOmsAvail";
            this.btnOmsAvail.Size = new System.Drawing.Size(115, 39);
            this.btnOmsAvail.TabIndex = 9;
            this.btnOmsAvail.Text = "Avail +";
            this.btnOmsAvail.UseVisualStyleBackColor = false;
            this.btnOmsAvail.Click += new System.EventHandler(this.btnOmsAvail_Click);
            // 
            // txtInclusions
            // 
            this.txtInclusions.Location = new System.Drawing.Point(116, 302);
            this.txtInclusions.Multiline = true;
            this.txtInclusions.Name = "txtInclusions";
            this.txtInclusions.Size = new System.Drawing.Size(367, 280);
            this.txtInclusions.TabIndex = 10;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(256, 639);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 25);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Price";
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
            // Package
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtInclusions);
            this.Controls.Add(this.lblPackageName);
            this.Controls.Add(this.btnOmsAvail);
            this.Controls.Add(this.pbPackage1);
            this.Name = "Package";
            this.Size = new System.Drawing.Size(627, 721);
            ((System.ComponentModel.ISupportInitialize)(this.pbPackage1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPackageName;
        private System.Windows.Forms.Button btnOmsAvail;
        private System.Windows.Forms.PictureBox pbPackage1;
        private System.Windows.Forms.TextBox txtInclusions;
        private System.Windows.Forms.Label lblPrice;
    }
}
