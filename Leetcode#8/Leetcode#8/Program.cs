using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> sortedList = new List<int> { 1, 1, 3, 5, 7, 9 };
        List<int> newList = new List<int>();

        if (sortedList.Count > 0)
        {
            newList.Add(sortedList[0]); // Add the first element

            for (int i = 1; i < sortedList.Count; i++)
            {
                // Add element to newList only if it is different from the last added element
                if (sortedList[i] != sortedList[i - 1])
                {
                    newList.Add(sortedList[i]);
                }
            }
        }

        // Print the updated list without duplicates
        Console.WriteLine("List without duplicates:");
        foreach (int number in newList)
        {
            Console.WriteLine(number);
        }
    }
}
