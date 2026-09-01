namespace DVLD
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            applicatinonToolStripMenuItem = new ToolStripMenuItem();
            peopleToolStripMenuItem = new ToolStripMenuItem();
            driversToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            acountSettingsToolStripMenuItem = new ToolStripMenuItem();
            currentUserInfoToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.Navy;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Font = new Font("Segoe UI", 10F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { applicatinonToolStripMenuItem, peopleToolStripMenuItem, driversToolStripMenuItem, usersToolStripMenuItem, acountSettingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(226, 642);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // applicatinonToolStripMenuItem
            // 
            applicatinonToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            applicatinonToolStripMenuItem.ForeColor = SystemColors.AppWorkspace;
            applicatinonToolStripMenuItem.Image = (Image)resources.GetObject("applicatinonToolStripMenuItem.Image");
            applicatinonToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            applicatinonToolStripMenuItem.ImageTransparentColor = Color.Transparent;
            applicatinonToolStripMenuItem.Name = "applicatinonToolStripMenuItem";
            applicatinonToolStripMenuItem.Size = new Size(219, 68);
            applicatinonToolStripMenuItem.Text = "Applications";
            applicatinonToolStripMenuItem.TextDirection = ToolStripTextDirection.Horizontal;
            applicatinonToolStripMenuItem.Click += applicatinonToolStripMenuItem_Click;
            // 
            // peopleToolStripMenuItem
            // 
            peopleToolStripMenuItem.AutoSize = false;
            peopleToolStripMenuItem.ForeColor = SystemColors.AppWorkspace;
            peopleToolStripMenuItem.Image = (Image)resources.GetObject("peopleToolStripMenuItem.Image");
            peopleToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            peopleToolStripMenuItem.Size = new Size(219, 70);
            peopleToolStripMenuItem.Text = "People";
            peopleToolStripMenuItem.Click += peopleToolStripMenuItem_Click;
            // 
            // driversToolStripMenuItem
            // 
            driversToolStripMenuItem.AutoSize = false;
            driversToolStripMenuItem.ForeColor = SystemColors.AppWorkspace;
            driversToolStripMenuItem.Image = (Image)resources.GetObject("driversToolStripMenuItem.Image");
            driversToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            driversToolStripMenuItem.Size = new Size(219, 70);
            driversToolStripMenuItem.Text = "Drivers";
            driversToolStripMenuItem.Click += driversToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.AutoSize = false;
            usersToolStripMenuItem.ForeColor = SystemColors.AppWorkspace;
            usersToolStripMenuItem.Image = (Image)resources.GetObject("usersToolStripMenuItem.Image");
            usersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(219, 70);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // acountSettingsToolStripMenuItem
            // 
            acountSettingsToolStripMenuItem.AutoSize = false;
            acountSettingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { currentUserInfoToolStripMenuItem, changePasswordToolStripMenuItem, toolStripSeparator1, signOutToolStripMenuItem });
            acountSettingsToolStripMenuItem.ForeColor = SystemColors.AppWorkspace;
            acountSettingsToolStripMenuItem.Image = (Image)resources.GetObject("acountSettingsToolStripMenuItem.Image");
            acountSettingsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            acountSettingsToolStripMenuItem.Name = "acountSettingsToolStripMenuItem";
            acountSettingsToolStripMenuItem.Size = new Size(219, 70);
            acountSettingsToolStripMenuItem.Text = "Account Settings";
            acountSettingsToolStripMenuItem.Click += acountSettingsToolStripMenuItem_Click;
            // 
            // currentUserInfoToolStripMenuItem
            // 
            currentUserInfoToolStripMenuItem.Image = (Image)resources.GetObject("currentUserInfoToolStripMenuItem.Image");
            currentUserInfoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            currentUserInfoToolStripMenuItem.Size = new Size(203, 38);
            currentUserInfoToolStripMenuItem.Text = "Current User Info";
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Image = (Image)resources.GetObject("changePasswordToolStripMenuItem.Image");
            changePasswordToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(203, 38);
            changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(200, 6);
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Image = (Image)resources.GetObject("signOutToolStripMenuItem.Image");
            signOutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(203, 38);
            signOutToolStripMenuItem.Text = "Sign Out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(544, 177);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 177);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell Extra Bold", 20F, FontStyle.Bold);
            label1.Location = new Point(293, 357);
            label1.Name = "label1";
            label1.Size = new Size(706, 32);
            label1.TabIndex = 2;
            label1.Text = "Driving and Vehicle Licensing Department";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1104, 642);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            Text = "DVLD ";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem applicatinonToolStripMenuItem;
        private ToolStripMenuItem peopleToolStripMenuItem;
        private ToolStripMenuItem driversToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem acountSettingsToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label1;
        private ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem signOutToolStripMenuItem;
    }
}
