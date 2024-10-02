namespace alexbelokopytov3_mvc.ViewModels
{
    public class RegisterViewModel
    {
        public string? Email { get; set; }
        public string? Password { get; set; }

        /*
         * Если не использовать ViewMapper
        public alexbelokopytov3_mvc.DAL.Models.UserModel ToDalModel()
        {
            return new alexbelokopytov3_mvc.DAL.Models.UserModel()
            {
                Email = this.Email,
                Password = this.Password
            };
        }
        */
    }
}
