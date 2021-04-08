using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    abstract public class Drivers : IMarshrut, IComparable
    {
        public string firstname;
        public string lastname;
        public int klient;
        protected int realized;
        protected int roadlist;
        protected int secondroadlist;

        public Drivers() : this("Noname", "Noname", 0, 0, 0, 0)
        { }
        public Drivers(string firstname, string lastname, int klient, int realized, int roadlist, int secondroadlist)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            Klient = klient;
            Realized = realized;
            Roadlist = roadlist;
        }
        public int Klient
        {
            get
            {
                return klient;
            }
            set
            {
                if (value > 0)
                    klient = value;
                else
                    klient = 0;
            }
        }
        public int Realized
        {
            get
            {
                return realized;
            }
            set
            {
                if (value > 0)
                    realized = value;
                else
                    realized = 0;
            }
        }
        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
        public int SecondRoadList
        {
            get
            {
                return secondroadlist;
            }
            set
            {
                if (value > 0)
                    secondroadlist = value;
                else
                    secondroadlist = 0;
            }
        }
        public int Roadlist
        {
            get
            {
                return roadlist;
            }
            set
            {
                if (roadlist > 0)
                    roadlist = value;
                else
                    roadlist = 0;
            }
        }
        public bool Highest_level (int Highest)
        {
            bool value_lavel = false;
            if (this.CountSeconds(Roadlist) >= Highest)
                value_lavel = true;
            return value_lavel;
        }
        public void NewFirstName (string firstname)
        {
            this.firstname = firstname;
        }
        public virtual int CountRoadlist (int Roadlist)
        {
            return (this.realized / Roadlist);
        }
        public virtual int CountSeconds (int Roadlist)
        {
            return ((this.realized * (this.realized / Roadlist) * SecondRoadList));
        }
        public abstract string Parent_Class();
        public void My_Class(int level)
        {
            Console.WriteLine("Я " + firstname + ", проехал - {0}", level);
        }
        public virtual void Speak()
        {
            Console.WriteLine("Я водитель");
        }
        public int CompareTo(object obj)
        {
            return klient.CompareTo(((Drivers)obj).klient);
        }
        public override bool Equals(object obj)
        {
            Drivers new_obj = (Drivers)obj;
            if (this.firstname != new_obj.firstname)
                return false; 
            else 
                return true;
        }
        void IMarshrut.Zakaz(int put)
        {
            throw new NotImplementedException();
        }
    }
}
