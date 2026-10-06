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
        public cntrlShowPersonInfo()
        {
            InitializeComponent();
        }

        private void _ResetDefaultValues()
        {
            lblPersonId.Text = "N/A";
            lblName.Text = "[???]";
            lblNationalNo.Text = "[???]";
            lblGender.Text = "[???]";
            lblEmail.Text = "[???]";
            lblAddress.Text = "[???]";
            lblDateOfBirth.Text = "[???]";
            lblPhone.Text = "[???]";
            lblCountry.Text = "[???]";
            pbPersonImage.Image = Image.FromFile(@"M:\Icons\Icons\Male.png");
        }

        public void LoadPersonInfoByPersonId(int personId)
        {
            _PersonId = personId;

            if (_PersonId <= 0 || _PersonId == null)
            {
                MessageBox.Show("Invalid Person ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetDefaultValues();
                return;
            }

            clsPersonEntity personInfo = new clsPersonEntity();
            personInfo = clsPerson.FindById(_PersonId);

            if(personInfo != null)
            {
                _LoadData(personInfo);
            }
            else
            {
                MessageBox.Show("Person not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetDefaultValues();
            }
        }   
        public void LoadPersonInfoByNationalNo(string nationalNo)
        {
            if (string.IsNullOrEmpty(nationalNo))
            {
                MessageBox.Show("Invalid National No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetDefaultValues();
                return;
            }
            clsPersonEntity personInfo = clsPerson.FindByNationalNo(nationalNo);
            if (personInfo != null)
            {
                _PersonId = personInfo.PersonID;
                _LoadData(personInfo);
            }
            else
            {
                MessageBox.Show("Person not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetDefaultValues();
            }
        }
        private void _LoadData(clsPersonEntity personInfo)
        {

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
                else
                {
                    if(personInfo.Gendor == "Male")
                    {
                        pbPersonImage.Image = Image.FromFile(@"M:\Icons\Icons\Male.png");
                    }
                    else if (personInfo.Gendor == "Female")
                    {
                        pbPersonImage.Image = Image.FromFile(@"M:\Icons\Icons\Female 512.png");
                    }
                }
            }
            else
            {
                MessageBox.Show("Person not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void lnkEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_PersonId <= 0)
            {
                MessageBox.Show("Invalid Person ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmAddNewPerson frmEdit = new frmAddNewPerson(_PersonId);
            frmEdit.ShowDialog();
            _LoadData(clsPerson.FindById(_PersonId));
        }
    }
}
