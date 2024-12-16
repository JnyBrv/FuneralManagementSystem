namespace FuneralManagementSystem
{
    partial class frmBilling
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridPaying = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMonths = new System.Windows.Forms.ComboBox();
            this.rbInstallment = new System.Windows.Forms.RadioButton();
            this.rbFullPayment = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPaying)).BeginInit();
            this.pnlPreview.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.dataGridPaying);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Controls.Add(this.pnlPreview);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1085, 635);
            this.panel4.TabIndex = 11;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // dataGridPaying
            // 
            this.dataGridPaying.AllowUserToAddRows = false;
            this.dataGridPaying.AllowUserToDeleteRows = false;
            this.dataGridPaying.BackgroundColor = System.Drawing.Color.White;
            this.dataGridPaying.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPaying.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPaying.GridColor = System.Drawing.Color.DimGray;
            this.dataGridPaying.Location = new System.Drawing.Point(23, 168);
            this.dataGridPaying.Name = "dataGridPaying";
            this.dataGridPaying.ReadOnly = true;
            this.dataGridPaying.RowHeadersWidth = 51;
            this.dataGridPaying.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPaying.Size = new System.Drawing.Size(793, 455);
            this.dataGridPaying.TabIndex = 21;
            this.dataGridPaying.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPaying_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gold;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Georgia", 13F);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(647, 112);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(169, 33);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(23, 113);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(608, 30);
            this.txtSearch.TabIndex = 26;
            // 
            // pnlPreview
            // 
            this.pnlPreview.Controls.Add(this.btnGenerate);
            this.pnlPreview.Controls.Add(this.txtYears);
            this.pnlPreview.Controls.Add(this.label6);
            this.pnlPreview.Controls.Add(this.label5);
            this.pnlPreview.Controls.Add(this.cbMonths);
            this.pnlPreview.Controls.Add(this.rbInstallment);
            this.pnlPreview.Controls.Add(this.rbFullPayment);
            this.pnlPreview.Controls.Add(this.label2);
            this.pnlPreview.Controls.Add(this.label1);
            this.pnlPreview.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPreview.Location = new System.Drawing.Point(828, 86);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(257, 549);
            this.pnlPreview.TabIndex = 25;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(170, 312);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(88, 312);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(60, 20);
            this.txtYears.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Years";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Months";
            // 
            // cbMonths
            // 
            this.cbMonths.FormattingEnabled = true;
            this.cbMonths.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbMonths.Location = new System.Drawing.Point(23, 312);
            this.cbMonths.Name = "cbMonths";
            this.cbMonths.Size = new System.Drawing.Size(59, 21);
            this.cbMonths.TabIndex = 3;
            // 
            // rbInstallment
            // 
            this.rbInstallment.AutoSize = true;
            this.rbInstallment.Location = new System.Drawing.Point(132, 252);
            this.rbInstallment.Name = "rbInstallment";
            this.rbInstallment.Size = new System.Drawing.Size(97, 17);
            this.rbInstallment.TabIndex = 2;
            this.rbInstallment.TabStop = true;
            this.rbInstallment.Text = "Down Payment";
            this.rbInstallment.UseVisualStyleBackColor = true;
            // 
            // rbFullPayment
            // 
            this.rbFullPayment.AutoSize = true;
            this.rbFullPayment.Location = new System.Drawing.Point(26, 252);
            this.rbFullPayment.Name = "rbFullPayment";
            this.rbFullPayment.Size = new System.Drawing.Size(85, 17);
            this.rbFullPayment.TabIndex = 1;
            this.rbFullPayment.TabStop = true;
            this.rbFullPayment.Text = "Full Payment";
            this.rbFullPayment.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Package:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1085, 86);
            this.panel2.TabIndex = 24;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::FuneralManagementSystem.Properties.Resources.clientIcon;
            this.pictureBox3.Location = new System.Drawing.Point(42, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(112, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 43);
            this.label3.TabIndex = 21;
            this.label3.Text = "CLIENTS";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(283, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Paying";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.Image = global::FuneralManagementSystem.Properties.Resources.clientIcon;
            this.pictureBox5.Location = new System.Drawing.Point(-90, 16);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 57);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // frmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 635);
            this.Controls.Add(this.panel4);
            this.Name = "frmBilling";
            this.Text = "frmBilling";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPaying)).EndInit();
            this.pnlPreview.ResumeLayout(false);
            this.pnlPreview.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridPaying;
        private System.Windows.Forms.RadioButton rbFullPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMonths;
        private System.Windows.Forms.RadioButton rbInstallment;
    }
}