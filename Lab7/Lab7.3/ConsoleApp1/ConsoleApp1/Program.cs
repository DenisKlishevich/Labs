using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static StringBuilder F1(StringBuilder str_b)
        {
            str_b.Remove(0, str_b.Length);
            Console.WriteLine("Введите количество символов в строке: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите строку: ");
            string str = Convert.ToString(Console.ReadLine());
            str_b.Append(str);
            str_b.Remove(length, (str_b.Length - length));
            return str_b;
        }
        static void F2(StringBuilder str_b)
        {// вывод строки
            Console.WriteLine(str_b);
        }

        static void F3(StringBuilder str_b)
        {// после указанного символа каждый раз вставить *
            Console.WriteLine("Введите символ, после которого нужно вставить '*': ");
            string ch1 = Convert.ToString(Console.ReadLine());
            //for (int i=0; i<str_b.Length; i++)
            string str = ch1 + "*";
            str_b.Replace(ch1, str);
         

        }

        static void F4(StringBuilder str_b)
        {//заменить один символ на другой
            Console.WriteLine("Введите символ, который нужно заменить: ");
            char ch1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите символ, на который нужно заменить: ");
            char ch2 = Convert.ToChar(Console.ReadLine());
            str_b.Replace(ch1, ch2);
        }

        static void F5(StringBuilder str_b)
        {//удалить все вхождения указанной подстроки
            Console.WriteLine("Введите строку, которую нужно удалить: ");
            string stroka = Convert.ToString(Console.ReadLine());
            string stroka2 = "";
            str_b.Replace(stroka, stroka2);
        }


        static void Main(string[] args)
        {
            StringBuilder str_b1 = new StringBuilder("Hello, Belarus!");
            Console.WriteLine("***************Главное меню***************");
            Console.WriteLine("1 – ввод строки с клавиатуры (указывать размер)");
            Console.WriteLine("2 – вывод строки");
            Console.WriteLine("3 – после указанного символа каждый раз вставить *");
            Console.WriteLine("4 – заменить один символ на другой");
            Console.WriteLine("5 – удалить все вхождения указанной подстроки");
            Console.WriteLine("0 – выход");
            while (true)
            {
                Console.WriteLine("Выберите действие: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        F1(str_b1);
                        break;
                    case 2:
                        F2(str_b1);
                        break;
                    case 3:
                        F3(str_b1);
                        break;
                    case 4:
                        F4(str_b1);
                        break;
                    case 5:
                        F5(str_b1);
                        break;
                   case 0: return;
                }
            }
        }
    }
}
