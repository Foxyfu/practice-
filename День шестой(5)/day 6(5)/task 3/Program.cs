namespace task_3
{
    internal class Program
    {

        static int[,] Create(int a, int b, int n)
        {
            int[,] array = new int[n, n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Random rnd = new Random();
                    array[i, j] = rnd.Next(a, b);
                }
            }
            return array;
        }

        static void Print(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static double Сounting(int[,] array, int g)
        {
            double summ = 0;
            int quantity = 0;
            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    if (array[i, j] > g)
                    {
                        summ += array[i, j];
                        quantity++;
                    }
                }
            }
            summ = summ / quantity;
            return summ;
        }

        static int SearchEvenElements(int[,] array, int k)
        {
            int quantity = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[k-1, j] % 2 == 0)
                    {
                        quantity++;
                    }
            }
            return quantity;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите начало диапазона: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите конец диапазона: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите размерность массива n: ");
            int n = int.Parse(Console.ReadLine());

            int[,] array = Create(a, b, n);
            Print(array);

            Console.Write("Введите g: ");
            int g = int.Parse(Console.ReadLine());

            Console.WriteLine($"Cреднее арифметическое элементов, больших  заданного G: {Сounting(array, g)}");

            Console.Write("Введите k: ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine($"Количество чётных элементов k-той строки: {SearchEvenElements(array, k)}");
        }
    }
}