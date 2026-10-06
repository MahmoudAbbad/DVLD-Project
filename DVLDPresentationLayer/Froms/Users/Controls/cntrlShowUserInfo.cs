using DVLDBusinessLogicLayer;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer.Froms.Users.Controls
{
    public partial class cntrlShowUserInfo : UserControl
    {
        private int _userId = -1;
        public cntrlShowUserInfo()
        {
            InitializeComponent();
            _DefaultSettings();
        }
        private void _DefaultSettings()
        {
            lblUserID.Text = "N/A";
            lblUserName.Text = "[???]";
            lblisActive.Text = "[???]";
        }
        private void _LoadDataToControls()
        {
            var userInfo = clsUsers.FindUserByUserId(_userId);

            if (userInfo != null)
            {
                lblUserID.Text = _userId.ToString();
                lblUserName.Text = userInfo.UserName;
                lblisActive.Text = userInfo.IsActive ? "Yes" : "No";
                cntrlShowPersonInfo1.LoadPersonInfoByPersonId(userInfo.PersonID);
            }
            else
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadDataByUserId(int userId)//check if user id is valid and then load data to controls
        {
            if (userId <= 0 || userId == null)
            {
                MessageBox.Show("Invalid User ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _userId = userId;
            _LoadDataToControls();
        }

        private void cntrlShowUserInfo_Load(object sender, EventArgs e)
        {

        }

        private void lblisActive_Click(object sender, EventArgs e)
        {

        }
    }
}
