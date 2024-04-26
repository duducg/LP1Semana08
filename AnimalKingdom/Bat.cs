using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Bat : Animal, IMammal, ICanFly
    {
        public int NumberOfWings { get { return 2; } }
        public int NumberOfNipples 
        {
            get { return 4;}
        }
        public override string Sound()
        {
            return base.Sound() + "Click";
        }
    }
}