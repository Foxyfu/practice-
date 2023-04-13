using System.Text.RegularExpressions;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            Regex regex = new Regex(@"\d");
            int summ = 0;
            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                summ += int.Parse(match.Value);
            }

            string message = summ == text.Length ? "Сумма числовых значений цифр, находящихся в тексте, равна длине текста.": "Сумма числовых значений цифр, находящихся в тексте, не равна длине текста.";
            Console.WriteLine(message);
        }
    }
}