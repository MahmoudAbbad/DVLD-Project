namespace DVLDPresentationLayer.Froms.Users
{
    partial class frmChangePassword
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            cntrlShowUserInfo1 = new DVLDPresentationLayer.Froms.Users.Controls.cntrlShowUserInfo();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbCurrentPassword = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tbNewPassword = new TextBox();
            pictureBox3 = new PictureBox();
            tbConfirmPassword = new TextBox();
            btnClose = new Button();
            btnSave = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // cntrlShowUserInfo1
            // 
            cntrlShowUserInfo1.Location = new Point(0, 0);
            cntrlShowUserInfo1.Name = "cntrlShowUserInfo1";
            cntrlShowUserInfo1.Size = new Size(877, 551);
            cntrlShowUserInfo1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 557);
            label1.Name = "label1";
            label1.Size = new Size(156, 23);
            label1.TabIndex = 1;
            label1.Text = "Current Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 607);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 2;
            label2.Text = "New Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 657);
            label3.Name = "label3";
            label3.Size = new Size(161, 23);
            label3.TabIndex = 3;
            label3.Text = "Confirm Password:";
            // 
            // tbCurrentPassword
            // 
            tbCurrentPassword.BorderStyle = BorderStyle.FixedSingle;
            tbCurrentPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCurrentPassword.Location = new Point(212, 557);
            tbCurrentPassword.Multiline = true;
            tbCurrentPassword.Name = "tbCurrentPassword";
            tbCurrentPassword.PasswordChar = '*';
            tbCurrentPassword.Size = new Size(149, 30);
            tbCurrentPassword.TabIndex = 4;
            tbCurrentPassword.Validated += tbCurrentPassword_Validated;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(174, 557);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(174, 607);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // tbNewPassword
            // 
            tbNewPassword.BorderStyle = BorderStyle.FixedSingle;
            tbNewPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNewPassword.Location = new Point(212, 607);
            tbNewPassword.Multiline = true;
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.PasswordChar = '*';
            tbNewPassword.Size = new Size(149, 30);
            tbNewPassword.TabIndex = 6;
            tbNewPassword.Validated += tbNewPassword_Validated;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(174, 650);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            tbConfirmPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbConfirmPassword.Location = new Point(212, 650);
            tbConfirmPassword.Multiline = true;
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.PasswordChar = '*';
            tbConfirmPassword.Size = new Size(149, 30);
            tbConfirmPassword.TabIndex = 8;
            tbConfirmPassword.Validated += tbConfirmPassword_Validated;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F);
            btnClose.ForeColor = SystemColors.ControlText;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(562, 708);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(144, 48);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F);
            btnSave.ForeColor = SystemColors.ControlText;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(719, 708);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 48);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 768);
            ControlBox = false;
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(pictureBox3);
            Controls.Add(tbConfirmPassword);
            Controls.Add(pictureBox2);
            Controls.Add(tbNewPassword);
            Controls.Add(pictureBox1);
            Controls.Add(tbCurrentPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cntrlShowUserInfo1);
            Name = "frmChangePassword";
            Text = "Change Password";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.cntrlShowUserInfo cntrlShowUserInfo1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbCurrentPassword;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox tbNewPassword;
        private PictureBox pictureBox3;
        private TextBox tbConfirmPassword;
        private Button btnClose;
        private Button btnSave;
        private ErrorProvider errorProvider1;
    }
}