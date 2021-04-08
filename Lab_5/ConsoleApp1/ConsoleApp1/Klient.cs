using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Klient : IMarshrut, IGruz
    {
        public string name;
        public int _ves;
        public int ves
        {
            get { return _ves; }
            set
            {
                if (value >= 0 & value <= 20000)
                    _ves = value;
                else _ves = 0;
            }
        }

        internal void Zakaz()
        {
            //throw new NotImplementedException();
        }

        public Klient(string name, int ves)
        {
            this.name = name;
            this.ves = ves;
        }
        public Klient() : this("Алдора", 15000) { }
        public void Print()
        {
            Console.WriteLine("Груз, название {0}, весом {1}", name, ves);
        }
        public override string ToString()
        {
        return $"Груз, название {name}, весом {ves}";
        }
        public void Zakaz (int marshrut)
        {
            Console.WriteLine("{0} груз {1 } едет по маршруту", marshrut, this.ToString());
        }
        public void Speak ()
        {
            Console.WriteLine("Клиент говорит");
        }
        public int CoMpareTo (object b1)
        {
            return this.name.CompareTo(((Klient)b1).name);
        }
        public void Menager(double menager)
        {
            throw new NotImplementedException();
        }
    }
}
