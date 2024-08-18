using MyWebsite.DAL.Models;
using MyWebsite.DAL;

namespace MyWebsite.BL.Auth
{
    public class AuthBL : IAuthBL
    {
        private readonly IAuthDAL authDal;

        public AuthBL(IAuthDAL authDal) 
        { 
            this.authDal = authDal;
        }

        public async Task<int> CreateUser(UserModel user)
        {
            authDal.CreateUser(user);
            throw new NotImplementedException();
        }
    }
}
