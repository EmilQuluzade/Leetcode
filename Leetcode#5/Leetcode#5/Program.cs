using System;
using System.Collections.Generic;

public class Solution
{
    public bool IsValid(string s)
    {
        Dictionary<char, char> mapping = new Dictionary<char, char>();
        mapping.Add(')', '(');
        mapping.Add('}', '{');
        mapping.Add(']', '[');

        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (mapping.ContainsKey(c))
            {
                char topElement = stack.Count == 0 ? '#' : stack.Pop();

                if (topElement != mapping[c])
                {
                    return false; 
                }
            }
            else
            {

                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        string s1 = "()";
        string s2 = "()[]{}";
        string s3 = "(]";
        string s4 = "([)]";
        string s5 = "{[]}";

        Console.WriteLine(solution.IsValid(s1)); 
        Console.WriteLine(solution.IsValid(s2)); 
        Console.WriteLine(solution.IsValid(s3)); 
        Console.WriteLine(solution.IsValid(s4)); 
        Console.WriteLine(solution.IsValid(s5)); 
    }
}
