using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Driver
    {
        public string truck;
        public Driver(string truck)
        {
            this.truck = truck;
        }

        internal void Speak(int v)
        {
            //throw new NotImplementedException();
        }

        internal void Meneger()
        {
            //throw new NotImplementedException();
        }

        public Driver() : this("Kenworth") {}
        public void Print()
        {
            Console.WriteLine("Я водитель, еду {0} километров, на грузовике", truck);
        }
        public void Meneger(int meneger)
        {
            Console.WriteLine("Фура загружена, еду в рейс на {0} дней", meneger);
        }
        public void Speak()
        {

        }
    }
}
