using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager3
{
    public class Player : IComparable<Player>
    {
        public string  Name { get; set; }
        public int Score { get; set; }
        public int CompareTo(Player other)
        {
            if (other == null) return 1;
            return other.Score - Score;
        }
        public Player (string name, int score)
        {
            Name = name;
            Score = score;
        }

    }
}