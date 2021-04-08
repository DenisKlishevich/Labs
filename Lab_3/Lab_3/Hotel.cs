using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Hotel
    {
        public string name;
        public Appartments[] appartments;
        public Hotel(string N, int D)//N название отеля, D количество комнат
        {
            name = N;
            appartments = new Appartments[D];

            for (int i = 0; i < D; i++)
            {
                appartments[i] = new Appartments ("№" + i, 1);
            }
        }
        public int zaselenie(Guest guest)
        {
            for (int i = 0; i < appartments.Length; i++) //Ищем гостя в аппартаментах
            {
                if (appartments[i].guest == guest)
                    return 3;//Гость в аппартаментах
            }
            for (int i = 0; i < appartments.Length; i++) //Ищем свободные аппартаменты
            {
                if (appartments[i].guest == null)
                {
                    appartments[i].guest = guest;
                        return 1;//Заселили в аппартаменты
                }
            }
            return 2;//Все номера заняты
        }
        public void vyselenie(Guest guest)//Выселение гостя
        {
            for (int i = 0; i < appartments.Length; i++) //Ищем гостя в аппартаментах
            {
                if (appartments[i].guest == guest)
                {
                    appartments[i].guest = null;                }
            }
        }
        public void spisokguest()
        {
            for (int i = 0; i < appartments.Length; i++)
            {
                if (appartments[i].guest != null)
                {
                    Console.WriteLine(appartments[i].guest);
                }
            }
        }
        public override string ToString()
        {
            return "Название отеля " + name + " количество комнат " + appartments.Length;
        }
    }
}
