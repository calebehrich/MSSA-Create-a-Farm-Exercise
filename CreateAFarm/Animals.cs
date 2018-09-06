using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAFarm
{
    class Animals
    {
        Horse pony = new Horse();
        Cow calf = new Cow();
        Pig piglet = new Pig();
        Chicken chick = new Chicken();

        public void FarmAnimal()
        {
            Console.WriteLine("Which animal to you want to learn about?");
            Console.WriteLine("Type horse, cow, pig, chicken or exit");
        }

        public void AnimalSelect()
        {
            do
            {
                FarmAnimal();
                

                string userSelection = Console.ReadLine();
                Console.WriteLine("\n");
                switch (userSelection)
                {
                    case "horse":
                        pony.DisplayHorse();
                        break;
                    case "cow":
                        calf.DisplayCow();
                        break;
                    case "pig":
                        piglet.DisplayPig();
                        break;
                    case "chicken":
                        chick.DisplayChicken();
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please make a selection.");
                        break;
                }

                Console.ReadLine();
                Console.Clear();
            }
            while (true);

        }
    }
}
