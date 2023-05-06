namespace task4
{
    using System;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            double start = -6;
            double end = 6;
            int numSteps = 100;

            // Вычисление шага между значениями на отрезке
            double step = (end - start) / numSteps;

            // Вычисление значений функции с использованием Parallel.For
            Parallel.For(0, numSteps + 1, i =>
            {
                double x = start + i * step;
                double result = Math.Sin(x) - Math.Cos(x);

                Console.WriteLine($"Значение функции для x = {x}: {result}");
            });

            Console.WriteLine("Вычисления завершены");
        }
    }

}