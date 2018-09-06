using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAFarm
{
    class Pig
    {
        public void DisplayPig()
        {
            PigSpeak();
            PigEat();
            PigProduct();
            PigHome();
        }

        public void PigSpeak()
        {
            Console.WriteLine("My name is Penny the Pig. I say Oink." + "\n");
        }

        public void PigEat()
        {
            Console.WriteLine("I will eat ANYTHING! Put it in my trough and I promise it will be gone." + "\n");
        }

        public void PigProduct()
        {
            Console.WriteLine("I produce pork for humans. Shhhh...Don't tell PETA." + "\n");
        }
        
        public void PigHome()
        {
            Console.WriteLine("I live in the pigpen on the farm.");
        }
    }
}
