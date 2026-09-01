using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLogicLayer
{
    public static class clsGlobalUserInfo
    {
        public static int UserId { get; set; }
        public static string UserName {  get; set; }
        public static string Password { get; set; }
        public static bool IsActive { get; set; }
        public static int PersonID { get; set; }
        public static string NationalNo { get; set; }
        public static string FirstName { get; set; }
        public static string SecondName { get; set; }
        public static string ThirdName { get; set; }
        public static string LastName { get; set; }
        public static DateTime DateOfBirth { get; set; }
        public static string Gendor { get; set; }
        public static string Address { get; set; }
        public static string Phone { get; set; }
        public static string Email { get; set; }
        public static string NationalityCountry { get; set; }
        public static string ImagePath { get; set; }

        public static void SetAllUserInfo(int UserId)
        {
            _FillUserInfo(UserId);
         //   _FillPersonInfo(PersonID);

        }
        //private static void _FillPersonInfo(int PersonID)
        //{
        //    clsPerson Person = new clsPerson();
        //        DVLDDataAccessLayer.clsPeopleDataAccess.GetPerson(PersonID,
        //            ref Person.NationalNo,ref Person.FirstName,ref Person.SecondName,
        //            ref Person.ThirdName,ref Person.LastName,ref Person.DateOfBirth,
        //            ref Person.Gendor,ref Person.Address,ref Person.Phone,
        //            ref Person.Email,ref Person.NationalityCountry,ref Person.ImagePath);

        //    FirstName = Person.FirstName;
        //    SecondName = Person.SecondName;
        //    ThirdName = Person.ThirdName;
        //    LastName = Person.LastName;
        //    DateOfBirth = Person.DateOfBirth;
        //    Gendor = Person.Gendor;
        //    Address = Person.Address;
        //    Phone = Person.Phone;
        //    Email = Person.Email;
        //    NationalityCountry = Person.NationalityCountry;
        //    ImagePath = Person.ImagePath;
        //}

        private static void _FillUserInfo(int UserID)
        {
            int _PersonID = 0;
            string _UserName = "";
            string _Password = "";
            bool _IsActive = false;
            
            DVLDDataAccessLayer.clsUsersDataAccess.FindUserByID(UserID,ref _PersonID ,
                ref _UserName , ref _Password,ref _IsActive);

            PersonID = _PersonID;
            UserName = _UserName;
            Password = _Password;
            IsActive = _IsActive;
        }

    }
}
