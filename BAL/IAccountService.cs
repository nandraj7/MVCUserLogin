using MVCUserLogin.Models;

namespace MVCUserLogin.BAL
{
    public interface IAccountService
    {
        public void AddUser(AddViewModel addvm);
    }
}
