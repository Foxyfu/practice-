namespace task_4
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

        static string Counting(int[,] array)
        {
            int firstLine = 0;
            int penultimateLine = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                firstLine += array[0, j];
            }

            for (int j = 0; j < array.GetLength(1); j++)
            {
                penultimateLine += array[array.GetLength(0) - 1, j];
            }

            if (firstLine > penultimateLine)
            {
                return "В 1 строке сумма элементов больше:";
            }
            else
            {
                return "В предпоследней строке сумма элементов больше:";
            }
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

            Console.WriteLine(Counting(array));

            
        }
    }
}