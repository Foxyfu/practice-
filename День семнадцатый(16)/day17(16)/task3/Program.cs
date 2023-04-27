namespace task3
{
    using System;
    using System.IO;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"input.txt";
            string newFilePath = @"output.txt";

            // a) вывести весь файл на экран;
            Console.WriteLine(File.ReadAllText(filePath));

            // b) подсчитать количество строк;
            int linesCount = File.ReadAllLines(filePath).Length;
            Console.WriteLine($"Количество строк: {linesCount}");

            // c) подсчитать количество символов в каждой строке;
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                Console.WriteLine($"Количество символов в строке \"{line}\": {line.Length}");
            }

            // d) удалить последнюю строку из файла, результат записать в новый файл;
            string[] newLines = lines.Take(lines.Length - 1).ToArray();
            File.WriteAllLines(newFilePath, newLines);

            // e) вывести на экран строки с s1 по s2;
            int s1 = 2;
            int s2 = 4;
            for (int i = s1 - 1; i < s2; i++)
            {
                Console.WriteLine(lines[i]);
            }

            // f) найти длину самой длинной строки и вывести ее на экран;
            int maxLength = lines.Max(line => line.Length);
            Console.WriteLine($"Самая длинная строка имеет длину {maxLength}");

            // g) вывести на экран все строки, начинающиеся с заданной буквы;
            char letter = 'A';
            foreach (string line in lines)
            {
                if (line.StartsWith(letter.ToString()))
                {
                    Console.WriteLine(line);
                }
            }

            // h) переписать его строки в другой файл, порядок строк во втором файле должен быть обратным по отношению к порядку строк в заданном файле.
            string[] reversedLines = lines.Reverse().ToArray();
            File.WriteAllLines(newFilePath, reversedLines);
        }
    }
}

