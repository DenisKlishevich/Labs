using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Guest
    {
        public string Name;
        public string Sex;
        public Appartments Appartments;
        public Guest(string name, string sex)
        {
            Name = name;
            Sex = sex;
        }


        public int reception (Hotel hotel)
        {
            return hotel.zaselenie(this);
        }


        public override string ToString()
        {
            return Name + " " + Sex + " " + Appartments;
        }
    }
}
