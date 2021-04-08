using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Driver1 : Drivers
    {
        public Driver1()
        {
            ClasRoadlist = 0;
        }
        protected double clasRoadlist;

        public double ClasRoadlist
        {
            get
            {
                return ClasRoadlist;
            }
            set
            {
                if (value > 0)
                    ClasRoadlist = value;
                else
                    ClasRoadlist = Klient * 2;
            }
        }
        public Driver1(string firstname, string lastname, int klient, int realized, int roadlist, int secondroadlist, double ClasRoadlist) 
            : base(firstname, lastname, klient, realized, roadlist, secondroadlist)
        {
            clasRoadlist = ClasRoadlist;
        }
        public double RoadlistPlus(double plus)
        {
            return this.ClasRoadlist = this.ClasRoadlist + plus;
        }
        public override string Parent_Class()
        {
            return ("\nИмя - " + firstname + ", Фамилия - " + lastname + ", Количество клиентов - " + klient + ", Выполнено - " + realized + "%",
                ", Количество путевых - " + secondroadlist) + ", Путевой - " + roadlist + ", Первоочередной путевой - " + ClasRoadlist;
        }
        public new void NewFirstName (string firstname)
        {
            base.NewFirstName(firstname);
            this.firstname = "Иванов";
        }
    }
}
