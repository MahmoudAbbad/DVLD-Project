using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer.Person
{
    public class clsPersonEntity
    {
        public int PersonID = -1;
        public string NationalNo = string.Empty;
        public string FirstName = string.Empty;
        public string SecondName = string.Empty;
        public string ThirdName = string.Empty;
        public string LastName = string.Empty;
        public DateTime DateOfBirth = DateTime.MinValue;
        public string Gendor = string.Empty;
        public string Address = string.Empty;
        public string Phone = string.Empty;
        public string Email = string.Empty;
        public string NationalityCountry = string.Empty;
        public string ImagePath = string.Empty;

        public clsPersonEntity()
        {

        }

        public clsPersonEntity(int personID, string nationalNo, string firstName, string secondName,
            string thirdName, string lastName, DateTime dateOfBirth, string gendor, string address,
            string phone, string email, string nationalityCountry, string imagePath)
        {
            PersonID = personID;
            NationalNo = nationalNo;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gendor = gendor;
            Address = address;
            Phone = phone;
            Email = email;
            NationalityCountry = nationalityCountry;
            ImagePath = imagePath;
        }

    }
}
