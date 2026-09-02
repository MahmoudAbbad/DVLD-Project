namespace DVLDPresentationLayer.User_Controls
{
    partial class cntrlAddEditPerson
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cntrlAddEditPerson));
            groupBox1 = new GroupBox();
            lnkRemove = new LinkLabel();
            btnClose = new Button();
            btnSave = new Button();
            pictureBox1 = new PictureBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            tbNationalNo = new TextBox();
            dtpDateOfBirth = new DateTimePicker();
            cbCountry = new ComboBox();
            tbPhone = new TextBox();
            tbAddress = new TextBox();
            tbEmail = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label1 = new Label();
            tbLastName = new TextBox();
            tbThirdName = new TextBox();
            tbSecondName = new TextBox();
            tbFirstName = new TextBox();
            lnkSetImage = new LinkLabel();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pbPersonImage = new PictureBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            WarningError = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WarningError).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lnkRemove);
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Controls.Add(tbNationalNo);
            groupBox1.Controls.Add(dtpDateOfBirth);
            groupBox1.Controls.Add(cbCountry);
            groupBox1.Controls.Add(tbPhone);
            groupBox1.Controls.Add(tbAddress);
            groupBox1.Controls.Add(tbEmail);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbLastName);
            groupBox1.Controls.Add(tbThirdName);
            groupBox1.Controls.Add(tbSecondName);
            groupBox1.Controls.Add(tbFirstName);
            groupBox1.Controls.Add(lnkSetImage);
            groupBox1.Controls.Add(pictureBox9);
            groupBox1.Controls.Add(pictureBox8);
            groupBox1.Controls.Add(pictureBox7);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pbPersonImage);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(839, 443);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // lnkRemove
            // 
            lnkRemove.AutoSize = true;
            lnkRemove.Font = new Font("Segoe UI", 9F);
            lnkRemove.Location = new Point(712, 333);
            lnkRemove.Name = "lnkRemove";
            lnkRemove.Size = new Size(50, 15);
            lnkRemove.TabIndex = 47;
            lnkRemove.TabStop = true;
            lnkRemove.Text = "Remove";
            lnkRemove.Visible = false;
            lnkRemove.LinkClicked += lnkRemove_LinkClicked;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 10F);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(342, 383);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(126, 47);
            btnClose.TabIndex = 16;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10F);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(492, 383);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 47);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(229, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Segoe UI", 10F);
            rbFemale.Location = new Point(266, 185);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(70, 23);
            rbFemale.TabIndex = 7;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            rbFemale.CheckedChanged += rbFemale_CheckedChanged;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Checked = true;
            rbMale.Font = new Font("Segoe UI", 10F);
            rbMale.Location = new Point(166, 185);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(57, 23);
            rbMale.TabIndex = 6;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.CheckedChanged += rbMale_CheckedChanged;
            // 
            // tbNationalNo
            // 
            tbNationalNo.Font = new Font("Segoe UI", 10F);
            tbNationalNo.Location = new Point(166, 129);
            tbNationalNo.Name = "tbNationalNo";
            tbNationalNo.Size = new Size(130, 25);
            tbNationalNo.TabIndex = 5;
            tbNationalNo.Validating += tbNationalNo_Validating;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.CalendarFont = new Font("Segoe UI", 11F);
            dtpDateOfBirth.Location = new Point(488, 130);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(130, 23);
            dtpDateOfBirth.TabIndex = 11;
            dtpDateOfBirth.Value = new DateTime(2026, 8, 26, 0, 0, 0, 0);
            // 
            // cbCountry
            // 
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(488, 236);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(130, 23);
            cbCountry.TabIndex = 13;
            // 
            // tbPhone
            // 
            tbPhone.Font = new Font("Segoe UI", 10F);
            tbPhone.Location = new Point(488, 181);
            tbPhone.MaxLength = 10;
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(130, 25);
            tbPhone.TabIndex = 12;
            tbPhone.KeyPress += tbPhone_KeyPress;
            tbPhone.Validating += tbPhone_Validating;
            // 
            // tbAddress
            // 
            tbAddress.Font = new Font("Segoe UI", 10F);
            tbAddress.Location = new Point(166, 286);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(452, 91);
            tbAddress.TabIndex = 9;
            tbAddress.Validating += tbAddress_Validating;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 10F);
            tbEmail.Location = new Point(166, 236);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(130, 25);
            tbEmail.TabIndex = 8;
            tbEmail.Validating += tbEmail_Validating;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F);
            label12.Location = new Point(642, 47);
            label12.Name = "label12";
            label12.Size = new Size(35, 20);
            label12.TabIndex = 37;
            label12.Text = "Last";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F);
            label11.Location = new Point(492, 47);
            label11.Name = "label11";
            label11.Size = new Size(43, 20);
            label11.TabIndex = 36;
            label11.Text = "Third";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.Location = new Point(341, 47);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 35;
            label10.Text = "Second";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(209, 47);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 34;
            label1.Text = "First";
            // 
            // tbLastName
            // 
            tbLastName.Font = new Font("Segoe UI", 10F);
            tbLastName.Location = new Point(595, 70);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(130, 25);
            tbLastName.TabIndex = 4;
            tbLastName.Validating += tbLastName_Validating;
            // 
            // tbThirdName
            // 
            tbThirdName.Font = new Font("Segoe UI", 10F);
            tbThirdName.Location = new Point(452, 70);
            tbThirdName.Name = "tbThirdName";
            tbThirdName.Size = new Size(130, 25);
            tbThirdName.TabIndex = 3;
            // 
            // tbSecondName
            // 
            tbSecondName.Font = new Font("Segoe UI", 10F);
            tbSecondName.Location = new Point(309, 70);
            tbSecondName.Name = "tbSecondName";
            tbSecondName.Size = new Size(130, 25);
            tbSecondName.TabIndex = 2;
            tbSecondName.Validating += tbSecondName_Validating;
            // 
            // tbFirstName
            // 
            tbFirstName.Font = new Font("Segoe UI", 10F);
            tbFirstName.Location = new Point(166, 70);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(130, 25);
            tbFirstName.TabIndex = 1;
            tbFirstName.Validating += tbFirstName_Validating;
            // 
            // lnkSetImage
            // 
            lnkSetImage.AutoSize = true;
            lnkSetImage.Font = new Font("Segoe UI", 10F);
            lnkSetImage.Location = new Point(703, 310);
            lnkSetImage.Name = "lnkSetImage";
            lnkSetImage.Size = new Size(70, 19);
            lnkSetImage.TabIndex = 14;
            lnkSetImage.TabStop = true;
            lnkSetImage.Text = "Set Image";
            lnkSetImage.LinkClicked += lnkSetImage_LinkClicked;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(452, 226);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(30, 35);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 20;
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(452, 176);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(30, 35);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 19;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(452, 123);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(30, 35);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 18;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(121, 281);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(121, 228);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(121, 175);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(121, 119);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(121, 68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pbPersonImage
            // 
            pbPersonImage.Image = (Image)resources.GetObject("pbPersonImage.Image");
            pbPersonImage.ImageLocation = "";
            pbPersonImage.InitialImage = (Image)resources.GetObject("pbPersonImage.InitialImage");
            pbPersonImage.Location = new Point(642, 110);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(189, 197);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 10;
            pbPersonImage.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(342, 234);
            label9.Name = "label9";
            label9.Size = new Size(76, 21);
            label9.TabIndex = 8;
            label9.Text = "Country:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(342, 181);
            label8.Name = "label8";
            label8.Size = new Size(63, 21);
            label8.TabIndex = 7;
            label8.Text = "Phone:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(342, 128);
            label7.Name = "label7";
            label7.Size = new Size(113, 21);
            label7.TabIndex = 6;
            label7.Text = "Date Of Birth:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 286);
            label6.Name = "label6";
            label6.Size = new Size(74, 21);
            label6.TabIndex = 5;
            label6.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 233);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 180);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 3;
            label4.Text = "Gender:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 127);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 2;
            label3.Text = "National No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 74);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // WarningError
            // 
            WarningError.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // cntrlAddEditPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "cntrlAddEditPerson";
            Size = new Size(839, 443);
            Load += cntrlAddEditPerson_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)WarningError).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox tbLastName;
        private TextBox tbThirdName;
        private TextBox tbSecondName;
        private TextBox tbFirstName;
        private LinkLabel lnkSetImage;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pbPersonImage;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private RadioButton rbMale;
        private TextBox tbNationalNo;
        private DateTimePicker dtpDateOfBirth;
        private ComboBox cbCountry;
        private TextBox tbPhone;
        private TextBox tbAddress;
        private TextBox tbEmail;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button btnClose;
        private Button btnSave;
        private PictureBox pictureBox1;
        private RadioButton rbFemale;
        private ErrorProvider WarningError;
        private OpenFileDialog openFileDialog1;
        private LinkLabel lnkRemove;
    }
}
