namespace FuneralManagementSystem
{
    partial class frmAvail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNextForm = new System.Windows.Forms.Button();
            this.btnPreviousForm = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelClientFormContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNextForm);
            this.panel1.Controls.Add(this.btnPreviousForm);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 64);
            this.panel1.TabIndex = 0;
            // 
            // btnNextForm
            // 
            this.btnNextForm.Location = new System.Drawing.Point(991, 25);
            this.btnNextForm.Name = "btnNextForm";
            this.btnNextForm.Size = new System.Drawing.Size(119, 23);
            this.btnNextForm.TabIndex = 1;
            this.btnNextForm.Text = "button2";
            this.btnNextForm.UseVisualStyleBackColor = true;
            this.btnNextForm.Click += new System.EventHandler(this.btnNextForm_Click);
            // 
            // btnPreviousForm
            // 
            this.btnPreviousForm.Location = new System.Drawing.Point(843, 22);
            this.btnPreviousForm.Name = "btnPreviousForm";
            this.btnPreviousForm.Size = new System.Drawing.Size(120, 27);
            this.btnPreviousForm.TabIndex = 0;
            this.btnPreviousForm.Text = "button1";
            this.btnPreviousForm.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 21);
            this.button4.TabIndex = 0;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panelClientFormContainer
            // 
            this.panelClientFormContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClientFormContainer.Location = new System.Drawing.Point(0, 71);
            this.panelClientFormContainer.Name = "panelClientFormContainer";
            this.panelClientFormContainer.Size = new System.Drawing.Size(1140, 572);
            this.panelClientFormContainer.TabIndex = 1;
            this.panelClientFormContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelClientFormContainer_Paint);
            // 
            // frmAvail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 643);
            this.Controls.Add(this.panelClientFormContainer);
            this.Controls.Add(this.panel1);
            this.Name = "frmAvail";
            this.Text = "frmAvail";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelClientFormContainer;
        private System.Windows.Forms.Button btnNextForm;
        private System.Windows.Forms.Button btnPreviousForm;
    }
}