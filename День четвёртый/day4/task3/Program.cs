using System.Security.Authentication;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введите h: ");
            double h = double.Parse(Console.ReadLine());

            double y = 0;

            for (double i = a; i < b; i += h)
            {
                SearchY(i, out y);
                double result = Math.Round(y, 3);
                Console.WriteLine($"f(x) = {i}, y = {result}");
            }

        }

        static void SearchY(double x,out double y)
        {
            if (x < 1)
            {
                y = Math.Pow(Math.Pow(x, 2) - 1, 2);
            }
            else if (x > 1)
            {
                y = 1 / Math.Pow(1 + x, 2);
            }
            else
            {
                y = 0;
            }
        }

    }
}