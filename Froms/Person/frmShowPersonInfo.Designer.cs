namespace DVLDPresentationLayer.Froms
{
    partial class frmShowPersonInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowPersonInfo));
            cntrlShowPersonInfo1 = new DVLDPresentationLayer.User_Controls.cntrlShowPersonInfo();
            label1 = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // cntrlShowPersonInfo1
            // 
            cntrlShowPersonInfo1.Location = new Point(12, 112);
            cntrlShowPersonInfo1.Name = "cntrlShowPersonInfo1";
            cntrlShowPersonInfo1.Size = new Size(880, 395);
            cntrlShowPersonInfo1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(331, 45);
            label1.Name = "label1";
            label1.Size = new Size(200, 37);
            label1.TabIndex = 1;
            label1.Text = "Person Details";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F);
            btnClose.ForeColor = SystemColors.ControlText;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(625, 530);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(144, 48);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmShowPersonInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(891, 590);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(cntrlShowPersonInfo1);
            Name = "frmShowPersonInfo";
            Text = "Person Details";
            Load += frmShowPersonInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private User_Controls.cntrlShowPersonInfo cntrlShowPersonInfo1;
        private Label label1;
        private Button btnClose;
    }
}