using System;

namespace Task02
{

    // Prototype for a penguin as a type of bird
    class Penguin : Bird
    {

        public Penguin(String name, String diet, String location,
            double weight, int age, String colour, String species,
            double wingSpan)
            : base(name, diet, location, weight, age, colour, species, wingSpan)
        { }


        // The penguin lays an egg
        public void layEgg()
        {

            Console.WriteLine("{0} lays an egg in the ice.", _name);
        }


        public override void eat()
        {
            Console.WriteLine("{0} eats fish", _name);
        }

        public override void sleep()
        {
            Console.WriteLine("{0} rests in his nest, asleep", _name);
        }


        // The penguin goes nowhere in the air
        public override void fly()
        {
            Console.WriteLine("{0} Cannot fly", _name);
        }

        public override void makeNoise()
        {
            Console.WriteLine("{0} sneezes", _name);
        }


        // The penguin makes it's home
        public override void buildHome()
        {
            Console.WriteLine("{0} builds a rookery", _name);
        }
    }
}