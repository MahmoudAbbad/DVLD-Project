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
        public static string UserName { get; set; } = string.Empty;

        public static string Password { get; set; } = string.Empty;

    }
}
