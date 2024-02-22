using System;

namespace Task02
{

    // Prototype for a bird as type of animal
    class Bird : Animal
    {
        // Instance variables
        private String _species;
        private double _wingSpan;

       
        public Bird(String name, String diet, String location, double weight, int age, String colour, String species, double wingSpan): base(name, diet, location, weight, age, colour)
        {
            _species = species;
            _wingSpan = wingSpan;
        }


        // Allows the bird to sleep
        public override void sleep()
        {
            Console.WriteLine("{0} lays down and goes to sleep", _name);
        }

        // Message posted when the bird tries to fly
        public virtual void fly()
        {
            Console.WriteLine("{0} thinks about flying", _name);
        }
    }
}