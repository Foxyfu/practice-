namespace task1
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string with # symbols: ");
            string inputString = Console.ReadLine();

            Stack<char> stack = new Stack<char>();
            foreach (char c in inputString)
            {
                if (c == '#' && stack.Count > 0)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }

            char[] charArray = stack.ToArray();
            Array.Reverse(charArray);
            string outputString = new string(charArray);

            Console.WriteLine("Final string: " + outputString);
        }
    }

}