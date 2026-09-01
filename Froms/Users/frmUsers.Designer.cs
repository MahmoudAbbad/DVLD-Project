namespace DVLD
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tbSearch = new TextBox();
            label3 = new Label();
            btnAddUser = new Button();
            lblCountOfUsers = new Label();
            label2 = new Label();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            cbFilterBy = new ComboBox();
            toolStripSeparator1 = new ToolStripSeparator();
            editToolStripMenuItem = new ToolStripMenuItem();
            addNewPersonToolStripMenuItem = new ToolStripMenuItem();
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            dvgListAllUsers = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            cbActiveFilter = new ComboBox();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgListAllUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(220, 232);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(174, 23);
            tbSearch.TabIndex = 17;
            tbSearch.Visible = false;
            tbSearch.TextChanged += tbSearch_TextChanged;
            tbSearch.KeyPress += tbSearch_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 235);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 15;
            label3.Text = "Filter By:";
            // 
            // btnAddUser
            // 
            btnAddUser.BackgroundImage = (Image)resources.GetObject("btnAddUser.BackgroundImage");
            btnAddUser.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Location = new Point(619, 189);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(67, 62);
            btnAddUser.TabIndex = 14;
            btnAddUser.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // lblCountOfUsers
            // 
            lblCountOfUsers.AutoSize = true;
            lblCountOfUsers.Font = new Font("Segoe UI", 11F);
            lblCountOfUsers.Location = new Point(119, 532);
            lblCountOfUsers.Name = "lblCountOfUsers";
            lblCountOfUsers.Size = new Size(17, 20);
            lblCountOfUsers.TabIndex = 13;
            lblCountOfUsers.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 532);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 12;
            label2.Text = "# Record: ";
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Image = (Image)resources.GetObject("phoneCallToolStripMenuItem.Image");
            phoneCallToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(211, 46);
            phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Image = (Image)resources.GetObject("sendEmailToolStripMenuItem.Image");
            sendEmailToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(211, 46);
            sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.Font = new Font("Segoe UI", 10F);
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "UserID", "PersonID", "UserName", "IsActive" });
            cbFilterBy.Location = new Point(98, 232);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(116, 25);
            cbFilterBy.TabIndex = 16;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(208, 6);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = (Image)resources.GetObject("editToolStripMenuItem.Image");
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(211, 46);
            editToolStripMenuItem.Text = "Edit";
            // 
            // addNewPersonToolStripMenuItem
            // 
            addNewPersonToolStripMenuItem.Image = (Image)resources.GetObject("addNewPersonToolStripMenuItem.Image");
            addNewPersonToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            addNewPersonToolStripMenuItem.Size = new Size(211, 46);
            addNewPersonToolStripMenuItem.Text = "Add New Person";
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 11F);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, addNewPersonToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, toolStripSeparator1, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(212, 308);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(211, 46);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // dvgListAllUsers
            // 
            dvgListAllUsers.AllowUserToAddRows = false;
            dvgListAllUsers.AllowUserToDeleteRows = false;
            dvgListAllUsers.AllowUserToOrderColumns = true;
            dvgListAllUsers.BackgroundColor = SystemColors.ActiveCaption;
            dvgListAllUsers.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvgListAllUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dvgListAllUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgListAllUsers.ContextMenuStrip = contextMenuStrip1;
            dvgListAllUsers.Location = new Point(12, 266);
            dvgListAllUsers.Name = "dvgListAllUsers";
            dvgListAllUsers.ReadOnly = true;
            dvgListAllUsers.Size = new Size(722, 263);
            dvgListAllUsers.TabIndex = 11;
            dvgListAllUsers.CellContentClick += dvgListAllUsers_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tajawal ExtraBold", 24.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(278, 180);
            label1.Name = "label1";
            label1.Size = new Size(224, 49);
            label1.TabIndex = 10;
            label1.Text = "Manage Users";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-201, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1196, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // cbActiveFilter
            // 
            cbActiveFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbActiveFilter.FormattingEnabled = true;
            cbActiveFilter.Items.AddRange(new object[] { "All", "No", "Yes" });
            cbActiveFilter.Location = new Point(220, 232);
            cbActiveFilter.Name = "cbActiveFilter";
            cbActiveFilter.Size = new Size(148, 23);
            cbActiveFilter.TabIndex = 18;
            cbActiveFilter.Visible = false;
            cbActiveFilter.SelectedIndexChanged += cbActiveFilter_SelectedIndexChanged;
            // 
            // frmUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(774, 568);
            Controls.Add(cbActiveFilter);
            Controls.Add(label1);
            Controls.Add(tbSearch);
            Controls.Add(label3);
            Controls.Add(btnAddUser);
            Controls.Add(lblCountOfUsers);
            Controls.Add(label2);
            Controls.Add(cbFilterBy);
            Controls.Add(dvgListAllUsers);
            Controls.Add(pictureBox1);
            Name = "frmUsers";
            Text = "All Users";
            Load += frmUsers_Load;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgListAllUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSearch;
        private Label label3;
        private Button btnAddUser;
        private Label lblCountOfUsers;
        private Label label2;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ComboBox cbFilterBy;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem addNewPersonToolStripMenuItem;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private DataGridView dvgListAllUsers;
        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox cbActiveFilter;
    }
}