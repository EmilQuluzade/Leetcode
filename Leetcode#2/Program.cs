using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 12321;

            int originalNumber = x;
            int length = 0;

            if (x >= 0 && x < 10)
            {
                Console.WriteLine("true");
            }
            else
            {
                while (x != 0)
                {
                    length++;
                    x /= 10;
                }

                char[] chars = new char[length];
                x = originalNumber;
                char qaliq;
                bool isPalindrome = false;

                if (x >= 0)
                {
                    for (int i = 0; i < length; i++)
                    {
                        qaliq = (char)(x % 10 + '0');
                        chars[i] = qaliq;
                        x /= 10;
                    }

                    string str = new string(chars);
                    long palx = Convert.ToInt64(str);

                    if (palx == originalNumber)
                    {
                        isPalindrome = true;
                    }
                }

                Console.WriteLine(isPalindrome);
            }
        }
    }
}
