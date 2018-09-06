using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAFarm
{
    class Program
    {

        static void Main(string[] args)
        {
            Animals farm = new Animals();

            try
            {
                farm.AnimalSelect();
            }
            catch (Exception)
            {
                Console.WriteLine("Error occurred. Please close program and fix error.");
            }


        }
    }
}
