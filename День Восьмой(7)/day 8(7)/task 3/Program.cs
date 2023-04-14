using System.Text.RegularExpressions;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string text = Console.ReadLine();
            string pattern = "[бвгджзйклмнпрстфхцчшщБВГДЖЗЙКЛМНПРСТФХЦЧШЩ]";
            int count = Regex.Matches(text, pattern).Count;
            Console.WriteLine("Количество согласных букв в тексте: " + count);
            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}