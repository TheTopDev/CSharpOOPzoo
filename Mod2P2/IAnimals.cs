using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2P2
{
    interface IAnimals
    {
        public String Species { get; set; }
        public int Age { get; set; }
        public String UniqueCharacteristic { get; set; }


        public String RequestUniqueCharacteristic();

        public String GetDescription();


    }
}
