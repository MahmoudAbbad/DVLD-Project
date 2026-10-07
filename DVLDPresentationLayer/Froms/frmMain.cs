using System;
using DVLDBusinessLogicLayer;
using DVLDPresentationLayer.Froms;
using DVLDPresentationLayer.Froms.Users;
namespace DVLD
{
    public partial class frmMain : Form
    {
        public bool IsUserSignedOut { get; private set; } = false;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void applicatinonToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeople frm = new frmPeople();

            frm.ShowDialog();

        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmUsers frm = new frmUsers();
            frm.ShowDialog();
        }

        private void acountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsUserSignedOut = true;
            this.Close();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserDetails frm = new frmShowUserDetails(clsGlobalUserInfo.CurrentUser.userInfo.UserID);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userId = clsGlobalUserInfo.CurrentUser?.userInfo?.UserID ?? -1;
            if (userId <= 0)
            {
                MessageBox.Show("Invalid User ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        
            frmChangePassword frm = new frmChangePassword(userId, true);
            frm.ShowDialog();

        }
    }
}
