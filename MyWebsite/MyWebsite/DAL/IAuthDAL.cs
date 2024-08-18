using System;
using MyWebsite.DAL.Models;

namespace MyWebsite.DAL;

public interface IAuthDAL
{
    Task<UserModel> GetUser(string email);
    Task<UserModel> GetUser(int id);
    Task<int> CreateUser(UserModel model);
}
