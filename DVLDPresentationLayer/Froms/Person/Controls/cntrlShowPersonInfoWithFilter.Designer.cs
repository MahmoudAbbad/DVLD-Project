namespace DVLDPresentationLayer.Froms.Person.Controls
{
    partial class cntrlShowPersonInfoWithFilter
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
            cntrlShowPersonInfo1 = new DVLDPresentationLayer.User_Controls.cntrlShowPersonInfo();
            gbFilter = new GroupBox();
            btnAddNewPerson = new Button();
            btnFindPerson = new Button();
            tbSearchValue = new TextBox();
            cbFilter = new ComboBox();
            label1 = new Label();
            gbFilter.SuspendLayout();
            SuspendLayout();
            // 
            // cntrlShowPersonInfo1
            // 
            cntrlShowPersonInfo1.Location = new Point(12, 107);
            cntrlShowPersonInfo1.Name = "cntrlShowPersonInfo1";
            cntrlShowPersonInfo1.Size = new Size(865, 397);
            cntrlShowPersonInfo1.TabIndex = 0;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(btnAddNewPerson);
            gbFilter.Controls.Add(btnFindPerson);
            gbFilter.Controls.Add(tbSearchValue);
            gbFilter.Controls.Add(cbFilter);
            gbFilter.Controls.Add(label1);
            gbFilter.Location = new Point(12, 3);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(865, 98);
            gbFilter.TabIndex = 1;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            // 
            // btnAddNewPerson
            // 
            btnAddNewPerson.Image = Properties.Resources.AddPerson_32;
            btnAddNewPerson.Location = new Point(469, 45);
            btnAddNewPerson.Name = "btnAddNewPerson";
            btnAddNewPerson.Size = new Size(36, 36);
            btnAddNewPerson.TabIndex = 4;
            btnAddNewPerson.UseVisualStyleBackColor = true;
            btnAddNewPerson.Click += button2_Click;
            // 
            // btnFindPerson
            // 
            btnFindPerson.Image = Properties.Resources.SearchPerson;
            btnFindPerson.Location = new Point(427, 45);
            btnFindPerson.Name = "btnFindPerson";
            btnFindPerson.Size = new Size(36, 36);
            btnFindPerson.TabIndex = 3;
            btnFindPerson.UseVisualStyleBackColor = true;
            btnFindPerson.Click += btnFindPerson_Click;
            // 
            // tbSearchValue
            // 
            tbSearchValue.BorderStyle = BorderStyle.FixedSingle;
            tbSearchValue.Location = new Point(251, 53);
            tbSearchValue.Name = "tbSearchValue";
            tbSearchValue.Size = new Size(170, 23);
            tbSearchValue.TabIndex = 2;
            tbSearchValue.KeyPress += tbSearchValue_KeyPress;
            // 
            // cbFilter
            // 
            cbFilter.DisplayMember = "0";
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "Person ID", "National No" });
            cbFilter.Location = new Point(83, 53);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(162, 23);
            cbFilter.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 52);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Filter By:";
            // 
            // cntrlShowPersonInfoWithFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbFilter);
            Controls.Add(cntrlShowPersonInfo1);
            Name = "cntrlShowPersonInfoWithFilter";
            Size = new Size(886, 510);
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private User_Controls.cntrlShowPersonInfo cntrlShowPersonInfo1;
        private GroupBox gbFilter;
        private ComboBox cbFilter;
        private Label label1;
        private Button btnFindPerson;
        private TextBox tbSearchValue;
        private Button btnAddNewPerson;
    }
}
