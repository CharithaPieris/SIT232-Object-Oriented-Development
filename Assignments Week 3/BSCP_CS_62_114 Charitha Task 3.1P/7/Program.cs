//Charitha Pieris BSCP_CS_62_114 

using System;

class Program
{
    static void Main()
    {
        // Declare a List of type string to store student names
        List<string> myStudentList = new List<string>();

        // Use Random class to generate a random number of students (between 1 and 12)
        Random randomValue = new Random();
        int randomNumber = randomValue.Next(1, 13);

        Console.WriteLine("You now need to add " + randomNumber + " students to your class list");

        // Request user input for student names and add them to the List
        for (int i = 0; i < randomNumber; i++)
        {
            Console.Write("Please enter the name of Student " + (i + 1) + ": ");
            string studentName = Console.ReadLine();
            myStudentList.Add(studentName);
            Console.WriteLine();
        }

        Console.WriteLine("\nList of student names:");

        // Print all the student names in the List
        for (int i = 0; i < myStudentList.Count; i++)
        {
            Console.WriteLine("Student " + (i + 1) + ": " + myStudentList[i]);
        }
    }
}


