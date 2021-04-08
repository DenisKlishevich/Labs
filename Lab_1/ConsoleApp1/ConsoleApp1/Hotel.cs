using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Hotel
    {
        public string hotelName; //название отеля
        public string hotelAddress; //адрес отеля
        private int[] guestNum = new int[5]; //количества жильцов в отеле
        private double dayCost; //стоимость проживания 1 жильца в сутки

        public int[] GuestNum //свойство элемента массива жильцов
        {
            get
            {
                return guestNum;
            }
            set
            {
                guestNum.Initialize();
                int i = 0;
                foreach (int k in value)
                {
                    guestNum[i] = k;
                    i++;
                    if (i >= 5) break;
                }
            }
        }

        public double DayCost //совойство элемента стоимости проживания
        {
            get
            {
                return dayCost;
            }
            set
            {
                if (value > 0 & value <= 300)
                    dayCost = value;
                else
                    dayCost = 0;
            }
        }

        public Hotel(string hotelName, string hotelAddress, double dayCost, params int[] guestNum)
        {
            this.hotelName = hotelName;
            this.hotelAddress = hotelAddress;
            DayCost = dayCost;
            GuestNum = guestNum;

        } //конструктор класса отель с параметрами

        public Hotel(string hotelName, string hotelAddress) : this(hotelName, hotelAddress, 0, 0, 0, 0, 0, 0)
        {
        } //конструктор класса отель с двумя параметрами

        public Hotel() : this("No name", "No address")
        {
        } //конструктор класс отель без параметров

        public double calculateGain(int[] guestNum, double dayCost)
        {
            double gain = 0;
            foreach (int i in guestNum)
            {
                gain += i * dayCost;
            }

            return gain;
        } // метод определения выручки за день

        private double countEmptyRoom(int[] guestNum) //метод расчета процента пустых номеров
        {
            int emptyRoom = 0;
            double emptyPerCent = 0;

            foreach (int i in guestNum)
            {
                if (i == 0)
                {
                    emptyRoom++;
                }
            }

            emptyPerCent = emptyRoom * 100 / 5;

            return emptyPerCent;
        }

        public double fallProfitability()
        {

            double x = countEmptyRoom(guestNum);
            if (x > 50)
            {
                DayCost *= 0.8;
            }

            return DayCost;
        } // метод опеределения снижения рентабельности

        public bool moreProfitabe(Hotel hotel2)
        {
            double x = countEmptyRoom(guestNum);
            double y = countEmptyRoom(hotel2.guestNum);

            if (x - y < 0)
            {
                return true;
            }

            return false;
        } // метод для поиска более рентабельного отеля из двух

        public static Hotel moreProfitabe3(Hotel hotel1, Hotel hotel2, Hotel hotel3)
        {
            double x = hotel1.countEmptyRoom(hotel1.guestNum);
            double y = hotel2.countEmptyRoom(hotel2.guestNum);
            double z = hotel3.countEmptyRoom(hotel3.guestNum);

            if (x < y & x < z)
            {
                return hotel1;
            }
            else if (y < x & y < z)
            {
                return hotel2;
            }
            else
            {
                return hotel3;
            }
        } //метод опеределения более рентабельного отеля из трех

        public override string ToString()
        {
            return String.Format("The hotel {0} located in {1} the day costs {2} and have guests: {3}, {4}, {5}, {6}, {7}", hotelName, hotelAddress, DayCost, GuestNum[0], GuestNum[1], GuestNum[2], GuestNum[3], GuestNum[4]);

        }
    }
}