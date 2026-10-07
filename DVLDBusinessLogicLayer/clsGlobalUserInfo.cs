using DVLDDataAccessLayer.Person;
using DVLDDataAccessLayer.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLogicLayer
{
    public static class clsGlobalUserInfo
    {
        public static clsUsers CurrentUser { get; set; } = new();

        public static void SetCurrentUser(clsUserEntity UserEntity)
        {
            CurrentUser = new clsUsers();
            CurrentUser.userInfo = UserEntity;
        }

    }
}
