using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Soprovlist: Klient, IMarshrut, IGruz
    {
        private double _weight;
        public double weight
        {
            get { return _weight; }
            set
            {
                if (value > 0 & value < 1000)
                    _weight = value;
                else _weight = 0.5;

            }

        }
        public Soprovlist(string name, int ves, double weight) : base (name, ves)
        {
            this.weight = weight;
        }
        public Soprovlist() : base ()
        {
            this.weight = 20000;
        }
        public new void Print ()
        {
            Console.WriteLine("Фура загружена {0} масса груза составляет {1} кг общая масса с прицепом {2}", name, ves, weight);
        }
        public override string ToString()
        {
            return $"Фура загружена {name} масса груза составляет {ves} кг общая масса с прицепом {weight}";
        }
        public void Klient (int klient)
        {
            Console.WriteLine($"{this.ToString()} Груз получил {klient}");
        }
        void IGruz.Speak()
        {
            Console.WriteLine("Груз готов к отправке");
        }
        void IMarshrut.Speak()
        {
            Console.WriteLine("Груз следует по маршруту");
        }
        public void KlientSpeak()
        {
            ((IGruz)this).Speak();
        }
        public void SoprovlistSpeak()
        {
            ((IMarshrut)this).Speak();
        }
    }
}
