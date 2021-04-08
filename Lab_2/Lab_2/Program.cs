using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Polinom polinom1;
            Polinom polinom2;
            polinom1 = new Polinom(10, 20, 30);
            polinom2 = new Polinom();
            Console.WriteLine(polinom1);
            polinom1.a = 15;
            Console.WriteLine(polinom1);
            Console.WriteLine(polinom2);
            polinom2[0] = 20;
            polinom2[1] = 30;
            polinom2[2] = 40;
            Console.WriteLine(polinom2);
            Console.WriteLine(polinom1 + polinom2);//Оператор сложения
            Console.WriteLine(polinom1 - polinom2);//Оператор вычитания
            Console.WriteLine(polinom1++);//Оператор ин
            Console.WriteLine(polinom2++);
            Console.WriteLine(polinom1--);
            Console.WriteLine(polinom2++);
            Console.WriteLine(polinom1 * polinom2);//Оператор умножения
            Console.WriteLine(polinom1 / polinom2);//Оператор деления
            Console.WriteLine(polinom1 == polinom2);//Сравнение на равенство
            Console.WriteLine(polinom1 != polinom2);//Сравнение на неравенство
            Console.WriteLine();//Сравнение на равенство
            if (polinom1)
                Console.WriteLine("polinom1 - истина");
            double x = (double)polinom1;

            polinom2 = x;






            Console.ReadKey();
        }
    }
}
