using System.Text.RegularExpressions;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string text = Console.ReadLine();
            Regex reg = new Regex(@"\d");
            var matches = reg.Matches(text);
            if (matches.Count > 0 )
            {
                Console.WriteLine("Цифры есть:");
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);

            }
            else { Console.WriteLine("Цифр нету."); }
        }
    }
}