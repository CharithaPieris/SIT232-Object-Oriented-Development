// CHARITHA PIERIS BSCP|CS|62|114

using System;

namespace Task_6_1P
{
    class Bird
    {
        // Instance variables
        public string Name { get; set; }

        // Creates a new Bird
        public Bird()
        {

        }

        public virtual void fly()
        {
            Console.WriteLine("Flap, Flap, Flap");
        }

        // Returns a string representation of a bird
        public override string ToString()
        {
            return "A bird named " + Name;
        }
    }
}