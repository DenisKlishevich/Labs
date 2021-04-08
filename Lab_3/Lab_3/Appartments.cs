using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Appartments
    {
        public string Number { get; set; } 
        public int Rooms { get; set; }// Количество комнат
        public Guest guest;

        public Appartments(string number, int rooms)
        {
            Number = number;
            Rooms = rooms;
            guest = null;
        }

        public override string ToString()
        {
            return "Номер " + Number + " Комнаты " + Rooms;
        }


    }
}
