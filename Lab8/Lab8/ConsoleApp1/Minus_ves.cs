using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Minus_ves
    {
        public void minus_weight(double ves)
        {
            if (ves < 1)
                Console.WriteLine("Питомец слишком худой, весит меньше 1 кг: {0} кг", ves);
        }
    }
}
