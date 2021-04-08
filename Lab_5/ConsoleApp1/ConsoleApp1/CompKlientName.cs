using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CompKlientName : IComparer<Klient>
    {
        public int Compare(Klient b1, Klient b2)
        {
            return b1.name.CompareTo(b2.name);
        }
    }
}
