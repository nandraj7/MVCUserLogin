using MVCUserLogin.DAL;
using MVCUserLogin.Models;

namespace MVCUserLogin.BAL
{
    public class AccountService : IAccountService
    {
        private readonly MvcloginUserContext db;

        public AccountService(MvcloginUserContext _db)
        {
            this.db = _db;
        }

        public void AddUser(AddViewModel addvm)
        {
            User user = new User();

            user.Name = addvm.Name;
            user.Email = addvm.Email;
            user.Age = addvm.Age;
            user.MobileNumber = addvm.MobileNumber;
            user.Password = addvm.Password;

            db.Users.Add(user);
            db.SaveChanges();
        }

        
    }
}
