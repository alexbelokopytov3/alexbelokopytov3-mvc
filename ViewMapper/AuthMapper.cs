using alexbelokopytov3_mvc.DAL.Models;
using alexbelokopytov3_mvc.ViewModels;

namespace alexbelokopytov3_mvc.ViewMapper
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
