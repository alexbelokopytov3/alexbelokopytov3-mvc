using alexbelokopytov3_mvc.DAL.Models;
using alexbelokopytov3_mvc.DAL;

namespace alexbelokopytov3_mvc.BL.Auth
{
    public class AuthBL : IAuthBL
    {
        private readonly IAuthDAL authDal;
        public AuthBL(AuthDAL authDal)
        {
            this.authDal = authDal;
        }
        public async Task<int> CreateUser(UserModel user)
        {
            return await authDal.CreateUser(user);
        }
    }
}
