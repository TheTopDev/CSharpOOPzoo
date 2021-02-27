using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2P2
{
    class Lion: IAnimals
    {
        public string Species { get; set; }
        public int Age { get; set; }
        public string UniqueCharacteristic { get; set; }
        public string ManeColour;

        public Lion() { }

        public string RequestUniqueCharacteristic() {
            Console.WriteLine("What colour is it's mane? ");
            ManeColour = Console.ReadLine();
            UniqueCharacteristic = $" with a {ManeColour} mane";

            return UniqueCharacteristic;
        }

        public String GetDescription() {
            String Description = "contains a " + Age + " year old  " + Species + UniqueCharacteristic;
            return Description;
        }
    }
}
