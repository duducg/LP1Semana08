using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        public bool Order { get; }
        public CompareByName (bool order)
        {
            Order = order;
        }
        public int Compare (Player p1, Player p2)
        {
            if (Order)
            {
                return p1.Name.CompareTo(p2.Name);
            }
            else
            {
                return p2.Name.CompareTo(p1.Name);
            }
        }
        



    }
}