using System.Text.RegularExpressions;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string text = Console.ReadLine();
            Regex reg = new Regex(@"^*\w*");
            Match match = reg.Match(text);
            Console.WriteLine("Первое слово в предложении: " +match.Value);

            Regex reg2 = new Regex(@"\w*$");
            Match match2 = reg2.Match(text);
            Console.WriteLine("Последнее слово в предложении: " + match2.Value);
        }
    }
}