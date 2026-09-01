using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;
namespace DVLDBusinessLogicLayer
{
    public class clsUsers
    {
        public int UserID;
        public int PersonID;
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool IsActive; 

        public clsUsers() { 
        
            UserID = -1;
            PersonID = -1;
            UserName = "";
            Password = "";
            IsActive = false;
        }
        public clsUsers(int UserId , int Personid, string UserName , string Password , bool IsActive)
        {
            this.UserID = UserId;
            this.PersonID = Personid;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
        }

        public bool CheckIfUserNameAndPassTrue(string UserName, string Password)
        {
            return (DVLDDataAccessLayer.clsUsersDataAccess.FindUserByUserNameAndPass(ref UserID, ref PersonID, UserName, Password, ref IsActive));
        }

        public void FillUserInGlobalClass()
        {
            clsGlobalUserInfo.SetAllUserInfo(UserID);
        }

        public static DataTable GetAllUsers()
        {
            return DVLDDataAccessLayer.clsUsersDataAccess.GetAllUsers();
        }

    }
}
