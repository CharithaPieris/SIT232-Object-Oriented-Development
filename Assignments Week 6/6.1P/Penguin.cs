// CHARITHA PIERIS BSCP|CS|62|114

using System;

namespace Task_6_1P
{
    /// <summary>
    /// Prototype for a Penguin as a type of Bird
    /// </summary>
    class Penguin : Bird
    {
        /// <summary>
        /// Prevents a Penguin from flying
        /// </summary>
        public override void fly()
        {
            Console.WriteLine("Penguins cannot fly");
        }

        // String representation of a Penguin
        public override string ToString()
        {
            return "A penguin named " + Name;
        }
    }
}