// BSCP|CS|62|114 Charitha Pieris

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void PrintAcc(IEnumerable<Account> accounts)
    {
        foreach (Account account in accounts)
            account.Print();
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("");

        Console.WriteLine("START");

        Random random = new Random();
        int NOOfAccounts = random.Next(5, 15);

        // Create an array of accounts
        Account[] accountsArray = new Account[NOOfAccounts];

        for (int i = 0; i < accountsArray.Length; i++)
        {
            accountsArray[i] = new Account("AccountHolder" + (i + 1), Convert.ToDecimal(random.Next(10, 5000)));
        }

        Console.WriteLine();
        Console.WriteLine("** Array Order before beginning to sort **");
        Console.WriteLine();

        PrintAcc(accountsArray);

        AccountSorter.Sort(accountsArray, 5);  // Sort the array using Bucket Sort

        Console.WriteLine();
        Console.WriteLine("** Array Order After sorting With the Bucket Sorting Algorithm **");
        Console.WriteLine();

        PrintAcc(accountsArray);

        // Create a list of accounts with random balances
        List<Account> accountsList = new List<Account>();

        for (int i = 0; i < NOOfAccounts; i++)
        {
            accountsList.Add(new Account("AccountHolder" + (i + 1), Convert.ToDecimal(random.Next(10, 10000))));  //Generating random amount
        }

        Console.WriteLine();
        Console.WriteLine("** List Order before sort **");
        Console.WriteLine();

        PrintAcc(accountsList);

        // Sorting the bucket sort
        AccountSorter.Sort(accountsList, 5);

        Console.WriteLine();
        Console.WriteLine("** List Order After sorting With the Bucket Sorting Algorithm **");
        Console.WriteLine();

        PrintAcc(accountsList);

        // Testing error Arguments

        Console.WriteLine();
        Console.WriteLine("** Testing Bad Arguments **");
        Console.WriteLine();

        Account[] badArray = null;

        try
        {
            AccountSorter.Sort(badArray, 5);  // Null array
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }

        try
        {
            AccountSorter.Sort(accountsArray, 0); // 0 buckets
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }

        List<Account> badList = null;

        try
        {
            AccountSorter.Sort(badList, 5); // Null list
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }

        try
        {
            AccountSorter.Sort(accountsList, 0); // 0 buckets
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine();
        Console.WriteLine("******************************* Exiting *******************************");
        Console.WriteLine();
    }
}

