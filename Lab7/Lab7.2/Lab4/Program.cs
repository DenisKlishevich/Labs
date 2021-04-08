using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            // проект2
           Triangle tr1 = new Triangle("Treugolnik", 5, 10);
           Console.WriteLine("Вывод только что созданного треугольника");
           Console.WriteLine(tr1);                    // вывели треугольник
           Triangle.SaveClass("Triangle.txt");     // сохранили в файл информацию о классе
           Console.WriteLine("Сохранили информацию о классе");
           tr1.SaveObject("l1.bin");        // сохранили в файл информацию об объекте
           Console.WriteLine("Сохранили информацию об объекте");
           tr1.name = "TRIANGLE 2.0";
           tr1.height = 10;
           tr1.base_tr = 15;           // изменили объект
           Console.WriteLine("Изменили треугольник:");
           Console.WriteLine(tr1);                   // вывели треугольник
            tr1 = Triangle.LoadObject("l1.bin"); // прочитали объект
           Console.WriteLine("Прочитали сохраненное значение треугольника");
           Console.WriteLine(tr1);                   // вывели треугольник
            tr1.Serialize("l2.bin");
           Console.WriteLine("Сериализовали треугольник:");
            tr1.name = "TRN 3.0";
            tr1.height = 20;
            tr1.base_tr = 30;                       // изменили объект
            Console.WriteLine("Изменили треугольник:");
           Console.WriteLine(tr1);                    // вывели треугольник
            tr1 = Triangle.Deserialize("l2.bin");
           Console.WriteLine("Десериализовали треугольник:");
           Console.WriteLine(tr1);                    // вывели треугольник

            Console.ReadKey();
        }
    }
}
