
using Encapsulation___Polimorfizm_and_Abstraction.Service;

namespace Encapsulation___Polimorfizm_and_Abstraction.Services
{
    internal class AccountService
    {
        public readonly UserService _userService;

        public AccountService()
        {
            _userService = new UserService();

        }

        public bool Login (string email,string password)
        {
            var users = _userService.Getall();
            return users.Any (m => m.email == email && m.password == password);
            
        }
    
    
    }
}
