using MVCUserLogin.DAL;
using MVCUserLogin.Models;

namespace MVCUserLogin.BAL
{
    public class LoginService : ILoginService
    {
        private readonly MvcloginUserContext db;

        public LoginService(MvcloginUserContext _db)
        {
            this.db = _db;
        }

        public UserViewModel GetUser(LoginViewModel loginVM)
        {
            var user = db.Users.FirstOrDefault(option => option.Email == loginVM.Email
                                               && option.Password == loginVM.Password);

            UserViewModel userVM = new UserViewModel();

            if (user != null)
            {
                userVM.Name = user.Name;
                userVM.Email = user.Email;
                userVM.Password = user.Password;

            }
            return userVM;
        }
    }
}
