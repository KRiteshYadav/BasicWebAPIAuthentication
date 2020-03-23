using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthenticationWebAPI.Models
{
    public class UserValidate
    {
        public static bool Login(string username , string password)
        {
            UserBL userBl = new UserBL();
            var UserLists = userBl.GetUsers();
            return UserLists.Any(user => user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase) && user
            .Password == password);
        }
    }
}