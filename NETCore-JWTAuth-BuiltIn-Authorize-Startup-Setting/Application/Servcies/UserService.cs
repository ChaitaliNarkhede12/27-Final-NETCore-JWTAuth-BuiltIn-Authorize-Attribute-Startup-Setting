using Application.Interfaces;
using Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Servcies
{
    public class UserService : IUserService
    {
        public UserModel GetUserDetails(LoginModel loginModel)
        {
            if (loginModel != null && loginModel.UserName == "admin" && loginModel.Password == "abc")
            {
                UserModel user = new UserModel()
                {
                    UserId = 1,
                    Name = "Admin",
                    Email = "admin@gmail.com",
                    UserName = "admin",
                    Password = "abc"
                };

                return user;
            }
            return null;
        }
    }
}

