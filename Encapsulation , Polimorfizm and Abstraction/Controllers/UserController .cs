

using Encapsulation___Polimorfizm_and_Abstraction.Helpers.Constans;
using Encapsulation___Polimorfizm_and_Abstraction.Service;

namespace Encapsulation___Polimorfizm_and_Abstraction.Controllers
{
    class UserController
    {
        private readonly UserService _userService; 
        public UserController()  // construktor 
        {
            _userService = new UserService();
        }
        public void GetAll()
        {
            var users =_userService.Getall();

            foreach (var user in users )
            {
                string result = $"{user.fullName} - {user.age} - {user.email}";
                Console.WriteLine(result);

            }


        }
        public void GetById()
        {
            Console.WriteLine("Enter user id");
           UserId: string strId= Console.ReadLine();

            int id;

            bool isCorrectId  = int.TryParse(strId, out id);

            if ( isCorrectId )
            {


                var user = _userService.GetById(_userService.Getall(), 3);
                if (user == null)
                {
                    Console.WriteLine(ResponseMessages.Notfound);
                    return;
                }
                string result = $"{user.fullName} - {user.age} - {user.email}";
                Console.WriteLine(result);

            }
            else
            {
                Console.WriteLine(ResponseMessages.IncorrectNumberFormat);
                goto UserId;
            }

            //var user = _userService.GetById(_userService.Getall(), 2);
            //if (user == null)
            //{
            //    Console.WriteLine(ResponseMessages.Notfound);
            //    return;
            //}
            //string result = $"{user.fullName} - {user.age} - {user.email}";
            //Console.WriteLine(result);

        } 

    }
}
