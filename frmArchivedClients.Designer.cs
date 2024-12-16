namespace FuneralManagementSystem
{
    partial class frmArchivedClients
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.btnCompleteService = new System.Windows.Forms.Button();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblDeceased = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picPackage = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDSearch = new System.Windows.Forms.TextBox();
            this.dataGridDeleted = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCSearch = new System.Windows.Forms.Button();
            this.txtCSearch = new System.Windows.Forms.TextBox();
            this.dataGridCompleted = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPackage)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeleted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompleted)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1305, 81);
            this.panel3.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(101, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(393, 43);
            this.label9.TabIndex = 18;
            this.label9.Text = "ARCHIVE CLIENTS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::FuneralManagementSystem.Properties.Resources.clientIcon;
            this.pictureBox2.Location = new System.Drawing.Point(20, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pnlPreview
            // 
            this.pnlPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlPreview.Controls.Add(this.btnCompleteService);
            this.pnlPreview.Controls.Add(this.lblPlace);
            this.pnlPreview.Controls.Add(this.lblDate);
            this.pnlPreview.Controls.Add(this.lblContact);
            this.pnlPreview.Controls.Add(this.lblDeceased);
            this.pnlPreview.Controls.Add(this.lblClient);
            this.pnlPreview.Controls.Add(this.btnUpdate);
            this.pnlPreview.Controls.Add(this.label12);
            this.pnlPreview.Controls.Add(this.label11);
            this.pnlPreview.Controls.Add(this.label10);
            this.pnlPreview.Controls.Add(this.label1);
            this.pnlPreview.Controls.Add(this.picPackage);
            this.pnlPreview.Controls.Add(this.label8);
            this.pnlPreview.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPreview.Location = new System.Drawing.Point(971, 81);
            this.pnlPreview.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(334, 776);
            this.pnlPreview.TabIndex = 8;
            // 
            // btnCompleteService
            // 
            this.btnCompleteService.BackColor = System.Drawing.Color.Gold;
            this.btnCompleteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteService.Font = new System.Drawing.Font("Georgia", 13F);
            this.btnCompleteService.ForeColor = System.Drawing.Color.Black;
            this.btnCompleteService.Location = new System.Drawing.Point(34, 646);
            this.btnCompleteService.Name = "btnCompleteService";
            this.btnCompleteService.Size = new System.Drawing.Size(273, 33);
            this.btnCompleteService.TabIndex = 27;
            this.btnCompleteService.Text = "Restore (Active Client)";
            this.btnCompleteService.UseVisualStyleBackColor = false;
            this.btnCompleteService.Click += new System.EventHandler(this.btnCompleteService_Click);
            // 
            // lblPlace
            // 
            this.lblPlace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPlace.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.Location = new System.Drawing.Point(31, 513);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(277, 50);
            this.lblPlace.TabIndex = 25;
            this.lblPlace.Text = "ABC";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDate.Font = new System.Drawing.Font("Arial", 13F);
            this.lblDate.Location = new System.Drawing.Point(31, 453);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(277, 24);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "ABC";
            // 
            // lblContact
            // 
            this.lblContact.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblContact.Font = new System.Drawing.Font("Arial", 13F);
            this.lblContact.Location = new System.Drawing.Point(31, 392);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(269, 24);
            this.lblContact.TabIndex = 23;
            this.lblContact.Text = "ABC";
            // 
            // lblDeceased
            // 
            this.lblDeceased.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDeceased.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeceased.Location = new System.Drawing.Point(31, 332);
            this.lblDeceased.Name = "lblDeceased";
            this.lblDeceased.Size = new System.Drawing.Size(269, 24);
            this.lblDeceased.TabIndex = 22;
            this.lblDeceased.Text = "ABC";
            // 
            // lblClient
            // 
            this.lblClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblClient.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(31, 270);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(269, 24);
            this.lblClient.TabIndex = 21;
            this.lblClient.Text = "ABC";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gold;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Georgia", 13F);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(34, 584);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(273, 33);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 425);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 23);
            this.label12.TabIndex = 6;
            this.label12.Text = "Date of Internment:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 485);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 23);
            this.label11.TabIndex = 5;
            this.label11.Text = "Place of Internment:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Contact Number:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Decedent Name:";
            // 
            // picPackage
            // 
            this.picPackage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picPackage.Location = new System.Drawing.Point(33, 38);
            this.picPackage.Name = "picPackage";
            this.picPackage.Size = new System.Drawing.Size(267, 184);
            this.picPackage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPackage.TabIndex = 0;
            this.picPackage.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Client Name:";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoScroll = true;
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnDSearch);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtDSearch);
            this.panel4.Controls.Add(this.dataGridDeleted);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnCSearch);
            this.panel4.Controls.Add(this.txtCSearch);
            this.panel4.Controls.Add(this.dataGridCompleted);
            this.panel4.Location = new System.Drawing.Point(0, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(965, 776);
            this.panel4.TabIndex = 9;
            // 
            // btnDSearch
            // 
            this.btnDSearch.BackColor = System.Drawing.Color.Gold;
            this.btnDSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSearch.Font = new System.Drawing.Font("Georgia", 13F);
            this.btnDSearch.ForeColor = System.Drawing.Color.Black;
            this.btnDSearch.Location = new System.Drawing.Point(752, 386);
            this.btnDSearch.Name = "btnDSearch";
            this.btnDSearch.Size = new System.Drawing.Size(169, 33);
            this.btnDSearch.TabIndex = 24;
            this.btnDSearch.Text = "Search";
            this.btnDSearch.UseVisualStyleBackColor = false;
            this.btnDSearch.Click += new System.EventHandler(this.btnDSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 20F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(34, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "DELETED CLIENTS";
            // 
            // txtDSearch
            // 
            this.txtDSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDSearch.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDSearch.Location = new System.Drawing.Point(40, 388);
            this.txtDSearch.Name = "txtDSearch";
            this.txtDSearch.Size = new System.Drawing.Size(662, 30);
            this.txtDSearch.TabIndex = 22;
            this.txtDSearch.TextChanged += new System.EventHandler(this.txtDSearch_TextChanged);
            // 
            // dataGridDeleted
            // 
            this.dataGridDeleted.AllowUserToAddRows = false;
            this.dataGridDeleted.AllowUserToDeleteRows = false;
            this.dataGridDeleted.BackgroundColor = System.Drawing.Color.White;
            this.dataGridDeleted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDeleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDeleted.GridColor = System.Drawing.Color.DimGray;
            this.dataGridDeleted.Location = new System.Drawing.Point(40, 426);
            this.dataGridDeleted.Name = "dataGridDeleted";
            this.dataGridDeleted.ReadOnly = true;
            this.dataGridDeleted.RowHeadersWidth = 51;
            this.dataGridDeleted.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDeleted.Size = new System.Drawing.Size(880, 240);
            this.dataGridDeleted.TabIndex = 21;
            this.dataGridDeleted.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDeleted_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 20F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "COMPLETED TRANSACTIONS";
            // 
            // btnCSearch
            // 
            this.btnCSearch.BackColor = System.Drawing.Color.Gold;
            this.btnCSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCSearch.Font = new System.Drawing.Font("Georgia", 13F);
            this.btnCSearch.ForeColor = System.Drawing.Color.Black;
            this.btnCSearch.Location = new System.Drawing.Point(752, 54);
            this.btnCSearch.Name = "btnCSearch";
            this.btnCSearch.Size = new System.Drawing.Size(169, 33);
            this.btnCSearch.TabIndex = 19;
            this.btnCSearch.Text = "Search";
            this.btnCSearch.UseVisualStyleBackColor = false;
            this.btnCSearch.Click += new System.EventHandler(this.btnCSearch_Click);
            // 
            // txtCSearch
            // 
            this.txtCSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCSearch.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCSearch.Location = new System.Drawing.Point(40, 56);
            this.txtCSearch.Name = "txtCSearch";
            this.txtCSearch.Size = new System.Drawing.Size(662, 30);
            this.txtCSearch.TabIndex = 4;
            this.txtCSearch.TextChanged += new System.EventHandler(this.txtCSearch_TextChanged);
            // 
            // dataGridCompleted
            // 
            this.dataGridCompleted.AllowUserToAddRows = false;
            this.dataGridCompleted.AllowUserToDeleteRows = false;
            this.dataGridCompleted.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCompleted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCompleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCompleted.GridColor = System.Drawing.Color.DimGray;
            this.dataGridCompleted.Location = new System.Drawing.Point(40, 94);
            this.dataGridCompleted.Name = "dataGridCompleted";
            this.dataGridCompleted.ReadOnly = true;
            this.dataGridCompleted.RowHeadersWidth = 51;
            this.dataGridCompleted.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCompleted.Size = new System.Drawing.Size(880, 240);
            this.dataGridCompleted.TabIndex = 0;
            this.dataGridCompleted.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCompleted_CellClick);
            // 
            // frmArchivedClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1305, 857);
            this.Controls.Add(this.pnlPreview);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "frmArchivedClients";
            this.Text = "frmArchivedClients";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlPreview.ResumeLayout(false);
            this.pnlPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPackage)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeleted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompleted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.Button btnCompleteService;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblDeceased;
        private System.Windows.Forms.Label lblClient;
        public System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picPackage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDSearch;
        private System.Windows.Forms.DataGridView dataGridDeleted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCSearch;
        private System.Windows.Forms.TextBox txtCSearch;
        private System.Windows.Forms.DataGridView dataGridCompleted;
    }
}