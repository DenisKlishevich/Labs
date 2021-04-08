using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Prodtov : Tovary
    {
        public int Shelflife { get; set; }
        public string name { get; set; }
        public Prodtov(string name, int quantity, int shelflife) : base(name, quantity)
        {
        Shelflife = shelflife;
        }
        internal override void Shop()
        {
            Console.WriteLine("Срок годности истек");
        }
        public new void Remont()
        {
            Console.WriteLine("Магазин закрыт");
            base.Remont();
        }
    }
}
