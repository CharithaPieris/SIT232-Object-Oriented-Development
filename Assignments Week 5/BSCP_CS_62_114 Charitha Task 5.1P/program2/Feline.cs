using System;

namespace Task02
{

    // Super class for all cats as a type of animal
    class Feline : Animal
    {
        private String _species;

        public Feline(String name, String diet, String location, double weight, int age, String colour, String species) : base(name, diet, location, weight, age, colour)
        {
            _species = species;
        }


        // Allows a cat to sleep
        public override void sleep()
        {
            Console.WriteLine("{0} lays down and goes to sleep", _name);
        }
    }
}