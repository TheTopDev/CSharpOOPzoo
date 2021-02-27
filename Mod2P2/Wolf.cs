using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2P2
{
    class Wolf: IAnimals
    {
        public string Species { get; set; }
        public int Age { get; set; }
        public string UniqueCharacteristic { get; set; }
        public int Speed;

        public Wolf() { }

        public String RequestUniqueCharacteristic() {
            Console.WriteLine("How fast can it run? (km/h)");
            Speed = Convert.ToInt32(Console.ReadLine());
            UniqueCharacteristic = $" that runs {Speed} km/h";

            return UniqueCharacteristic;
        }

        public String GetDescription()
        {
            String Description = "contains a " + Age + " year old  " + Species + UniqueCharacteristic;
            return Description;
        }

    }
}
