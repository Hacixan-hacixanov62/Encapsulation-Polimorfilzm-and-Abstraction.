
namespace Encapsulation___Polmorfilzim_and__Abstraction_Homework_Task
{
    internal class User
    {
        public string name;
        public string surName;
        public int age;
        public string password;


        public User()
        {

        }

        public User (string name , string surName, int age)
        {
            this.name = name;   
            this.surName = surName;
            this.age = age;
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }


    }
}
