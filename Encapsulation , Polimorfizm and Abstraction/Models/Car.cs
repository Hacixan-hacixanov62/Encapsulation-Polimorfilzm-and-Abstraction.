

namespace Encapsulation___Polimorfizm_and_Abstraction.Models
{
    class Car
    {
        public string name;
        public int speed;
        private string color = "red" ;
        public string Color  {
             
            get

            {
                if (speed > 400)
                {
                    return color;
                }
                return null;
            }

            set
            {
                color = value;
            }
        
        }
         

    }
}
