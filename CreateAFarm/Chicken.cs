using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAFarm
{
    class Chicken
    {
        public void DisplayChicken()
        {
            ChickenSpeak();
            ChickenEat();
            ChickenProduct();
            ChickenHome();
        }

        public void ChickenSpeak()
        {
            Console.WriteLine("My name is Cassie the Chicken. I say cluck." + "\n");
        }

        public void ChickenEat()
        {
            Console.WriteLine("I eat grains and seeds." + "\n");
        }

        public void ChickenProduct()
        {
            Console.WriteLine("I lay eggs for humans to eat for breakfast." + "\n");
        }

        public void ChickenHome()
        {
            Console.WriteLine("I live in the chicken coop on the farm.");
        }
    }
}
