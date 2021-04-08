using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    abstract class Tovary
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public Tovary(String name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }
        internal abstract void Shop();
        internal virtual void Zamena()
        {
            Quantity /= 2; //Quantity / 2 ; /=2
            Console.WriteLine("***");
        }

        public void Remont()
        {
            Console.WriteLine("Магазин закрыт");
        }
    }
}
