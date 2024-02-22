using System;

namespace Task02
{

    // Prototype for a lion as a type of feline
    class Lion : Feline
    {

        public Lion(String name, String diet, String location,double weight, int age, String colour, String species): base(name, diet, location, weight, age, colour, species)
        { }


        // The lion eats
        public override void eat()
        {
            Console.WriteLine("{0} eats meat", _name);
        }

        public override void makeNoise()
        {
            Console.WriteLine("BIIIIGGGG ROARRRRRRRRRRR");
        }

        public override void buildHome()
        {
            Console.WriteLine("{0} builds a den", _name);
        }
    }
}