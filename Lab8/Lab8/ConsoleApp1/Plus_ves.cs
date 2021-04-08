using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Plus_ves
    {
        public static void plus_weight(double ves)
        {
            if (ves > 15)
                Console.WriteLine("Питомец переедает, его вес больше 15 кг: {0} кг", ves);
        }
    }
}
