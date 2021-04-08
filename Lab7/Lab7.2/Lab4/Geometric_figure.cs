using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    [Serializable]
    public abstract class Geometric_figure
    {
        public string name;
        public int num_angle;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Num_angle
        {
            get
            {
                return num_angle;
            }
            set
            {
                if (value > 0)
                    num_angle = value;
                else num_angle = 0;
            }
        }

        public Geometric_figure()
        {
            this.name = "noname";
            num_angle = 0;
        }
        public Geometric_figure(string Name, int Num_angle)
        {
            this.name = Name;
            num_angle = Num_angle;
        }
        //абстрактный метод
        public abstract void Information();
        //виртуальный метод
        public virtual void Speak()
        {
            Console.WriteLine("I'm a Geometric_figure. I have a " + num_angle + " angle");
        }
        public void Area()
        {
            Console.WriteLine("Посчитайте площадь самостоятельно");
        }

        public override string ToString()
        {
            return "Неизвестная геометрическая фигура " + name + " имеет " + num_angle + " угла(-ов)";
        }
    }
}