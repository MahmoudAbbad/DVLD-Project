using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLogicLayer;
using DVLDDataAccessLayer;
using System.IO;
using System.Security.Cryptography.X509Certificates;
namespace DVLD
{
    public partial class frmLoginScreen : Form
    {
        private string _Path = Application.StartupPath + "\\LoginInfo.txt";

        public frmLoginScreen()
        {
            InitializeComponent();

            _LoadUserInfoToForm();
        }

        private void _LoadUserInfoToForm()
        {
            if (File.Exists(_Path))
            {
                string[] data = File.ReadAllLines(_Path);

                if (data.Length >= 2)
                {
                    tbUserName.Text = data[0];
                    tbPassword.Text = data[1];
                    cbRememerMe.Checked = true;
                }
            }
        }
        private void _SaveUserInfoToFile()
        {
            if (cbRememerMe.Checked)
            {

                File.WriteAllLines(_Path, new string[]
                    {
                    tbUserName.Text,
                    tbPassword.Text
                    });
            }
            else
            {

                if (File.Exists(_Path))
                {
                    File.Delete(_Path);
                }

            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbUserName.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string UserName = tbUserName.Text;
            string Password = tbPassword.Text;

            clsUsers user = new clsUsers();
            user.userInfo = user.CheckIfUserNameAndPassTrue(UserName, Password);

            if (user.userInfo != null)
            {
                if (user.userInfo.IsActive == true)
                {
                    user.FillUserInGlobalClass();
                    _SaveUserInfoToFile();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The user is not active!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("UserName/Password Is Wrong!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == '*')
            {
                tbPassword.PasswordChar = default;
                pictureBox4.Image = Image.FromFile(@"M:\Icons\hide.png");//eye hide image to hide password
            }
            else
            {
                tbPassword.PasswordChar = '*';
                pictureBox4.Image = Image.FromFile(@"M:\Icons\eye.png");//eye show image to show password
            }
        }

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            if (tbUserName.Text == "")
            {
                errorProvider1.SetError(tbUserName, "You must enter a username!");
            }
            else
            {
                errorProvider1.SetError(tbUserName, "");
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbPassword.Text == "")
            {
                errorProvider2.SetError(tbPassword, "You must enter a password!");
            }
            else
            {
                errorProvider2.SetError(tbPassword, "");
            }
        }
    }
}
