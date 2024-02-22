// CHARITHA PIERIS BSCP|CS|62|114

using System;

namespace Task_6_1P
{
    class Duck : Bird
    {
        // Instance variables
        public double Size { get; set; }
        public string Kind { get; set; }


        // Returns a string representation of a Duck
        public override string ToString()
        {
            return "A duck named " + Name + " is a " + Size + " inch " + Kind;
        }
    }
}