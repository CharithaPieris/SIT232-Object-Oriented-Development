> [!IMPORTANT]
> Explore .NET Framework:
> - C# is part of the .NET ecosystem. Familiarize yourself with the .NET libraries and tools.
> - Learn about ASP.NET, Windows Forms, and other application types.
> - Understand the fundamental syntax, data types (like strings, numbers, and booleans), and control structures (loops and conditionals).

<br>

> [!TIP]
> Understand Object-Oriented Concepts:
> - C# is an object-oriented language. Learn about classes, objects, inheritance, and encapsulation.
> - Explore how to create and use classes effectively.

<br><br><br>


> [!NOTE]
> Here’s a simple “Hello, World!” program in C#:

```
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

```
This program prints “Hello, World!” to the console.

<br><br><br>

> [!NOTE]
> Certainly! Here’s a simple example of how you can create an array in C#:

```
using System;

class Program
{
    static void Main()
    {
        // Create an array of integers
        int[] myArray = { 1, 2, 3, 4, 5 };

        // Access and print elements
        Console.WriteLine("Array elements:");
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine($"Element {i}: {myArray[i]}");
        }
    }
}

```

In this example, we’ve created an integer array called myArray with five elements. You can modify the array size and initialize it with different values as needed.
When you run this program, it will display the elements of the array. Feel free to adapt this code snippet to your specific requirements! 🚀

<br><br><br>

> [!NOTE]
> Here’s a simple example of creating a class and an object in C#:

```
using System;

namespace SimpleClassesExample
{
    // Define a class called "Person"
    class Person
    {
        // Properties (fields) of the Person class
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor to initialize properties
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method to display information about the person
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the Person class
            Person person1 = new Person("John Doe", 30);

            // Call the DisplayInfo method
            person1.DisplayInfo();
        }
    }
}

```

In this example:

- We define a Person class with properties (Name and Age), a constructor, and a method (DisplayInfo).
- We create an object (person1) of the Person class and set its properties.
- Finally, we call the DisplayInfo method to show the person’s information.

<br><br><br>

> [!NOTE]
> Inheritance:
> - Inheritance allows a class (called a subclass or derived class) to inherit properties and behaviors from another class (called a base class or parent class).
> - It promotes code reusability and establishes an “is-a” relationship.

```
using System;

// Base class (parent)
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

// Derived class (child)
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        myDog.Eat(); // Inherited method
        myDog.Bark(); // Method specific to Dog
    }
}
```

<br><br><br>

> [!NOTE]
> Polymorphism:
> - Polymorphism allows objects of different classes to be treated uniformly.
> - It can be achieved through method overriding (runtime polymorphism) or method overloading (compile-time polymorphism).
> - Example (method overriding):

```
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape.");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape myShape = new Circle();
        myShape.Draw(); // Calls the overridden method in Circle
    }
}

```

<br><br><br>

> [!NOTE]
> Encapsulation:
> - Encapsulation hides the internal details of an object and exposes only necessary methods and properties.
> - It protects data integrity and provides a clear interface for interaction.

```
class BankAccount
{
    private double balance;

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public double GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();
        account.Deposit(1000);
        Console.WriteLine($"Balance: {account.GetBalance()}");
    }
}

```
