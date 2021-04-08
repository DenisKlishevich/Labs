using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel Orbita = new Hotel("Орбита", 3);
            Hotel Sputnik = new Hotel("Спутник", 6);

            Guest guest1 = new Guest("Иванов Н.В.", "м");
            Guest guest2 = new Guest("Петров Ю.Ф.", "м");
            Guest guest3 = new Guest("Сидоров К.Т.", "м");
            Guest guest4 = new Guest("Васильева И.Д.", "ж");
            Guest guest5 = new Guest("Марченко У.Н.", "ж");
            Guest guest6 = new Guest("Мухина Г.С.", "ж");

            Console.WriteLine("Гость " + guest1 + " заселяется в отель " + Orbita.name);
            guest1.reception(Orbita);

            Console.WriteLine("Гость " + guest2 + " заселяется в отель " + Orbita.name);
            guest2.reception(Orbita);

            Console.WriteLine("Гость " + guest3 + " заселяется в отель " + Orbita.name);
            guest3.reception(Orbita);

            Console.WriteLine("Список гостей в " + Orbita);
            Orbita.spisokguest();

            Console.WriteLine("Гость " + guest2 + " пытается заселяется в отель " + Orbita.name);
            if (guest2.reception(Orbita) == 3)
            {
                Console.WriteLine("Гость " + guest2 + " уже заселен в отель " + Orbita.name);
            }

            Console.WriteLine("Гость " + guest4 + " пытается заселяется в отель " + Orbita.name);
            if (guest4.reception(Orbita) == 2)
            {
                Console.WriteLine("Гость " + guest4 + " не может заселиться в отель " + Orbita.name + ", отель полон");

                Console.WriteLine("Гость " + guest4 + " заселяется в отель " + Sputnik.name);
                Sputnik.zaselenie(guest4);
            }
            Sputnik.zaselenie(guest5);
            Sputnik.zaselenie(guest6);

            Console.WriteLine("Список гостей в " + Orbita);
            Orbita.spisokguest();

            Console.WriteLine("Список гостей в " + Sputnik);
            Sputnik.spisokguest();

            Console.WriteLine("Гость " + guest1 + " выселяется из отеля " + Orbita.name);
            Orbita.vyselenie(guest1);

            Console.WriteLine("Список гостей в " + Orbita);
            Orbita.spisokguest();

            Console.ReadKey();
        }
    }
}
