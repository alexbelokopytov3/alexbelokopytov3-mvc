

namespace alexbelokopytov3_mvc.BL.Auth
{
    public interface IAuthBL
    {
        Task<int> CreateUser(alexbelokopytov3_mvc.DAL.Models.UserModel user);
    }
}
