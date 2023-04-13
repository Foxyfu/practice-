namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            string formated = FormatString(input);
            int calculatedNumber = CalculateNumber(formated);
            Console.WriteLine(calculatedNumber);
        }

        static string FormatString(string input)
        {
            input = input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    input = input.Remove(i, 1);
                }
            }
            return input;
        }

        static int CalculateNumber(string input)
        {
            const string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += alphabet.IndexOf(input[i]) + 1;
            }
            while (sum > 9)
            {
                int temp = sum % 10;
                sum = sum / 10 + temp;
            }
            return sum;
        }
    }
}