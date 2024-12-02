namespace FuneralManagementSystem
{
    partial class System_Arragement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(System_Arragement));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnPanelControler = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelMainMenu = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnPackages = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.PanelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.PanelMenu.Controls.Add(this.btnEmployees);
            this.PanelMenu.Controls.Add(this.btnClients);
            this.PanelMenu.Controls.Add(this.btnPackages);
            this.PanelMenu.Controls.Add(this.btnPanelControler);
            this.PanelMenu.Controls.Add(this.panelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(230, 578);
            this.PanelMenu.TabIndex = 1;
            // 
            // btnPanelControler
            // 
            this.btnPanelControler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPanelControler.FlatAppearance.BorderSize = 0;
            this.btnPanelControler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelControler.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPanelControler.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnPanelControler.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(203)))), ((int)(((byte)(150)))));
            this.btnPanelControler.IconSize = 20;
            this.btnPanelControler.Location = new System.Drawing.Point(0, 165);
            this.btnPanelControler.Name = "btnPanelControler";
            this.btnPanelControler.Rotation = 0D;
            this.btnPanelControler.Size = new System.Drawing.Size(230, 29);
            this.btnPanelControler.TabIndex = 4;
            this.btnPanelControler.Text = "/";
            this.btnPanelControler.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(230, 165);
            this.panelLogo.TabIndex = 2;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.ImageLocation = "";
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(230, 165);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Logo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cruz\r\nFuneral Service\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(203)))), ((int)(((byte)(150)))));
            this.TopPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopPanel.BackgroundImage")));
            this.TopPanel.Controls.Add(this.btnExit);
            this.TopPanel.Controls.Add(this.panel1);
            this.TopPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1128, 85);
            this.TopPanel.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(1049, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(795, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 184);
            this.panel1.TabIndex = 0;
            // 
            // PanelMainMenu
            // 
            this.PanelMainMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelMainMenu.AutoSize = true;
            this.PanelMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.PanelMainMenu.Location = new System.Drawing.Point(224, 84);
            this.PanelMainMenu.Name = "PanelMainMenu";
            this.PanelMainMenu.Size = new System.Drawing.Size(903, 494);
            this.PanelMainMenu.TabIndex = 4;
            this.PanelMainMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMainMenu_Paint);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnPackages
            // 
            this.btnPackages.Location = new System.Drawing.Point(0, 231);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(230, 42);
            this.btnPackages.TabIndex = 5;
            this.btnPackages.Text = "Packages";
            this.btnPackages.UseVisualStyleBackColor = true;
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(0, 320);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(230, 42);
            this.btnClients.TabIndex = 5;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(0, 403);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(230, 42);
            this.btnEmployees.TabIndex = 5;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            // 
            // System_Arragement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 578);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.PanelMainMenu);
            this.Name = "System_Arragement";
            this.Text = "System_Arragement";
            this.Load += new System.EventHandler(this.System_Arragement_Load);
            this.PanelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel PanelMainMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private FontAwesome.Sharp.IconButton btnPanelControler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnPackages;
    }
}