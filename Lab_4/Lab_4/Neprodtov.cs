using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Neprodtov : Tovary
    {
        public int Weight { get; set; }
        public int quantity { get; set; }

        public Neprodtov(string name, int quantity, int weight) : base(name, quantity)
        {
            Weight = weight;
        }
        
        internal override void Shop()
        {

            Console.WriteLine("Магазин скоро закроется");
        }
        internal override void Zamena()
        {
            base.Zamena();
            Console.WriteLine("Нет в наличии данного товара, была замена");
        }
    }
}
