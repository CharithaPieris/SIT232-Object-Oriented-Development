using System;

namespace Task02
{
    class Wolf : Animal
    {
        public Wolf(String name, String diet, String location,double weight, int age, String colour): base(name, diet, location, weight, age, colour)
        { }


        // The wolf eats meat

        public override void eat()
        {
            Console.WriteLine("{0} eats meat", _name);
        }


        // The wolf sleeps
        public override void sleep()
        {
            Console.WriteLine("{0} settles down in his den and sleeps", _name);
        }

        // The wolf howls
        public override void makeNoise()
        {
            Console.WriteLine("{0} howls", _name);
        }


        // The wolf makes it's den
        public override void buildHome()
        {
            Console.WriteLine("{0} builds a den", _name);
        }
    }
}