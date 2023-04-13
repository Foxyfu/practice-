using System.ComponentModel.DataAnnotations;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Аргентина манит негра";
            char[] separators = new char[] { ' ', ';', ',', '\r', '\t', '\n' };
            text = text.Replace(separators, "");
            text = text.ToLower();
            string message;
            message = text == new string(text.Reverse().ToArray()) ? "Это палиндром" : "Это не палиндром";
            Console.WriteLine(message);
           
        }
    }

    public static class ExtensionMethods
    {
        public static string Replace(this string s, char[] separators, string newVal)
        {
            string[] temp;

            temp = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return String.Join(newVal, temp);
        }
    }
}