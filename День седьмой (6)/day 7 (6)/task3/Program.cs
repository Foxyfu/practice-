using System.Text.RegularExpressions;

namespace task3
{
    class Program
    {
        static void Swap(ref string[] matches)
        {
            string temp = matches[0];
            matches[0] = matches[matches.Length - 1];
            matches[matches.Length - 1] = temp;
        }

        static string CutAndConnect(ref string[] matches)
        {
            matches[1] = matches[1] + matches[2];

            char[] charArray = matches[2].ToCharArray();
            Array.Reverse(charArray);
            matches[2] = new string(charArray);

            matches[0] = matches[0].Substring(2);

            return String.Join(" ", matches);
        }

        static void Main()
        {
            Console.WriteLine("Type a sentence");
            string sentence = Console.ReadLine();
            var matches = Regex.Matches(sentence, @"\w+[^\s]*\w+|\w")
                            .Cast<Match>()
                            .Select(m => m.Value)
                            .ToArray();

            Swap(ref matches);
            string result = CutAndConnect(ref matches);

            foreach (string match in matches)
            {
                Console.WriteLine(match);
            }

            Console.WriteLine("Result: " + result);
        }
    }
}