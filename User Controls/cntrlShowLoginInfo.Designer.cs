namespace DVLD
{
    partial class cntrlShowLoginInfo
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
            groupBox2 = new GroupBox();
            lblisActive = new Label();
            lblUserName = new Label();
            lblUserID = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(lblisActive);
            groupBox2.Controls.Add(lblUserName);
            groupBox2.Controls.Add(lblUserID);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(708, 123);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Login Informatino";
            // 
            // lblisActive
            // 
            lblisActive.AutoSize = true;
            lblisActive.Font = new Font("Tajawal Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblisActive.Location = new Point(623, 60);
            lblisActive.Name = "lblisActive";
            lblisActive.Size = new Size(0, 22);
            lblisActive.TabIndex = 5;
            lblisActive.Click += lblisActive_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Tajawal Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(352, 60);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(0, 22);
            lblUserName.TabIndex = 4;
            lblUserName.Click += lblUserName_Click;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Tajawal Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserID.Location = new Point(147, 60);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(0, 22);
            lblUserID.TabIndex = 3;
            lblUserID.Click += lblUserID_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tajawal ExtraBold", 14F, FontStyle.Bold);
            label3.Location = new Point(528, 56);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 2;
            label3.Text = "Is Active:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tajawal ExtraBold", 14F, FontStyle.Bold);
            label2.Location = new Point(235, 56);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 1;
            label2.Text = "User Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tajawal ExtraBold", 14F, FontStyle.Bold);
            label1.Location = new Point(62, 56);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 0;
            label1.Text = "User ID:";
            // 
            // cntrlShowLoginInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Name = "cntrlShowLoginInfo";
            Size = new Size(708, 123);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label lblUserID;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblisActive;
        private Label lblUserName;
    }
}
