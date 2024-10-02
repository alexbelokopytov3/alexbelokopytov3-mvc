using alexbelokopytov3_mvc.DAL.Models;

namespace alexbelokopytov3_mvc.DAL
{
    public interface IAuthDAL
    {
        Task<UserModel> GetUser(string email);
        Task<UserModel> GetUser(int id);
        Task<int> CreateUser(UserModel model);
    }

}

