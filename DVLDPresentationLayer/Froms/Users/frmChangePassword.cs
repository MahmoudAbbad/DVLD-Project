using DVLDBusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer.Froms.Users
{
    public partial class frmChangePassword : Form
    {
        private int _UserId = -1;
        private string _CurrentPassword = string.Empty;
        private bool _isCurrentUser = false;
        public frmChangePassword(int UserID, bool isCurrentUser)
        {
            InitializeComponent();
            _LoadInternalData(UserID, isCurrentUser);
        }
        private void _LoadInternalData(int UserID,bool isCurrentUser)
        {
            if (UserID <= 0)
            {
                MessageBox.Show("Invalid User ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            _UserId = UserID;
            cntrlShowUserInfo1.LoadDataByUserId(_UserId);
            _isCurrentUser = isCurrentUser;
            _SetCurrentPassword();

        }
        private void _SetCurrentPassword()
        {
            if (_isCurrentUser)
            {
                _CurrentPassword = clsGlobalUserInfo.CurrentUser.userInfo.Password;
            }
            else
                _CurrentPassword = clsUsers.GetPasswordByUserId(_UserId);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbCurrentPassword_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCurrentPassword.Text))
            {
                errorProvider1.SetError(tbCurrentPassword, "Current password cannot be empty.");
            }
            else
            {
                errorProvider1.SetError(tbCurrentPassword, string.Empty);
                if (tbCurrentPassword.Text != _CurrentPassword)
                {
                    errorProvider1.SetError(tbCurrentPassword, "Current password is incorrect.");
                }
                else
                {
                    errorProvider1.SetError(tbCurrentPassword, string.Empty);
                }
            }
        }

        private void tbNewPassword_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNewPassword.Text))
            {
                errorProvider1.SetError(tbNewPassword, "New password cannot be empty.");
            }
            else
            {
                errorProvider1.SetError(tbNewPassword, string.Empty);

                if (tbNewPassword.Text == tbCurrentPassword.Text)
                {
                    errorProvider1.SetError(tbNewPassword, "New password cannot be the same as current password.");
                }
                else
                {
                    errorProvider1.SetError(tbNewPassword, string.Empty);
                }
            }
        }

        private void tbConfirmPassword_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbConfirmPassword.Text))
            {
                errorProvider1.SetError(tbConfirmPassword, "Confirm password cannot be empty.");

            }
            else
            {
                errorProvider1.SetError(tbConfirmPassword, string.Empty);
                if (tbConfirmPassword.Text != tbNewPassword.Text)
                {
                    errorProvider1.SetError(tbConfirmPassword, "Confirm password does not match new password.");

                }
                else
                {
                    errorProvider1.SetError(tbConfirmPassword, string.Empty);
                }

            }
        }

        private bool _IsWrongInputs()
        {
            return !string.IsNullOrEmpty(errorProvider1.GetError(tbCurrentPassword)) ||
                   !string.IsNullOrEmpty(errorProvider1.GetError(tbNewPassword)) ||
                   !string.IsNullOrEmpty(errorProvider1.GetError(tbConfirmPassword))||
                   tbCurrentPassword.Text != _CurrentPassword ||
                   tbNewPassword.Text != tbConfirmPassword.Text||
                   tbNewPassword.Text == tbCurrentPassword.Text;
        }

        private void _RefreshInputs()
        {
            tbCurrentPassword.Text = string.Empty;
            tbNewPassword.Text = string.Empty;
            tbConfirmPassword.Text = string.Empty;
            errorProvider1.SetError(tbCurrentPassword, string.Empty);
            errorProvider1.SetError(tbNewPassword, string.Empty);
            errorProvider1.SetError(tbConfirmPassword, string.Empty);
            _SetCurrentPassword();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_IsWrongInputs())
            {
                MessageBox.Show("Please enter correct information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(clsUsers.UpdateUserPassword(_UserId, tbNewPassword.Text))
            {
                MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshInputs();

            }
            else
            {
                MessageBox.Show("Failed to update password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
