using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("write number: ");
            int number = int.Parse(Console.ReadLine());
            int dozens = (number / 10)%10;
            int hundreds = number / 100;
            int figure = number % 10;
            Console.WriteLine($"{hundreds}{dozens}{figure}");
            Console.WriteLine($"{hundreds}{figure}{dozens}");
            Console.WriteLine($"{figure}{hundreds}{dozens}");
            Console.WriteLine($"{figure}{dozens}{hundreds}");
            Console.WriteLine($"{dozens}{figure}{hundreds}");
            Console.WriteLine($"{dozens}{hundreds}{figure}");
        }

    }
}