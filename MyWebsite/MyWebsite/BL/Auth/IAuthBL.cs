using System;

namespace MyWebsite.BL.Auth
{
    public interface IAuthBL
    {
        Task<int> CreateUser(MyWebsite.DAL.Models.UserModel user);
    }
}
