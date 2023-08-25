using MVCUserLogin.Models;

namespace MVCUserLogin.BAL
{
    public interface ILoginService
    {
        public UserViewModel GetUser(LoginViewModel loginVM);
    }
}
