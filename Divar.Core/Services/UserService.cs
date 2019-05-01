using System;
using System.Collections.Generic;
using System.Text;
using Divar.Core.Interfaces;
using Divar.DataAccessLayer.Entities;
using Divar.DataAccessLayer.Context;
using System.Linq;
using Divar.Core.Classes;

namespace Divar.Core.Services
{
    public class UserService : IUser
    {
        DivarContext _context;

        public UserService(DivarContext context)
        {
            _context = context;
        }

        public bool ActiveUser(string activeCode)
        {
            var user = _context.Users.FirstOrDefault(u => u.IsActive == false && u.Code == activeCode);

            if (user != null)
            {
                user.Code = CodeGenerators.ActiveCode();
                user.IsActive = true;

                _context.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }

        public int AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return user.Id;
        }

        public bool ChangePassword(string mobileNumber, string currentPass, string password)
        {
            string HashCurrentPassword = HashGenerators.EncodingPassWithMD5(currentPass);

            var user = _context.Users.FirstOrDefault(u => u.Mobile == mobileNumber && u.Password == HashCurrentPassword);

            if (user != null)
            {
                string HashNewPassword = HashGenerators.EncodingPassWithMD5(password);

                user.Password = HashNewPassword;

                _context.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }

        public User ForgetPassword(string mobileNumber)
        {
            return _context.Users.FirstOrDefault(u => u.Mobile == mobileNumber);
        }

        public int GetUserId(string mobileNumber)
        {
            var user = _context.Users.FirstOrDefault(u => u.Mobile == mobileNumber);

            return user.Id;
        }

        public bool IsMobileNumberExist(string mobileNumber)
        {
            return _context.Users.Any(u => u.Mobile == mobileNumber);
        }

        public User LoginUser(string mobileNumber, string password)
        {
            string HashPassword = HashGenerators.EncodingPassWithMD5(password);

            return _context.Users.FirstOrDefault(u => u.Mobile == mobileNumber && u.Password == HashPassword);
        }

        public bool ResetPassword(string activeCode, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Code == activeCode && u.IsActive == true);

            if (user != null)
            {
                string HashPassword = HashGenerators.EncodingPassWithMD5(password);

                user.Password = HashPassword;
                user.Code = CodeGenerators.ActiveCode();

                _context.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
