namespace task_2
{
    internal class Program
    {
        static int[] Сreature()
        {
            Console.Write("Введите размерность массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Random rnd = new Random();
                array[i] = rnd.Next(-100, 100);
            }
            return array;
        }

        static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static int SearchMin(int[] array)
        {
            int min = 100;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        static int SearchMax(int[] array)
        {
            int max = -100;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        static int[] Delete(int[] array, int min, int max)
        {
            List<int> nums = new List<int>(array);
            nums.RemoveAt(nums.IndexOf(min));
            nums.RemoveAt(nums.IndexOf(max));
            return nums.ToArray();
        }

        static void Main(string[] args)
        {
            int[] myArray = Сreature();
            Console.WriteLine("Исходный массив:");
            Print(myArray);

            int min = SearchMin(myArray);
            int max = SearchMax(myArray);

            Console.WriteLine("Новый массив:");
            Print(Delete(myArray, min, max));

        }
    }
}