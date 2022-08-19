using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public Bird()
        {
            Legs = 2;
            hasFur = true;
            Eyes = 2;
            isBig = false;

        }



        public bool canFly { get; set; }

        public bool hasWings { get; set; }

        public string wingColor { get; set; }

        public int beakAmount { get; set; }
    }
}
