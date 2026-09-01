namespace DVLD
{
    partial class frmPeople
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeople));
            label1 = new Label();
            dvgListAllPerson = new DataGridView();
            cntxManagePeople = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            addNewPersonToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            lblCountOfPeople = new Label();
            btnAddPerson = new Button();
            label3 = new Label();
            cbFilterBy = new ComboBox();
            tbSearch = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dvgListAllPerson).BeginInit();
            cntxManagePeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tajawal ExtraBold", 24.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(481, 174);
            label1.Name = "label1";
            label1.Size = new Size(240, 49);
            label1.TabIndex = 1;
            label1.Text = "Manage People";
            // 
            // dvgListAllPerson
            // 
            dvgListAllPerson.AllowUserToAddRows = false;
            dvgListAllPerson.AllowUserToDeleteRows = false;
            dvgListAllPerson.AllowUserToOrderColumns = true;
            dvgListAllPerson.BackgroundColor = SystemColors.ActiveCaption;
            dvgListAllPerson.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvgListAllPerson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dvgListAllPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgListAllPerson.ContextMenuStrip = cntxManagePeople;
            dvgListAllPerson.Location = new Point(12, 264);
            dvgListAllPerson.Name = "dvgListAllPerson";
            dvgListAllPerson.ReadOnly = true;
            dvgListAllPerson.Size = new Size(1172, 263);
            dvgListAllPerson.TabIndex = 2;
            // 
            // cntxManagePeople
            // 
            cntxManagePeople.Font = new Font("Segoe UI", 11F);
            cntxManagePeople.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, addNewPersonToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, toolStripSeparator1, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            cntxManagePeople.Name = "contextMenuStrip1";
            cntxManagePeople.Size = new Size(212, 286);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Image = (Image)resources.GetObject("showDetailsToolStripMenuItem.Image");
            showDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(211, 46);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // addNewPersonToolStripMenuItem
            // 
            addNewPersonToolStripMenuItem.Image = (Image)resources.GetObject("addNewPersonToolStripMenuItem.Image");
            addNewPersonToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            addNewPersonToolStripMenuItem.Size = new Size(211, 46);
            addNewPersonToolStripMenuItem.Text = "Add New Person";
            addNewPersonToolStripMenuItem.Click += addNewPersonToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = (Image)resources.GetObject("editToolStripMenuItem.Image");
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(211, 46);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(211, 46);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(208, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Image = (Image)resources.GetObject("sendEmailToolStripMenuItem.Image");
            sendEmailToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(211, 46);
            sendEmailToolStripMenuItem.Text = "Send Email";
            sendEmailToolStripMenuItem.Click += sendEmailToolStripMenuItem_Click;
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Image = (Image)resources.GetObject("phoneCallToolStripMenuItem.Image");
            phoneCallToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(211, 46);
            phoneCallToolStripMenuItem.Text = "Phone Call";
            phoneCallToolStripMenuItem.Click += phoneCallToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 530);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 3;
            label2.Text = "# Record: ";
            // 
            // lblCountOfPeople
            // 
            lblCountOfPeople.AutoSize = true;
            lblCountOfPeople.Font = new Font("Segoe UI", 11F);
            lblCountOfPeople.Location = new Point(119, 530);
            lblCountOfPeople.Name = "lblCountOfPeople";
            lblCountOfPeople.Size = new Size(17, 20);
            lblCountOfPeople.TabIndex = 4;
            lblCountOfPeople.Text = "0";
            // 
            // btnAddPerson
            // 
            btnAddPerson.FlatStyle = FlatStyle.Flat;
            btnAddPerson.Image = (Image)resources.GetObject("btnAddPerson.Image");
            btnAddPerson.Location = new Point(1026, 201);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(67, 57);
            btnAddPerson.TabIndex = 5;
            btnAddPerson.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 233);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 6;
            label3.Text = "Filter By:";
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.Font = new Font("Segoe UI", 10F);
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Person ID", "National No.", "FirstName", "SecondName", "ThirdName", "LastName", "Nationality", "Gender", "Phone", "Email" });
            cbFilterBy.Location = new Point(110, 230);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(116, 25);
            cbFilterBy.TabIndex = 7;
            cbFilterBy.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 10F);
            tbSearch.Location = new Point(232, 230);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(174, 25);
            tbSearch.TabIndex = 8;
            tbSearch.TextChanged += tbSearch_TextChanged;
            tbSearch.KeyPress += tbSearch_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1196, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // frmPeople
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1196, 561);
            Controls.Add(pictureBox1);
            Controls.Add(tbSearch);
            Controls.Add(cbFilterBy);
            Controls.Add(label3);
            Controls.Add(btnAddPerson);
            Controls.Add(lblCountOfPeople);
            Controls.Add(label2);
            Controls.Add(dvgListAllPerson);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPeople";
            Text = "Manage People";
            Load += frmPeople_Load;
            ((System.ComponentModel.ISupportInitialize)dvgListAllPerson).EndInit();
            cntxManagePeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dvgListAllPerson;
        private Label label2;
        private Label lblCountOfPeople;
        private Button btnAddPerson;
        private ContextMenuStrip cntxManagePeople;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripMenuItem addNewPersonToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
        private Label label3;
        private ComboBox cbFilterBy;
        private TextBox tbSearch;
        private ToolStripSeparator toolStripSeparator1;
        private PictureBox pictureBox1;
    }
}