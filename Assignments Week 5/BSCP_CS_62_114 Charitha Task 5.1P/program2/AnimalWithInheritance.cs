using System;

namespace Task02
{

    /// Base class for all animals
    class Animal
    {
        // Instance variables
        protected String _name;
        protected String _diet;
        protected String _location;
        protected double _weight;
        protected int _age;
        protected String _colour;

        public Animal(String name, String diet, String location,
            double weight, int age, String colour)
        {
            _name = name;
            _diet = diet;
            _location = location;
            _weight = weight;
            _age = age;
            _colour = colour;
        }


        // Method to make the animal eat food
        public virtual void eat()
        {
            Console.WriteLine("An animal eats");
        }


        // Puts the animal to sleep
        public virtual void sleep()
        {
            Console.WriteLine("An animal sleeps");
        }


        // Allows the animal to speak or make noise
        public virtual void makeNoise()
        {
            Console.WriteLine("An animal makes a noise");
        }


        // Allows the animal to construct it's home within the display
        public virtual void buildHome()
        {
            Console.WriteLine("An animal builds a home");
        }
    }
}