using System;
using System.Collections.Generic;
using System.Text;
using Divar.DataAccessLayer.Entities;

namespace Divar.Core.Interfaces
{
    public interface IUser
    {
        bool IsMobileNumberExist(string mobileNumber);

        int AddUser(User user);

        User LoginUser(string mobileNumber, string password);

        bool ActiveUser(string activeCode);

        User ForgetPassword(string mobileNumber);

        bool ResetPassword(string activeCode, string password);

        bool ChangePassword(string mobileNumber, string currentPass, string password);

        int GetUserId(string mobileNumber);
    }
}
