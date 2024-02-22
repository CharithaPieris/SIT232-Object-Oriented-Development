//Charitha Pieris BSCP_CS_62_114 

using System;

class Program
{
    static void Main()
    {
        int[] arr1 = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        int[] arr2 = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        
        Console.WriteLine("Result for arr1: " + FuncOne(arr1));
        Console.WriteLine("Result for arr2: " + FuncOne(arr2));
    }

    static int FuncOne(int[] arr)
    {
        int result = 0;

        if (arr.Length > 10)
        {
            // Count the number of odd elements
            foreach (int num in arr)
            {
                if (num % 2 != 0)
                {
                    result++;
                }
            }
        }
        else
        {
            // Calculate the product of even elements
            result = 1;
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    result *= num;
                }
            }
        }

        return result;
    }
}
