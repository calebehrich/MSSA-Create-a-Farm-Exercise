using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAFarm
{
    class Cow
    {
        public void DisplayCow()
        {
            CowSpeak();
            CowEat();
            CowProduct();
            CowHome();
        }
        public void CowSpeak()
        {
            Console.WriteLine("My name is Carlos the Cow. I say Mooooooooo." + "\n");
        }

        public void CowEat()
        {
            Console.WriteLine("I love to eat grass and grains. Yummmmm!" + "\n");
        }

        public void CowProduct()
        {
            Console.WriteLine("I provide beef for Humans. Eat Mor Chikin." + "\n");
        }

        public void CowHome()
        {
            Console.WriteLine("I live in the barn on the farm.");
        }
    }
}
