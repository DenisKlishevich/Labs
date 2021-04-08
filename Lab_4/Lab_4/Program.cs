using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Neprodtov poroshok = new Neprodtov (" Tide", 10, 50);
            Console.WriteLine("Стиральный порошек" + poroshok.Name + " количество " + poroshok.Quantity + " мешков " + "весом " + poroshok.Weight + " кг.");

            Neprodtov mulo = new Neprodtov(" Camay", 15, 25);
            Console.WriteLine("Мыло" + mulo.Name + " количество " + mulo.Quantity + " кусков " + "весом " + mulo.Weight + " кг.");

            //Tovary t = new Tovary { Name = "Товары" };
            //t.Remont();
            //t = new Neprodtov. //{ Name = "Стиральныцй порошек" };
            //t.Name();
            Console.ReadKey();
        }
    }

}
