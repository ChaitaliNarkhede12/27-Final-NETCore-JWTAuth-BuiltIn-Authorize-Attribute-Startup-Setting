using Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IUserService
    {
        UserModel GetUserDetails(LoginModel loginModel);
    }
}
