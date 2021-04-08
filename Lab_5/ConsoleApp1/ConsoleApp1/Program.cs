using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver f1 = new Driver();
            f1.Print();
            f1.Meneger();
            f1.Speak(7000);

            Klient b1 = new Klient();
            b1.Print();
            b1.Speak();
            b1.Zakaz();

            Soprovlist d1 = new Soprovlist();
            Console.WriteLine(d1);

            d1.Zakaz();
            d1.Speak();
            d1.KlientSpeak();
            d1.SoprovlistSpeak();

            Klient d2 = new Klient("Алдора", 10000);
            Console.WriteLine(d2);
            d2.Zakaz(15);
            ((IMarshrut)d2).Speak();

            Klient[] klient = new Klient[2] {new Klient ("Bora", 20000), new Klient ("Anta", 15000)};
            Console.WriteLine("/////////////");
            Console.WriteLine("до сортировки");
            Console.WriteLine("/////////////");
            foreach (Klient b in klient)
            {
                b.Print();
            }

            Array.Sort(klient, new CompKlientName());
            Console.WriteLine("/////////////");
            Console.WriteLine("после сортировки по имени");
            Console.WriteLine("/////////////");
            foreach (Klient b in klient)
            {
                b.Print();
            }

            Array.Sort(klient, new CompKlientVes());
            Console.WriteLine("/////////////");
            Console.WriteLine("после сортировки по весу");
            Console.WriteLine("/////////////");
            foreach (Klient b in klient)
            {
                b.Print();
            }

            System.Collections.ArrayList arrayList = new ArrayList();

        }
    }
}
