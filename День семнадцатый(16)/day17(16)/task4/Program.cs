namespace task4
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "input.txt"; // путь к входному файлу
            string outputFile = "output.txt"; // путь к выходному файлу

            // Чтение строк из входного файла и замена символов
            string[] lines = File.ReadAllLines(inputFile);
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Replace('0', '2').Replace('1', '0').Replace('2', '1');
            }

            // Запись измененных строк в выходной файл
            File.WriteAllLines(outputFile, lines);

            Console.WriteLine("Готово!");
            Console.ReadKey();
        }
    }

}