using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer.Froms
{
    public partial class frmShowUserDetails : Form
    {
        private int _UserId = -1;
        public frmShowUserDetails(int userId)
        {
            InitializeComponent();
            if (userId <= 0)
            {
                MessageBox.Show("Invalid User ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _UserId = userId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowUserDetails_Load(object sender, EventArgs e)
        {
            cntrlShowUserInfo1.LoadDataByUserId(_UserId);
        }
    }
}
