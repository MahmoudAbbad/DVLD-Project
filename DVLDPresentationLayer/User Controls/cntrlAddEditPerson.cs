using DVLDBusinessLogicLayer;
using DVLDDataAccessLayer.Person;
using Microsoft.IdentityModel.Tokens;
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
    public partial class cntrlAddEditPerson : UserControl
    {
        private int _PersonId = -1;
        private string _defaultMaleImage = @"M:\Icons\Icons\Male.png";
        private string _defaultFemaleImage = @"M:\Icons\Icons\Female 512.png";
        private clsPersonEntity _personInfo = new();
        private string _oldImage = string.Empty;

        public delegate void CloseFormDelegate();

        public CloseFormDelegate CloseForm;
        public cntrlAddEditPerson()
        {
            InitializeComponent();
        }

        private void _LoadDataToForm()
        {
            _personInfo = clsPerson.FindById(_PersonId);

            if (_personInfo != null)
            {
                tbFirstName.Text = _personInfo.FirstName;
                tbSecondName.Text = _personInfo.SecondName;
                tbThirdName.Text = _personInfo.ThirdName;
                tbLastName.Text = _personInfo.LastName;
                tbNationalNo.Text = _personInfo.NationalNo;
                dtpDateOfBirth.Value = _personInfo.DateOfBirth;
                if (_personInfo.Gendor == "Male")
                    rbMale.Checked = true;
                else
                {
                    rbMale.Checked = false;
                    rbFemale.Checked = true;
                }
                tbEmail.Text = _personInfo.Email;
                tbAddress.Text = _personInfo.Address;
                tbPhone.Text = _personInfo.Phone;
                if (!string.IsNullOrEmpty(_personInfo.ImagePath))
                {
                    pbPersonImage.ImageLocation = _personInfo.ImagePath;
                    _oldImage = _personInfo.ImagePath;
                    lnkRemove.Visible = true;
                }
                else
                {
                    if (_personInfo.Gendor == "Male")
                    {
                        { if (File.Exists(_defaultMaleImage)) {
                                if (pbPersonImage.Image != null) pbPersonImage.Image.Dispose();
                                pbPersonImage.Image = Image.FromFile(_defaultMaleImage);
                            }
                        } }
                    else
                    {
                        if (File.Exists(_defaultFemaleImage))
                        {
                            if (pbPersonImage.Image != null) pbPersonImage.Image.Dispose();
                            pbPersonImage.Image = Image.FromFile(_defaultFemaleImage);
                        }
                    }
                }
            }
        }
        public void LoadPersonData(int PersonId)
        {
            _PersonId = PersonId;

            if (_PersonId <= 0)
            {
                MessageBox.Show("Invalid Person ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseForm?.Invoke();
                return;
            }

            _LoadDataToForm();
        }
        private void cntrlAddEditPerson_Load(object sender, EventArgs e)
        {
            _ApplyDefaultChanges();
        }
        private void _FillCountryComboBox()
        {
            foreach (DataRow row in clsCountries.GetAllCountries().Rows)
            {
                cbCountry.Items.Add(row["CountryName"].ToString());
            }
        }
        private void _ApplyDefaultChanges()
        {
            dtpDateOfBirth.MaxDate = DateTime.Now - TimeSpan.FromDays(365 * 18);
            rbMale.Enabled = true;
            _FillCountryComboBox();
            int defaultCountryIndex = -1;
            clsCountries.GetCountry(ref defaultCountryIndex, "Jordan");
            cbCountry.SelectedItem = cbCountry.Items[defaultCountryIndex - 1];

        }

        private bool _IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);

                if (mail.Address != email)
                    return false;

                string[] hostParts = mail.Host.Split('.');
                return hostParts.Length >= 2 && hostParts[hostParts.Length - 1].Length >= 2;

            }
            catch
            {
                return false;
            }
        }
        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseForm?.Invoke();
        }

        private bool _IsValidInput(Control control, string errorMessage)
        {
            if (string.IsNullOrEmpty(control.Text))
            {
                WarningError.SetError(control, errorMessage);
                return false;
            }
            else
            {
                WarningError.SetError(control, "");
                return true;
            }
        }

        private bool _IsAllDataValid()
        {
            bool isValid = true;

            if (_PersonId == -1)
            {
                if (clsPerson.IsNationalNoValid(tbNationalNo.Text))
                {
                    WarningError.SetError(tbNationalNo, "");
                }
                else
                {
                    WarningError.SetError(tbNationalNo, "National Number is already exists.");
                    return isValid = false;
                }
            }

            isValid &= _IsValidInput(tbFirstName, "First Name is required.");
            isValid &= _IsValidInput(tbSecondName, "Second Name is required.");
            isValid &= _IsValidInput(tbLastName, "Last Name is required.");
            isValid &= _IsValidInput(tbAddress, "Address is required.");
            isValid &= _IsValidInput(dtpDateOfBirth, "Date of Birth is required.");
            isValid &= _IsValidInput(tbNationalNo, "National Number is required.");
            isValid &= _IsValidInput(tbPhone, "Phone is required.");
            isValid &= _IsValidInput(cbCountry, "Country is required.");
            if (!string.IsNullOrEmpty(tbEmail.Text))
            {
                if (!_IsValidEmail(tbEmail.Text))
                {
                    WarningError.SetError(tbEmail, "Email is not valid.");
                    isValid = false;
                }
                else
                {
                    WarningError.SetError(tbEmail, "");
                }
            }
            return isValid;
        }

        private clsPersonEntity _FillPersonInfoIntoObject()
        {
            clsPersonEntity person = new clsPersonEntity();
            person.FirstName = tbFirstName.Text;
            person.SecondName = tbSecondName.Text;
            person.ThirdName = tbThirdName.Text;
            person.LastName = tbLastName.Text;
            person.NationalNo = tbNationalNo.Text;
            person.DateOfBirth = dtpDateOfBirth.Value;
            person.Gendor = rbMale.Checked ? "Male" : "Female";
            person.Address = tbAddress.Text;
            person.Phone = tbPhone.Text;
            person.Email = tbEmail.Text;
            clsCountries.GetCountry(cbCountry.SelectedIndex + 1, ref person.NationalityCountry);

            if (!String.IsNullOrEmpty(pbPersonImage.ImageLocation))
            {
                person.ImagePath = pbPersonImage.ImageLocation;
            }

            return person;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_IsAllDataValid())
            {
                clsPerson person = new clsPerson();

                person.personInfo = _FillPersonInfoIntoObject();

                if (_PersonId == -1)
                {
                    person.Mode = clsPerson._enMode.AddPerson;
                }
                else
                {
                    person.personInfo.PersonID = _PersonId;
                    person.Mode = clsPerson._enMode.UpdatePerson;
                }
                if (person.Save(_oldImage))
                {
                    MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _personInfo = person.personInfo;
                    _PersonId = _personInfo.PersonID;
                }
                else
                {
                    MessageBox.Show("Failed to save data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Can't Save the data", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(!string.IsNullOrEmpty(pbPersonImage.ImageLocation))
            {
                _oldImage = pbPersonImage.ImageLocation;
            }
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string imagePath = openFileDialog1.FileName;
            if (string.IsNullOrEmpty(imagePath))
                return;

            try
            {
                pbPersonImage.ImageLocation = imagePath;
                lnkRemove.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image");
            }
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            _IsValidInput(tbFirstName, "First Name is required.");
        }

        private void tbSecondName_Validating(object sender, CancelEventArgs e)
        {
            _IsValidInput(tbSecondName, "Second Name is required.");
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            _IsValidInput(tbLastName, "Last Name is required.");
        }

        private void tbNationalNo_Validating(object sender, CancelEventArgs e)
        {
            _IsValidInput(tbNationalNo, "National Number is required.");
        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            _IsValidInput(tbPhone, "Phone is required.");
        }

        private void tbAddress_Validating(object sender, CancelEventArgs e)
        {
            _IsValidInput(tbAddress, "Address is required.");
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbEmail.Text))
            {
                if (!_IsValidEmail(tbEmail.Text))
                {
                    WarningError.SetError(tbEmail, "Email is not valid.");
                }
                else
                {
                    WarningError.SetError(tbEmail, "");
                }
            }
            else
            {
                WarningError.SetError(tbEmail, "");
            }
        }

        private void lnkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.Image = pbPersonImage.InitialImage;
            pbPersonImage.ImageLocation = "";
        }
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pbPersonImage.ImageLocation))
            {
                if (File.Exists(_defaultMaleImage))
                {
                    pbPersonImage.Image = Image.FromFile(_defaultMaleImage);
                }
            }
        }
        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pbPersonImage.ImageLocation))
            {
                if (File.Exists(_defaultFemaleImage))
                {
                    pbPersonImage.Image = Image.FromFile(_defaultFemaleImage);
                }
            }
        }
    }
}