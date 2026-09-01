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
            clsUsers User = new clsUsers();

            User.UserName = tbUserName.Text;
            User.Password = tbPassword.Text;

            if (User.CheckIfUserNameAndPassTrue(User.UserName, User.Password))
            {
                if (User.IsActive == true)
                {
                    User.FillUserInGlobalClass();
                    _SaveUserInfoToFile();
                    frmMain frm = new frmMain();
                    frm.ShowDialog();
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

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            if (tbUserName.Text == "")
            {
                errorProvider1.SetError(tbUserName, "You must enter a username!");
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                errorProvider2.SetError(tbPassword, "You must enter a Password!");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == '*')
            {
                tbPassword.PasswordChar = default;
            }
            else
            {
                tbPassword.PasswordChar = '*';
            }
        }
    }
}
