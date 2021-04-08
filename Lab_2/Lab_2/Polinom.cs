using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Polinom
    {
        public int a, b, c;// Объявили свойства класса
        public Polinom()//Конструктор по умолчанию без параметров
        {
            a = 0;
            b = 0;
            c = 0;
        }
        public Polinom(int A, int B, int C)//Конструктор с параметраими
        {
            a = A;
            b = B;
            c = C;
        }
        public int F(int x, int y, int z)//Вычисляем значение полинома
        {
            return a * x + b * y + c * z;
        }
        public override string ToString()//Перегрузка tostring
        {
            return "" + a + "x + " + b + "y + " + c + "z";
        }
        public int this[int i]//Индексатор изменяет параметры по индексу
        {
            get
            {
                if (i == 0)
                    return a;
                if (i == 1)
                    return b;
                if (i == 2)
                    return c;
                return 0;
            }
            set
            {
                if (i == 0)
                    a = value;
                if (i == 1)
                    b = value;
                if (i == 2)
                    c = value;
            }

        }

        public static Polinom operator +(Polinom A, Polinom B)//Оператор сложения
        {
            return new Polinom(A.a + B.a, A.b + B.b, A.c + B.c);
        }
        public static Polinom operator -(Polinom A, Polinom B)//Оператор вычитания
        {
            return new Polinom(A.a - B.a, A.b - B.b, A.c - B.c);
        }
        public static Polinom operator ++(Polinom A)//Оператор инкремента
        {
            A.a++;
            A.b++;
            A.b++;
            return A;
        }
        public static Polinom operator --(Polinom A)//Оеператор декремента
        {
            A.a--;
            A.b--;
            A.c--;
            return A;
        }
        public static Polinom operator *(Polinom A, Polinom B)//Оператор умножения
        {
            return new Polinom(A.a * B.a, A.b * B.b, A.c * B.c);
        }
        public static Polinom operator /(Polinom A, Polinom B)//Оператор деления
        {
            return new Polinom(A.a / B.a, A.b / B.b, A.c / B.c);
        }
        public static bool operator == (Polinom A, Polinom B)//Сравнение на равенство
        {
            if (A.a == B.a & A.b == B.b & A.c == B.c) return true;
            else return false;
        }
        public static bool operator != (Polinom A, Polinom B)//Сравнение на неравенство
        {
            if (A.a != B.a & B.a != B.b & A.c != B.c) return true;
            else return false;
        }
        public static bool operator false(Polinom A)//Сравнение на false
        {
            if (A.a == 0 & A.b == 0 & A.c == 0) return false;
            else return true;
        }
        public static bool operator true(Polinom A)//Сравнение на true
        {
            if (A.a != 0 & A.b != 0 & A.c != 0) return true;
            else return false;
        }
        public static implicit operator Polinom (double A)//Неявная перегрузка
        {
            return new Polinom((int)A,0,0);
        }
        public static explicit operator double (Polinom A)//Явная перегрузка
        {
            return A.a;
        }
        //public override string ToString()
        //{
        //    return String.Format("The hotel {0} located in {1} the day costs {2} and have guests: {3}, {4}, {5}, {6}, {7}", hotelName, hotelAddress, DayCost, GuestNum[0], GuestNum[1], GuestNum[2], GuestNum[3], GuestNum[4]);

        //}
    }
}

