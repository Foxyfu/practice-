namespace task3
{
    using System;
    using System.Threading.Tasks;


    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Введите трёх значное число");
            int number = int.Parse(Console.ReadLine()); // Исходное трехзначное число

            // Создание первого объекта задачи
            Task<int[]> firstTask = Task.Run(() =>
            {
                // Выполнение вычислений - получение шести чисел, образованных при перестановке цифр заданного числа
                int[] permutations = GetNumberPermutations(number);
                return permutations;
            });

            // Создание второго объекта задачи продолжения
            Task continuationTask = firstTask.ContinueWith(previousTask =>
            {
                // Получение результата из первой задачи и вывод на консоль
                int[] permutations = previousTask.Result;
                Console.WriteLine("Результат первой задачи:");
                foreach (int permutation in permutations)
                {
                    Console.WriteLine(permutation);
                }
            });

            // Ожидание завершения второй задачи
            await continuationTask;

            Console.WriteLine("Вторая задача завершена");
        }

        
        private static int[] GetNumberPermutations(int number)
        {
            int[] permutations = new int[6];

            int a = number / 100;
            int b = number / 10 % 10;
            int c = number % 10;
           
            for (int i = 0; i < 6; )
            {
                permutations[i++] = a * 100 + b * 10 + c;
                permutations[i++] = a * 100 + c * 10 + b;
                permutations[i++] = c * 100 + b * 10 + a;
                permutations[i++] = c * 100 + a * 10 + b;
                permutations[i++] = b * 100 + a * 10 + c;
                permutations[i++] = b * 100 + c * 10 + a;
            }

            return permutations;
        }
    }


}