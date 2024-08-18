using System;
using MyWebsite.ViewModels;
using MyWebsite.DAL.Models;

namespace MyWebsite.ViewMapper
{
    public class AuthMapper
    {
        public static UserModel MapRegisterViewModelToUserModel(RegisterViewModel model)
        {
            return new UserModel()
            {
                Email = model.Email!,
                Password = model.Password!
            };
        }
    }
}
