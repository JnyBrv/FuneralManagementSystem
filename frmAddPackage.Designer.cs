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
            this.lblInclusions = new System.Windows.Forms.Label();
            this.btnPackage = new System.Windows.Forms.Button();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPackageId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.plPackage = new System.Windows.Forms.Panel();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.pbPackage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.plPackage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(604, 450);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(82, 29);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Price: ";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // txtInclusions
            // 
            this.txtInclusions.Location = new System.Drawing.Point(610, 147);
            this.txtInclusions.Multiline = true;
            this.txtInclusions.Name = "txtInclusions";
            this.txtInclusions.Size = new System.Drawing.Size(405, 237);
            this.txtInclusions.TabIndex = 15;
            this.txtInclusions.TextChanged += new System.EventHandler(this.txtInclusions_TextChanged);
            // 
            // lblInclusions
            // 
            this.lblInclusions.AutoSize = true;
            this.lblInclusions.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInclusions.Location = new System.Drawing.Point(606, 107);
            this.lblInclusions.Name = "lblInclusions";
            this.lblInclusions.Size = new System.Drawing.Size(172, 29);
            this.lblInclusions.TabIndex = 16;
            this.lblInclusions.Text = "Add Inclusions";
            // 
            // btnPackage
            // 
            this.btnPackage.BackColor = System.Drawing.Color.Gold;
            this.btnPackage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPackage.FlatAppearance.BorderSize = 0;
            this.btnPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPackage.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackage.Location = new System.Drawing.Point(680, 503);
            this.btnPackage.Name = "btnPackage";
            this.btnPackage.Size = new System.Drawing.Size(266, 41);
            this.btnPackage.TabIndex = 17;
            this.btnPackage.Text = "Add";
            this.btnPackage.UseVisualStyleBackColor = false;
            this.btnPackage.Click += new System.EventHandler(this.btnPackage_Click);
            // 
            // txtPackageName
            // 
            this.txtPackageName.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageName.Location = new System.Drawing.Point(101, 448);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(413, 35);
            this.txtPackageName.TabIndex = 18;
            this.txtPackageName.TextChanged += new System.EventHandler(this.txtPackageName_TextChanged);
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(674, 446);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(33, 32);
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
            this.label2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Package Name";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(711, 450);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(215, 35);
            this.txtPrice.TabIndex = 22;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1305, 81);
            this.panel2.TabIndex = 25;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FuneralManagementSystem.Properties.Resources.packageIcon;
            this.pictureBox3.Location = new System.Drawing.Point(20, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(101, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 43);
            this.label3.TabIndex = 0;
            this.label3.Text = "ADD PACKAGE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Upload Image";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.plPackage);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 775);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // plPackage
            // 
            this.plPackage.BackColor = System.Drawing.SystemColors.Control;
            this.plPackage.Controls.Add(this.btnAddPicture);
            this.plPackage.Controls.Add(this.txtPrice);
            this.plPackage.Controls.Add(this.label1);
            this.plPackage.Controls.Add(this.btnPackage);
            this.plPackage.Controls.Add(this.pbPackage);
            this.plPackage.Controls.Add(this.lblInclusions);
            this.plPackage.Controls.Add(this.label2);
            this.plPackage.Controls.Add(this.lblCurrency);
            this.plPackage.Controls.Add(this.txtPackageName);
            this.plPackage.Controls.Add(this.lblPrice);
            this.plPackage.Controls.Add(this.txtInclusions);
            this.plPackage.Location = new System.Drawing.Point(100, 106);
            this.plPackage.Name = "plPackage";
            this.plPackage.Size = new System.Drawing.Size(1122, 619);
            this.plPackage.TabIndex = 25;
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddPicture.FlatAppearance.BorderSize = 0;
            this.btnAddPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPicture.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddPicture.Image = global::FuneralManagementSystem.Properties.Resources.uploadEdit;
            this.btnAddPicture.Location = new System.Drawing.Point(475, 131);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(39, 41);
            this.btnAddPicture.TabIndex = 19;
            this.btnAddPicture.UseVisualStyleBackColor = false;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // pbPackage
            // 
            this.pbPackage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbPackage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPackage.Image = global::FuneralManagementSystem.Properties.Resources.cloudUploadBlack;
            this.pbPackage.Location = new System.Drawing.Point(101, 131);
            this.pbPackage.Name = "pbPackage";
            this.pbPackage.Size = new System.Drawing.Size(416, 253);
            this.pbPackage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPackage.TabIndex = 13;
            this.pbPackage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FuneralManagementSystem.Properties.Resources.goldEdge1;
            this.pictureBox1.Location = new System.Drawing.Point(11, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FuneralManagementSystem.Properties.Resources.goldEdge2;
            this.pictureBox2.Location = new System.Drawing.Point(1054, 10);
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
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1305, 857);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmAddPackage";
            this.Text = "/";
            this.Load += new System.EventHandler(this.frmAddPackage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.plPackage.ResumeLayout(false);
            this.plPackage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPackage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel plPackage;
    }
}