using System;

namespace Task02
{

    // Prototype for a tiger as a type of feline
    class Tiger : Feline
    {
        private String _colourStripes;

        public Tiger(String name, String diet, String location,double weight, int age, String colour, String species, String colourStripes): base(name, diet, location, weight, age, colour, species)
        {
            _colourStripes = colourStripes;
        }

        public override void eat()
        {
            Console.WriteLine("{0}, eats  meat", _name);
        }

        // The tiger roars
        public override void makeNoise()
        {
            Console.WriteLine("ROARRRRRRRRRRR");
        }

        public override void buildHome()
        {
            Console.WriteLine("{0} builds a lair", _name);
        }
    }
}