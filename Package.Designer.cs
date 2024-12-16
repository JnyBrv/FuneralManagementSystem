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
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.txtInclusions = new System.Windows.Forms.RichTextBox();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPackageName
            // 
            this.lblPackageName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.BackColor = System.Drawing.Color.Transparent;
            this.lblPackageName.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageName.ForeColor = System.Drawing.Color.Black;
            this.lblPackageName.Location = new System.Drawing.Point(175, 62);
            this.lblPackageName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(148, 40);
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
            this.btnOmsAvail.Location = new System.Drawing.Point(355, 753);
            this.btnOmsAvail.Margin = new System.Windows.Forms.Padding(4);
            this.btnOmsAvail.Name = "btnOmsAvail";
            this.btnOmsAvail.Size = new System.Drawing.Size(146, 48);
            this.btnOmsAvail.TabIndex = 9;
            this.btnOmsAvail.Text = "Avail  ▶";
            this.btnOmsAvail.UseVisualStyleBackColor = false;
            this.btnOmsAvail.Click += new System.EventHandler(this.btnOmsAvail_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(167, 768);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(71, 29);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Price";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblPrice2
            // 
            this.lblPrice2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice2.AutoSize = true;
            this.lblPrice2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice2.ForeColor = System.Drawing.Color.Black;
            this.lblPrice2.Location = new System.Drawing.Point(23, 766);
            this.lblPrice2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(136, 31);
            this.lblPrice2.TabIndex = 12;
            this.lblPrice2.Text = "Price:   ₱";
            this.lblPrice2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtInclusions
            // 
            this.txtInclusions.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInclusions.Location = new System.Drawing.Point(29, 361);
            this.txtInclusions.Name = "txtInclusions";
            this.txtInclusions.Size = new System.Drawing.Size(472, 376);
            this.txtInclusions.TabIndex = 15;
            this.txtInclusions.Text = "";
            // 
            // pbImg
            // 
            this.pbImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImg.Image = global::FuneralManagementSystem.Properties.Resources.package1Image;
            this.pbImg.Location = new System.Drawing.Point(29, 123);
            this.pbImg.Margin = new System.Windows.Forms.Padding(4);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(472, 219);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg.TabIndex = 6;
            this.pbImg.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FuneralManagementSystem.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(355, -28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gold;
            this.btnDelete.Image = global::FuneralManagementSystem.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(463, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 50);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 16;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(-3, 808);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            // 
            // Package
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtInclusions);
            this.Controls.Add(this.lblPrice2);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPackageName);
            this.Controls.Add(this.btnOmsAvail);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Package";
            this.Padding = new System.Windows.Forms.Padding(67, 62, 67, 62);
            this.Size = new System.Drawing.Size(541, 825);
            this.Load += new System.EventHandler(this.Package_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPackageName;
        private System.Windows.Forms.Button btnOmsAvail;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPrice2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox txtInclusions;
        private System.Windows.Forms.PictureBox btnDelete;
        public System.Windows.Forms.Label label1;
    }
}
