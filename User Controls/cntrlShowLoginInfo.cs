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
namespace DVLD
{
    public partial class cntrlShowLoginInfo : UserControl
    {
        public cntrlShowLoginInfo()
        {
            InitializeComponent();

            
        }

        private void lblUserID_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void lblisActive_Click(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            lblUserID.Text = clsGlobalUserInfo.UserId.ToString();
            lblUserName.Text = clsGlobalUserInfo.UserName.ToString();

            if (clsGlobalUserInfo.IsActive == true)
            {
                lblisActive.Text = "Yes";
            }
            else
            {
                lblisActive.Text = "No";
            }
        }
    }
}
