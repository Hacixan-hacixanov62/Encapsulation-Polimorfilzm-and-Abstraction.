

using System.Diagnostics.Contracts;

namespace Encapsulation___Polimorfizm_and_Abstraction.Models
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public int MyProperty { get; set; }

        public Animal()
        {

        }


        public abstract  void Test(); 


        public virtual void   Sound()
        {
            Console.WriteLine("Animal sound");
             
        }
    }
}
