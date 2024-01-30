using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "flower", "flow", "flight" };

            if (strs == null || strs.Length == 0)
                Console.WriteLine("");

            // Take the first string as the reference for comparison
            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                // Compare characters of the reference string with corresponding characters of other strings
                int j = 0;
                while (j < prefix.Length && j < strs[i].Length && prefix[j] == strs[i][j])
                {
                    j++;
                }
                prefix = prefix.Substring(0, j); // Update prefix to the common part
            }
            Console.WriteLine(prefix);
        }
    }
}