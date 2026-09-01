using DVLDBusinessLogicLayer;
using DVLDPresentationLayer.Froms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmUsers : Form
    {
        DataTable dtAllUsrs = clsUsers.GetAllUsers();
        public frmUsers()
        {
            InitializeComponent();

        }
        private void _LoadDataToDataGridView()
        {
            dvgListAllUsers.DataSource = clsUsers.GetAllUsers();
            dvgListAllUsers.Columns["FullName"].Width = 250;
        }
        private void _RefreshGrid()
        {
            _LoadDataToDataGridView();
            lblCountOfUsers.Text = dvgListAllUsers.RowCount.ToString();
        }
        private void _LoadData()
        {
            _RefreshGrid();
            cbFilterBy.SelectedIndex = 0;
            cbActiveFilter.SelectedIndex = 0;
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {

        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dvgListAllUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            switch (cbFilterBy.SelectedIndex)
            {
                case 0:

                    dtAllUsrs.DefaultView.RowFilter = null;
                    break;
                case 1:
                    if (int.TryParse(tbSearch.Text, out int UserId))
                    {
                        dtAllUsrs.DefaultView.RowFilter = "UserID = " + UserId;
                    }
                    else
                    {
                        dtAllUsrs.DefaultView.RowFilter = "";
                    }
                    break;
                case 2:

                    if (int.TryParse(tbSearch.Text, out int PersonID))
                    {
                        dtAllUsrs.DefaultView.RowFilter = "PersonID = " + PersonID;
                    }
                    else
                    {
                        dtAllUsrs.DefaultView.RowFilter = "";
                    }
                    break;

                case 3:
                    dtAllUsrs.DefaultView.RowFilter = "UserName Like '%" + tbSearch.Text + "%'";
                    break;
                case 4:
                    dtAllUsrs.DefaultView.RowFilter = "";
                    break;
                    dvgListAllUsers.DataSource = dtAllUsrs;
            }

            dvgListAllUsers.DataSource = dtAllUsrs;
        }
        private void cbActiveFilter_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch (cbActiveFilter.SelectedIndex)
            {
                case 0:
                    dtAllUsrs.DefaultView.RowFilter = "";
                    break;
                case 1:
                    dtAllUsrs.DefaultView.RowFilter = "IsActive = 0";
                    break;
                case 2:
                    dtAllUsrs.DefaultView.RowFilter = "IsActive = 1";
                    break;
            }

            dvgListAllUsers.DataSource = dtAllUsrs;
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Text = string.Empty;

            switch (cbFilterBy.SelectedIndex)
            {
                case 0:
                    cbActiveFilter.SelectedIndex = 0;
                    tbSearch.Text = string.Empty;
                    cbActiveFilter.Visible = false;
                    tbSearch.Visible = false;

                    break;
                case 4:
                    tbSearch.Text = "";
                    tbSearch.Visible = false;
                    cbActiveFilter.Visible = true;
                    break;
                default:
                    cbActiveFilter.SelectedIndex = 0;
                    cbActiveFilter.Visible = false;
                    tbSearch.Visible = true;
                    break;
            }
        }
        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cbFilterBy.SelectedIndex)
            {
                case 1:
                    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    break;

                case 2:
                    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    break;
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // clsGlobalUserInfo.SetAllUserInfo(dvgListAllUsers)
            frmShowUserDetails frm = new frmShowUserDetails();
            frm.ShowDialog();
        }
    }
}
