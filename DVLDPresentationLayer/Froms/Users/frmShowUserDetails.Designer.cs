namespace DVLDPresentationLayer.Froms
{
    partial class frmShowUserDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowUserDetails));
            cntrlShowUserInfo1 = new DVLDPresentationLayer.Froms.Users.Controls.cntrlShowUserInfo();
            btnClose = new Button();
            SuspendLayout();
            // 
            // cntrlShowUserInfo1
            // 
            cntrlShowUserInfo1.Location = new Point(3, 12);
            cntrlShowUserInfo1.Name = "cntrlShowUserInfo1";
            cntrlShowUserInfo1.Size = new Size(877, 533);
            cntrlShowUserInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F);
            btnClose.ForeColor = SystemColors.ControlText;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(716, 551);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(144, 48);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmShowUserDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 613);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(cntrlShowUserInfo1);
            Name = "frmShowUserDetails";
            Text = "Show User Information";
            Load += frmShowUserDetails_Load;
            ResumeLayout(false);
        }

        #endregion

        private Users.Controls.cntrlShowUserInfo cntrlShowUserInfo1;
        private Button btnClose;
    }
}