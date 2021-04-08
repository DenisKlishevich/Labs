using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            Hotel hotel1 = new Hotel("Minsk", "Minsk, Nezavisimosti, 11", 30.00, 3, 4, 1, 2, 0);
            Console.WriteLine(hotel1.ToString());
            Console.WriteLine("The gain of hotel {0} per day is: {1}", hotel1.hotelName, hotel1.calculateGain(hotel1.GuestNum, hotel1.DayCost));
                                                
            Hotel hotel2 = new Hotel("Sputnik", "Minsk, Brilevskaja, 2", 350.00, 2, 3, 4, 0, 0);
            Console.WriteLine(hotel2.ToString());
            Console.WriteLine($"The day cost of hotel {hotel2.hotelName} per day is: {hotel2.fallProfitability()}");

            bool profit = hotel1.moreProfitabe(hotel2);
            
            if (profit)
            {
                Console.WriteLine("More profit hotel is {0}", hotel1.hotelName);
            }
            else
            {
                Console.WriteLine("More profit hotel is {0}", hotel2.hotelName);
            }

            Hotel hotel3 = new Hotel();
            Console.WriteLine(hotel3.ToString());

            Hotel moreProfitable = Hotel.moreProfitabe3(hotel1, hotel2, hotel3);
            Console.WriteLine($"More profit hotel between three is hotel {moreProfitable.hotelName}");

            Hotel hotel4 = new Hotel("Slavjanskaja", "Minsk, Narochanskaja, 6");
            Console.WriteLine(hotel4.ToString());

            Hotel hotel5 = hotel1;
            hotel5.hotelName = "Orbita";
            Console.WriteLine(hotel5.ToString());
            Console.WriteLine($"The name of the hotel1 is {hotel1.hotelName}");

            Console.ReadKey();
        }
    }
}