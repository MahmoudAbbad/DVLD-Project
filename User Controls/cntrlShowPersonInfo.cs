using DVLDBusinessLogicLayer;
using DVLDDataAccessLayer.Person;
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

namespace DVLDPresentationLayer.User_Controls
{
    public partial class cntrlShowPersonInfo : UserControl
    {
        private int _PersonId;
        public delegate void CloseFormDelegate();
        public CloseFormDelegate CloseForm;
        public cntrlShowPersonInfo()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int personId)
        {
            _PersonId = personId;

            if (_PersonId <= 0)
            {
                MessageBox.Show("Invalid Person ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseForm?.Invoke();
            }

            _LoadData();
        }   
        private void _LoadData()
        {
            clsPersonEntity personInfo = new clsPersonEntity();
            personInfo = clsPerson.FindById(_PersonId);

            if (personInfo != null)
            {
                lblPersonId.Text = personInfo.PersonID.ToString();
                lblName.Text = $"{personInfo.FirstName} {personInfo.SecondName} {personInfo.ThirdName} {personInfo.LastName}";
                lblNationalNo.Text = personInfo.NationalNo;
                lblGender.Text = personInfo.Gendor;
                lblEmail.Text = personInfo.Email;
                lblAddress.Text = personInfo.Address;
                lblDateOfBirth.Text = personInfo.DateOfBirth.ToShortDateString();
                lblPhone.Text = personInfo.Phone;
                lblCountry.Text = personInfo.NationalityCountry;

                if(!string.IsNullOrEmpty(personInfo.ImagePath) && System.IO.File.Exists(personInfo.ImagePath))
                {
                    pbPersonImage.Image = Image.FromFile(personInfo.ImagePath);
                }
            }
            else
            {
                MessageBox.Show("Person not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lnkEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddNewPerson frmEdit = new frmAddNewPerson(_PersonId);
            frmEdit.ShowDialog();
            CloseForm?.Invoke();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cntrlShowPersonInfo_Load(object sender, EventArgs e)
        {
           
        }
    }
}
