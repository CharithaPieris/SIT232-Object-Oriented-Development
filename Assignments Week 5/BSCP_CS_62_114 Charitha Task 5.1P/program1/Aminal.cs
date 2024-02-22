//BSCP|CS|62|114 Charitha Pieris


using System;

namespace Task01
{
    class Animal
    {
        // Instance variables
        private String _name;
        private String _diet;
        private String _location;
        private double _weight;
        private int _age;
        private String _colour;


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
        public void eat()
        {
            Console.WriteLine("The animal eats food");
        }


        // Method to make the animal sleep
        public void sleep()
        {
            Console.WriteLine("The animal sleeps");
        }


        // Method to make the animal make a noise
        public void makeNoise()
        {
            // Code for the animal to make a noise
            Console.WriteLine("The animal makes a noise");
        }

        // Method to make any animal sound like a lion
        public void makeLionNoise()
        {
            Console.WriteLine("The Lion makes a noise");
        }

        // Method to make any animal sound like an eagle
        public void makeEagleNoise()
        {
            Console.WriteLine("The eagle makes a noise");
        }

        // Method to make any animal sound like a wolf
        public void makeWolfNoise()
        {
            Console.WriteLine("The wolf makes a noise");
        }

        // Method to make an animal eat meat
        public void eatMeat()
        {
            Console.WriteLine("The animal eats meat");
        }

        // Method to make an animal eat berries
        public void eatBerries()
        {
            Console.WriteLine("The animal eats berries");
        }

        // Method to make an animal eat fish
        public void eatFish()
        {
            Console.WriteLine("The animal eats fish");
        }
    }
}