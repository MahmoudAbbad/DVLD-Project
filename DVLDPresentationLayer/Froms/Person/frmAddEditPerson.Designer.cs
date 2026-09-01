namespace DVLDPresentationLayer.Froms
{
    partial class frmAddNewPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewPerson));
            cntrlAddEditPerson1 = new DVLDPresentationLayer.User_Controls.cntrlAddEditPerson();
            lblTitle = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblPersonId = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cntrlAddEditPerson1
            // 
            cntrlAddEditPerson1.Location = new Point(13, 143);
            cntrlAddEditPerson1.Name = "cntrlAddEditPerson1";
            cntrlAddEditPerson1.Size = new Size(839, 443);
            cntrlAddEditPerson1.TabIndex = 0;
            cntrlAddEditPerson1.Load += cntrlAddEditPerson1_Load;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(337, 60);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(164, 37);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Add Person";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 110);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 3;
            label1.Text = "Person ID:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(130, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 32);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblPersonId
            // 
            lblPersonId.AutoSize = true;
            lblPersonId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPersonId.Location = new Point(167, 110);
            lblPersonId.Name = "lblPersonId";
            lblPersonId.Size = new Size(41, 21);
            lblPersonId.TabIndex = 5;
            lblPersonId.Text = "N/A";
            // 
            // frmAddNewPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 598);
            Controls.Add(lblPersonId);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(cntrlAddEditPerson1);
            Name = "frmAddNewPerson";
            Text = "frmAddNewPerson";
            Load += frmAddNewPerson_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private User_Controls.cntrlAddEditPerson cntrlAddEditPerson1;
        private Label lblTitle;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lblPersonId;
    }
}