using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       static void Main(string[] args)
        {
            
            Pet pet1 = new Pet("Тарантино", 5, 2.5, new int[] { 7, 7, 7, 7 });
            Console.WriteLine(pet1);
            delegat_1 del_1=()=> speaking(); //Используйте лямбда-выражения
            del_1 += delegate () { Console.WriteLine("Анонимный делегат"); };
            pet1.zapolnenie(del_1);
            pet1.zapusk_1();
            Console.WriteLine();
            //del_1 уже групповой делегат
            
            del_1 += speaking2;
            
            // f.	Сделайте питомца, который говорит всеми возможными способами
            int[] m = new int[] { 6, 6, 6, 6 };
            Pet pet2 = new Pet("Лиза Мей", 5, 2.5, m);
            Console.WriteLine(pet2);
            pet2.zapolnenie(() => speaking3());//Используйте лямбда-выражения
            pet2.zapolnenie(del_1);
            pet2.zapusk_1();
            Console.WriteLine();

            pet2.compare_delegat_1(pet1);
            Console.WriteLine();

            Pet pet3 = new Pet("Мерлин", 5, 2.5, 5, 5, 3, 4);
            Console.WriteLine(pet3);
            //анонимный делегат
            pet3.zapolnenie(delegate (double ves)
            {
                Console.WriteLine("Питомец {0} похудел на 2 кг и весит теперь {1} кг", pet3.name, ves - 2);
            });
            pet3.zapusk_2();
            Console.WriteLine();

            
            Pet pet4 = new Pet("Феллини", 5, 6.5, 9, 8);
            Console.WriteLine(pet4);
            pet4.zapolnenie((double ves) => weight_plus(pet4.Weight));
            pet4.zapusk_2();
            Console.WriteLine();

            Minus_ves minus_Ves = new Minus_ves();
            pet3.SomeEvent += minus_Ves.minus_weight;
            pet3.SomeEvent += Plus_ves.plus_weight;
            pet3.Weight=0.3;
            pet3.SomeEvent -= minus_Ves.minus_weight;
            // •	Статический метод любого класса
            pet3.SomeEvent += weight_plus;
            // •	Экземплярный метод собственного класса
            pet3.SomeEvent += pet3.weight_pet;
            pet3.Weight = 12;
            //•	Анонимный делегат
            pet4.SomeEvent += delegate (double ves) { Console.WriteLine("Анонимно увеличили вес питомца {0} в 2 раза, вес составил {1} кг", pet4.name, ves * 2); };
            //•	Лямбда-выражение
            pet4.SomeEvent += (double ves) => Console.WriteLine("Используя лямбда-выражение уменьшили вес питомца {0} в 5 раз, вес составил {1} кг", pet4.name, ves / 5);
            pet4.Weight = 15;

            Console.ReadKey();

        }

        public static void speaking()
        {
            Console.WriteLine("- Я питомец!");
        }

        public static void speaking2()
        {
            Console.WriteLine("- Я питомец! Я умею разговаривать!");
        }
        public static void speaking3()
        {
            Console.WriteLine("- Я питомец! Я умею разговаривать! Разговариваю очень много!");
        }

        public static void weight_plus(double ves)
        {
            Console.WriteLine("Питомец потолстел на 5 кг и весит теперь "+ (ves+5)+" кг");
        }

    }
}
