using System;

namespace Task02
{

    // Prototype for an eagle as a type of bird
    class Eagle : Bird
    {
        public Eagle(String name, String diet, String location, double weight, int age, String colour, String species, double wingSpan) : base(name, diet, location, weight, age, colour, species, wingSpan)
        { }


        // Allows the eagle to roost in it's nest by laying an egg
        public void layEgg()
        {

            Console.WriteLine("{0} lays an egg.", _name);
        }

        public override void fly()
        {
            // code to allow eagles to fly
            Console.WriteLine("{0} spreads his wings and flies", _name);
        }

        public override void eat()
        {
            Console.WriteLine("{0} eats fish and meat", _name);
        }


        // The eagle sleeps in it's nest
        public override void sleep()
        {
            Console.WriteLine("{0} rests in his nest, asleep", _name);
        }


        // The eagle squarks
        public override void makeNoise()
        {
            Console.WriteLine("{0} squarks", _name);
        }


        // The eagle builds it's nest
        public override void buildHome()
        {
            Console.WriteLine("{0} builds a nest", _name);
        }
    }
}