using System;

namespace Mod2P2
{
    class ZooDriver
    {
        public static IAnimals[] Animals = new IAnimals[100];
        public static int NewAnimals;
        public static string AnimalSpecies;

        static void Main(string[] args)
        {
            Console.WriteLine("How many animals would you like to add? ");
            NewAnimals = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < NewAnimals; i++)
            {
                Console.WriteLine("\nCage {0}", i + 1);

                Console.WriteLine("what is the animals species? (wolf, lion, or bear)");
                AnimalSpecies = Console.ReadLine();

                if (AnimalSpecies.Equals("lion", StringComparison.CurrentCultureIgnoreCase))
                {
                    Lion lion = new Lion();
                    Animals[i] = lion;
                }

                if (AnimalSpecies.Equals("wolf", StringComparison.CurrentCultureIgnoreCase))
                {
                    Wolf wolf = new Wolf();
                    Animals[i] = wolf;
                }

                if (AnimalSpecies.Equals("bear", StringComparison.CurrentCultureIgnoreCase))
                {
                    Bear bear = new Bear();
                    Animals[i] = bear;
                }

                Animals[i].Species = AnimalSpecies;

                Console.WriteLine("How old is it? ");
                Animals[i].Age = Convert.ToInt32(Console.ReadLine());

                if (Animals[i] is IAnimals)
                {
                    Animals[i].UniqueCharacteristic = Animals[i].RequestUniqueCharacteristic();
                }
                else
                {
                    Console.WriteLine("The animal has no unique characteristics");
                }
            }

            Console.WriteLine("=================================== ");

            for (int j = 0; j < NewAnimals; j++)
            {
                Console.WriteLine("Cage {0} {1}.", j + 1, Animals[j].GetDescription());
            }
        }
    }
}
