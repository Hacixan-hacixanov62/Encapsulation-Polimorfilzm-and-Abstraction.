

using System.Security.Cryptography.X509Certificates;

namespace Encapsulation___Polimorfizm_and_Abstraction.Models
{
    internal class Bird : Animal
    {

        public string Color { get; set; } 
        
        public override void Sound()
        {
            //base.Sound(); 
            int a = 100;
            string b = "Reshad";

            Console.WriteLine("Bird sound");

        }

        public override void Test()
        {
            Console.WriteLine("tested");

        }

    }
}
