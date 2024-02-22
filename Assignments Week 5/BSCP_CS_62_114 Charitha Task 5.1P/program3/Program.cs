using System;

namespace Program_3
{
    class Overloading
    {
        public static void methodToBeOverloaded(String name)
        {
            Console.WriteLine("Name: " + name);
        }

        public static void methodToBeOverloaded(String name, int age)
        {
            Console.WriteLine("Name: " + name + "," + " Age: " + age);
        }

        static void Main(string[] args)
        {
            Console.WriteLine();
            methodToBeOverloaded("Theja Pieris");
            methodToBeOverloaded("Charitha Pieris", 21);
        }
    }
}