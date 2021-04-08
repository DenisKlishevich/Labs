using System;
using System.IO;
namespace Lab7
{
    class Program
    {
        static DirectoryInfo f1(ref DirectoryInfo b) 
        {// установить текущий диск/каталог
            string catalog = Convert.ToString(Console.ReadLine());
            DirectoryInfo dir = new DirectoryInfo(@catalog);
            return b;
        }
        static void f2(DirectoryInfo b)
        {// вывод списка всех каталогов в текущем (пронумерованный)
            DirectoryInfo[] dir = b.GetDirectories();
            Console.WriteLine("Каталоги");
            for (int i=0, a=1; i<dir.Length; i++, a++)
            {
                Console.WriteLine(a+". "+dir[i]);
            }
            Console.WriteLine();
        }
        static void f3(DirectoryInfo b)
        {// вывод списка всех файлов в текущем каталоге (пронумерованнный)
            FileInfo[] file = b.GetFiles();
            Console.WriteLine("Файлы:");
            for (int i = 0, a = 1; i < file.Length; i++, a++)
            {
                Console.WriteLine(a + ". " + file[i]);
            }
            Console.WriteLine();
        }
        static void f4(DirectoryInfo b)
        {// вывод на экран содержимого указанного файла (по номеру)
            f3(b);
            Console.WriteLine("Введите номер файла:");
            int index = Convert.ToInt32(Console.ReadLine());
            index = index - 1;
            FileInfo[] files = b.GetFiles();
            if (files[index].Extension != ".txt")
            {
                Console.WriteLine("Это не текстовый файл!");
                return;
            }
            StreamReader sr = new StreamReader(files[index].FullName);
            string str = sr.ReadToEnd();
            Console.WriteLine(str);
            sr.Close();
        }
        static void f5(DirectoryInfo b)
        {// создание каталога в текущем
            Console.WriteLine("Введите название создаваемого каталога:");
            string catalog = Convert.ToString(Console.ReadLine());
            b.CreateSubdirectory(@catalog);
        }
        static void f6(DirectoryInfo b)
        {// удаление каталога по номеру, если он пустой
            f2(b);
            DirectoryInfo[] dir = b.GetDirectories();
            Console.WriteLine("Введите номер каталога, который необходимо удалить:");
            int number = Convert.ToInt32(Console.ReadLine());
            int index = number - 1;
            if (dir[index].Exists)
            {
                if (dir[index].GetDirectories().Length == 0 && dir[index].GetFiles().Length == 0)
                { dir[index].Delete(); }
                else
                    Console.WriteLine("Каталог под номером " + number + " не пуст!");
            }
            else
             Console.WriteLine("Каталога под номером " + number + " не существует");

        }
        static void f7(DirectoryInfo b)
        {// удаление файлов с указанными номерами
            int var;
            do
            {
                f3(b);
                Console.WriteLine("Введите номер файла для удаления:");
                int number = Convert.ToInt32(Console.ReadLine());
                int index1 = number - 1;
                FileInfo[] files = b.GetFiles();
                if (index1 > files.Length)
                {
                    Console.WriteLine("файл под таким номером отсутствует");
                    return;
                }
                files[index1].Delete();
                Console.WriteLine("Файл № " + number + " удален");
                Console.WriteLine("Нажмите 1, чтобы продолжить удаление файлов");
                var = Convert.ToInt32(Console.ReadLine());
            }
            while (var == 1);
            return;

        }
        static void f8(DirectoryInfo b)
        {// вывод списка всех файлов с указанной датой создания (ищет в текущем каталоге и подкаталогах)
            FileInfo[] files = b.GetFiles("*"); //,SearchOption.AllDirectories);  - для поиска по всем каталогам
            Console.WriteLine("Введите дату:");
            string date = Convert.ToString(Console.ReadLine());

            foreach(FileInfo file in files)
            {
                string[] Dates;
                string FileTemp = Convert.ToString(file.CreationTime);
                Dates = FileTemp.Split(' ');
                if (Dates[0]==date)
                {
                    Console.WriteLine("Файл :"+file.Name+ " создан " + file.CreationTime);
                }
            }
        }

        static void f9(DirectoryInfo b)
        {// вывод списка всех текстовых файлов, в которых содержится указанный текст (ищет в текущем каталоге и подкаталогах)
            Console.WriteLine("Введите текст для поиска в файлах");
            string str = Convert.ToString(Console.ReadLine());
            FileInfo[] files = b.GetFiles("*.txt"); //, SearchOption.AllDirectories);    - для поиска по всем каталогам
            int i = 0;
            foreach (FileInfo x in files)
            {
                if (x.Extension != ".txt") continue;
                StreamReader sr = new StreamReader(x.FullName);
                string buf = sr.ReadToEnd();
                if (buf.Contains(str))
                Console.WriteLine(++i + ". " + x.DirectoryName + "\\" + x.Name);
                Console.WriteLine();
            }
        }

                     
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"B:\\"); // текущий каталог
            try
            {
                    Console.WriteLine("***************Главное меню***************");
                    Console.WriteLine("1 – установить текущий диск/каталог");
                    Console.WriteLine("2 – вывод списка всех каталогов в текущем");
                    Console.WriteLine("3 – вывод списка всех файлов в текущем каталоге");
                    Console.WriteLine("4 – вывод на экран содержимого указанного файла ");
                    Console.WriteLine("5 – создание каталога в текущем");
                    Console.WriteLine("6 – удаление каталога по номеру, если он пустой");
                    Console.WriteLine("7 – удаление файлов с указанным номером");
                    Console.WriteLine("8 – вывод списка всех файлов с указанной датой создания");
                    Console.WriteLine("9 – вывод списка всех текстовых файлов, в которых текст");
                    Console.WriteLine("0 – выход");
                while (true)
                {
                    Console.WriteLine("Выберите действие: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            f1(ref dir);
                            break;
                        case 2:
                            f2(dir);
                            break;
                        case 3:
                            f3(dir);
                            break;
                        case 4:
                            f4(dir);
                            break;
                        case 5:
                            f5(dir);
                            break;
                        case 6:
                            f6(dir);
                            break;
                        case 7:
                            f7(dir);
                            break;
                        case 8:
                            f8(dir);
                            break;
                        case 9:
                            f9(dir);
                            break;
                        case 0: return;
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Неверное имя файла");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Неверное имя каталога");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка " + e.Message);
            }
       
    

        }
    }
}
