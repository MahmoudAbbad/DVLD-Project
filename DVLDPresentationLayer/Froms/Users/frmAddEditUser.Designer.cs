namespace DVLDPresentationLayer.Froms.Users
{
    partial class frmAddEditUser
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
            lblTitle = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            cntrlShowPersonInfoWithFilter1 = new DVLDPresentationLayer.Froms.Person.Controls.cntrlShowPersonInfoWithFilter();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(390, 73);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New User";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(27, 156);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(900, 572);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cntrlShowPersonInfoWithFilter1);
            tabPage1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(892, 544);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Personal Info";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cntrlShowPersonInfoWithFilter1
            // 
            cntrlShowPersonInfoWithFilter1.Location = new Point(6, 21);
            cntrlShowPersonInfoWithFilter1.Name = "cntrlShowPersonInfoWithFilter1";
            cntrlShowPersonInfoWithFilter1.Size = new Size(886, 510);
            cntrlShowPersonInfoWithFilter1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(892, 544);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Login Info";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmAddEditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 798);
            ControlBox = false;
            Controls.Add(tabControl1);
            Controls.Add(lblTitle);
            Name = "frmAddEditUser";
            Text = "frmAddEditUser";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Person.Controls.cntrlShowPersonInfoWithFilter cntrlShowPersonInfoWithFilter1;
    }
}