// BSCP|CS|62|114 Charitha Pieris

using System;
using System.Collections.Generic;
using System.Linq;

static class AccountSorter
{
    // Find and return the maximum balance among the given accounts

    private static decimal MaxBalance(List<Account> accounts)
    {
        decimal maxBalance = 0;
        for (int i = 0; i < accounts.Count; i++)
        {
            if (accounts[i].Balance > maxBalance)
            {
                maxBalance = accounts[i].Balance;
            }
        }
        return maxBalance;
    }

    private static List<Account>[] InitializeBucket(int b) // Initialize an array of empty buckets to organize accounts during sorting

    {
        List<Account>[] bucket = new List<Account>[b];

        for (int i = 0; i < bucket.Length; i++)
        {
            bucket[i] = new List<Account>();
        }
        return bucket;
    }

    private static void SortingAccounts(List<Account> accounts, List<Account>[] buckets) // Distribute accounts into buckets based on their balance using a bucket sort algorithm

    {
        decimal maxBalance = MaxBalance(accounts);
        foreach (Account account in accounts)
        {
            int bucket = (int)(Math.Floor(buckets.Length * account.Balance / maxBalance));
            if (bucket == buckets.Length)
                bucket -= 1;
            buckets[bucket].Add(account);
        }
    }

    private static void SortBucket(List<Account>[] buckets) // Sort each bucket individually by account balance

    {
        for (int i = 0; i < buckets.Length; i++)
        {
            buckets[i] = buckets[i].OrderBy(a => a.Balance).ToList();
        }
    }

    private static List<Account> MergeBuckets(List<Account>[] buckets)
    {
        List<Account> result = new List<Account>();

        for (int i = 0; i < buckets.Length; i++)
        {
            if (buckets[i] == null) break;
            result.AddRange(buckets[i]);
        }
        return result;
    }


    // Public function to sort a list of accounts using bucket sort
    public static void Sort(List<Account> accounts, int b)
    {
        if (accounts == null)
        {
            throw new NullReferenceException("Accounts cannot be null");
        }

        if (b <= 1)
        {
            throw new ArgumentOutOfRangeException("At least 2 buckets needed");
        }

        List<Account>[] buckets = InitializeBucket(b);
        SortingAccounts(accounts, buckets);
        SortBucket(buckets);
        accounts.Clear();

        accounts.AddRange(MergeBuckets(buckets));
    }

    public static void Sort(Account[] accounts, int b)  // Public function to sort an array of accounts using bucket sort

    {
        if (accounts == null)
        {
            throw new NullReferenceException("Accounts cannot be null");
        }

        List<Account> temp_list = accounts.ToList();
        Sort(temp_list, b);
        temp_list.CopyTo(accounts);
    }
}
