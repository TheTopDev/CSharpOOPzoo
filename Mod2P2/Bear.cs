using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2P2
{
    class Bear: IAnimals
    {
        public string Species { get; set; }
        public int Age { get; set; }
        public string UniqueCharacteristic { get; set; }
        public bool IsGrizzly;
        public string BearBool;

        public Bear() { }

        public String RequestUniqueCharacteristic() {
            do
            {

                Console.WriteLine("Is it a grizzly bear? (yes/no) ");
                BearBool = Console.ReadLine();

                if (BearBool.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
                {
                    IsGrizzly = true;
                }

                else if (BearBool.Equals("no", StringComparison.CurrentCultureIgnoreCase))
                {
                    IsGrizzly = false;
                }

                else
                {
                    Console.WriteLine("incorrect input");
                    BearBool = null;
                }

                if (IsGrizzly == true)
                {
                    UniqueCharacteristic = ", a grizzly bear";
                }

                if (IsGrizzly == false)
                {
                    UniqueCharacteristic = " , a non-grizzly bear";
                }
            } while (BearBool == null);

            return UniqueCharacteristic;
        }
              
        public String GetDescription() {
            String Description = "contains a " + Age + " year old  " + Species + UniqueCharacteristic;
            return Description;
        }
    }
}
