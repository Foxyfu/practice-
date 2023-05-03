namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text;
            using(StreamReader sr  = new StreamReader("input.txt"))
            {
                text = sr.ReadToEnd();
            }

            Queue<char> letters = new Queue<char>();
            Queue<char> numbers = new Queue<char>();

            foreach (char symbol in text)
            {
                if (Char.IsDigit(symbol))
                {
                    numbers.Enqueue(symbol);
                }
                else
                {
                    letters.Enqueue(symbol);
                }
            }

            Console.Write("Цифры: ");
            foreach (char elem in numbers)
            {
                Console.Write(elem);
            }

            Console.Write("\nБуквы: ");
            foreach (char elem in letters)
            {
                Console.Write(elem);
            }
        }
    }
}