using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Driver2 : Drivers, IGruz, IMarshrut
    {
        protected int ClasRoadlist;
        public Driver2()
        {
            ClasRoadlist = 0;
        }

        public int clasroadlist
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
                    ClasRoadlist = Klient * 8;
            }
        }
        public Driver2 (string firstname, string lastname, int klient, int realized, int roadlist, int secondroadlist, int ClasRoadlist):
            base (firstname, lastname, klient, realized, roadlist, secondroadlist)
        {
            clasroadlist = ClasRoadlist;
        }

    }

}

