using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 6, 8, 4, 9, 12, 15 };
            int target = 12;
            int[] result = new int[2]; // Fix 1: Declare result array with size 2
            bool found = false; // Variable to track if a pair is found

            for (int i = 0; i < nums.Length; i++)
            {
                int firstNum = nums[i];
                int secondNum = target - firstNum;

                for (int j = i + 1; j < nums.Length; j++) // Start from i + 1 to avoid reusing the same element
                {
                    if (nums[j] == secondNum)
                    {
                        result[0] = i; // Assign index of first number
                        result[1] = j; // Assign index of second number
                        found = true;
                        break;
                    }
                }
                if (found)
                    break;
            }
            Console.WriteLine($"[{result[0]}, {result[1]}]");
        }
    }
}
