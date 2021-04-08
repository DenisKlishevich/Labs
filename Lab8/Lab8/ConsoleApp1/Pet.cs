using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void delegat_1 (); //a)	Добавить к классу делегат без параметров.
    public delegate void delegat_2(double ves); 
    
    class Pet
    {
        public string name;
        private int age;
        private double weight;
        private int[] marks = new int[4];

        private delegat_1 del_1;
        private delegat_2 del_2;

        private event delegat_2 Event1;
        public event delegat_2 SomeEvent
        {
            add
            {
               Event1 += value;
                Console.WriteLine("Добавили обработчик события");
            }
            remove
            {
                Event1 -= value;
                Console.WriteLine("Удалили обработчик события");
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value >= 0 & value < 300)
                    age = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                if (value >= 0 & value < 1000)
                    weight = value;
                Event1?.Invoke(value);
            }
        }

        public int[] Marks
        {
            get
            {
                return marks;
            }

            set
            {
                marks.Initialize(); // почистили массив оценок
                int i = 0;  // счетчик
                foreach (int m in value)    // цикл по всем элементам в value
                {
                    marks[i] = m;
                    i++;
                    if (i >= 4) break;  // если аргументов больше, чем надо
                }

            }
        }

        //конструкторы

        public Pet() : this("Noname", 0, 0.1, 0, 0, 0, 0, 0)
        {

        }
        public Pet(string name) : this(name, 0, 0.1, 0, 0, 0, 0)
        {

        }

        public Pet(string name, int age,  double weight, params int[] marks)
        {
            this.name = name;
            Age = age;
            Weight = weight;
            Marks = marks;
        }

        public void zapolnenie(delegat_1 delegat)
        {//b. метод, который заполняет поле типа делегат.
            del_1 = delegat;
        }

        public void zapusk_1()
        {// c. метод, который запускает делегат, лежащий в поле. (с проверкой на NULL)
            del_1?.Invoke();
        }

        public void compare_delegat_1(Pet pet)
        {//Сравните 2-х питомцев – они разговаривают одинаково или нет.
            if (this.del_1 == pet.del_1)
            {
                Console.WriteLine("Питомцы разговаривают одинаково");
            }
            else
            {
                Console.WriteLine("Питомцы разговаривают по-разному");
            }
        }

        public void zapolnenie(delegat_2 delegat)
        {//b. метод, который заполняет поле типа делегат 2.
            del_2 = delegat;
        }

        public void zapusk_2()
        {// c. метод, который запускает делегат, лежащий в поле. (с проверкой на NULL)
            del_2?.Invoke(Weight);
        }

        public void weight_pet(double ves)
        {
            Console.WriteLine("Я вешу " + ves + " кг");
        }

        public override string ToString()
        {
            return String.Format("Питомец по имени {0}, ему {1} лет, весит {2} кг, оценки:{3},{4},{5},{6}", name, age, weight, marks[0], marks[1], marks[2], marks[3]);
        }


    }
}
