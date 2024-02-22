using System;

namespace Task02
{
    class ZooPark
    {
        static void Main(string[] args)
        {

            Tiger tonyTiger = new Tiger("Tony the Tiger", "Meat", "Cat Land", 110, 6, "Orange and White", "Siberian", "White");
            Wolf williamWolf = new Wolf("William the Wolf", "Meat", "Dog Village", 50.6, 9, "Grey");
            Eagle edgarEagle = new Eagle("Edgar the Eagle", "Fish", "Bird Mania", 20, 15,"Black", "Harpy", 98.5);

            Animal baseAnimal = new Animal("Animal Name", "Animal Diet", "Animal Location", 0.0, 0, "Animal Colour");

            Console.WriteLine();

            baseAnimal.eat();
            tonyTiger.eat();
            williamWolf.eat();
            edgarEagle.eat();

            Console.WriteLine();

            baseAnimal.sleep();
            tonyTiger.sleep();
            williamWolf.sleep();
            edgarEagle.sleep();

            Console.WriteLine();

            baseAnimal.makeNoise();
            tonyTiger.makeNoise();
            williamWolf.makeNoise();
            edgarEagle.makeNoise();

            Console.WriteLine();

            baseAnimal.buildHome();
            tonyTiger.buildHome();
            williamWolf.buildHome();
            edgarEagle.buildHome();

            Console.WriteLine();

            edgarEagle.layEgg();
            edgarEagle.fly();

            Lion leoLion = new Lion("Leo the Lion", "Meat", "Lion's Pride", 145, 3, "Sandy", "African");
            Penguin percyPenguin = new Penguin("Percy the Penguin", "Fish", "Antarctic Experience",12, 2, "Black and White", "Emperor", 20);

            Console.WriteLine();

            leoLion.eat();
            leoLion.makeNoise();
            leoLion.buildHome();
            leoLion.sleep();

            Console.WriteLine();

            percyPenguin.eat();
            percyPenguin.buildHome();
            percyPenguin.layEgg();
            percyPenguin.makeNoise();
            percyPenguin.fly();

            Console.WriteLine();

            Wolf walterWolf = new Wolf("Walter the Wolf", "Meat", "Dog Village", 45.5, 5, "Brown");

            williamWolf.makeNoise();
            walterWolf.makeNoise();
            williamWolf.buildHome();
            walterWolf.sleep();
        }
    }
}