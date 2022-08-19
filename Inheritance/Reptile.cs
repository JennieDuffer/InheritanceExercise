using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool hasScales { get; set; }

        public bool canSwim { get; set; }

        public bool isColdBlooded { get; set; }

        public bool hasTail { get; set; }
    }
}
