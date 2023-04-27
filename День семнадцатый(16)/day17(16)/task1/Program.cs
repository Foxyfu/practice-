namespace task1
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            string filename = "input.txt";
            int max = int.MinValue;
            int negativeCount = 0;

            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] numbers = line.Split(' ');
                    foreach (string number in numbers)
                    {
                        if (int.TryParse(number, out int num))
                        {
                            if (num < 0)
                            {
                                negativeCount++;
                            }
                            if (num > max)
                            {
                                max = num;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Максимальное число: " + max);
            Console.WriteLine("Количество отрицательных чисел: " + negativeCount);
        }
    }

}
