using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer.Users;
namespace DVLDBusinessLogicLayer
{
    public class clsUsers
    {
        public clsUserEntity userInfo = new clsUserEntity();
        public clsUsers() {

            userInfo.UserID = -1;
            userInfo.PersonID = -1;
            userInfo.UserName = string.Empty;
            userInfo.Password = string.Empty;
            userInfo.IsActive = false;
        }
        public clsUsers(int UserId , int Personid, string UserName , string Password , bool IsActive)
        {
            userInfo.UserID = UserId;
            userInfo.PersonID = Personid;
            userInfo.UserName = UserName;
            userInfo.Password = Password;
            userInfo.IsActive = IsActive;
        }

        public clsUserEntity CheckIfUserNameAndPassTrue(string UserName, string Password)
        {
            return (clsUsersDataAccess.FindUserByUserNameAndPass(UserName, Password));
        }

        public static DataTable GetAllUsers()
        {
            return clsUsersDataAccess.GetAllUsers();
        }

        public clsUserEntity FindUserByUserId(int UserId)
        {
            return clsUsersDataAccess.FindUserByID(UserId);
        }

        public void FillUserInGlobalClass()
        {
            clsGlobalUserInfo.UserName = userInfo.UserName;
            clsGlobalUserInfo.Password = userInfo.Password;
        }

    }
}
