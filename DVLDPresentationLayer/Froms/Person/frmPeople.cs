using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLogicLayer;
using DVLDDataAccessLayer.Person;
using DVLDPresentationLayer.Froms;
namespace DVLD
{
    public partial class frmPeople : Form
    {
        private DataTable dt = clsPerson.GetPeople();

        public frmPeople()
        {
            InitializeComponent();


            cbFilterBy.SelectedIndex = 0;
            _RefershGrid();

        }
        private void _LoadDataToGrid()
        {
            dvgListAllPerson.DataSource = dt.DefaultView;

            if (dvgListAllPerson.Columns["Gendor"] != null)
            {
                dvgListAllPerson.Columns["Gendor"].Visible = false;
            }
        }
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frmAddEdit = new frmAddNewPerson(-1);
            frmAddEdit.ShowDialog();
            _RefershGrid();
        }
        private void _RefershGrid()
        {
            dt = clsPerson.GetPeople();
            _LoadDataToGrid();
            lblCountOfPeople.Text = dt.DefaultView.Count.ToString();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frmEdit = new frmAddNewPerson((int)dvgListAllPerson.CurrentRow.Cells[0].Value);
            frmEdit.ShowDialog();
            _RefershGrid();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo frmPersonInfo = new frmShowPersonInfo((int)dvgListAllPerson.CurrentRow.Cells[0].Value);
            frmPersonInfo.ShowDialog();
            _RefershGrid();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure u want to delete the Person?", "Delete Person?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsPersonEntity personInfo = clsPerson.FindById((int)dvgListAllPerson.CurrentRow.Cells[0].Value);
                clsPerson personService = new clsPerson(personInfo);

                if (personService.DeletePerson(personInfo.PersonID))
                {
                    _RefershGrid();
                    MessageBox.Show("Deleted is done Successfully", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Person was not deleted because it is associated with other data.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frmAddPerson = new frmAddNewPerson(-1);
            frmAddPerson.ShowDialog();
            _RefershGrid();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature not enable for now", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature not enable for now", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 0)
            {
                tbSearch.Text = "";
                tbSearch.Visible = false;
            }
            else
            {
                tbSearch.Visible = true;
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            switch (cbFilterBy.SelectedIndex)
            {

                case 0:
                    dt.DefaultView.RowFilter = null;
                    break;

                case 1:
                    {
                        int PersonID;

                        if (int.TryParse(tbSearch.Text, out PersonID))
                        {
                            dt.DefaultView.RowFilter = "PersonID = " + PersonID;
                        }
                        else
                        {
                            dt.DefaultView.RowFilter = "";
                        }
                        break;
                    }
                case 2:
                    dt.DefaultView.RowFilter =
                    "NationalNo LIKE '" + tbSearch.Text + "%'";
                    break;

                case 3:
                    dt.DefaultView.RowFilter =
                    "FirstName LIKE '" + tbSearch.Text + "%'";
                    break;
                case 4:
                    dt.DefaultView.RowFilter =
                    "SecondName LIKE '" + tbSearch.Text + "%'";
                    break;
                case 5:
                    dt.DefaultView.RowFilter =
                    "ThirdName LIKE '" + tbSearch.Text + "%'";
                    break;
                case 6:
                    dt.DefaultView.RowFilter =
                    "LastName LIKE '" + tbSearch.Text + "%'";
                    break;
                case 7:
                    dt.DefaultView.RowFilter =
                    "Natinoality LIKE '" + tbSearch.Text + "%'";
                    break;
                case 8:
                    dt.DefaultView.RowFilter =
                    "Gender LIKE '" + tbSearch.Text + "%'";
                    break;
                case 9:
                    dt.DefaultView.RowFilter =
                    "Phone LIKE '" + tbSearch.Text + "%'";
                    break;
                case 10:
                    dt.DefaultView.RowFilter =
                    "Email LIKE '" + tbSearch.Text + "%'";
                    break;
            }
            dvgListAllPerson.DataSource = dt;

        }

        private void frmPeople_Load(object sender, EventArgs e)
        {

        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 1)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}

