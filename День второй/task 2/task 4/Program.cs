namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите курс доллара: ");
            double course = double.Parse(Console.ReadLine());

            for (int i = 5; i <= 500; i += 5)
            {
                Console.WriteLine($"{i}$ = {Math.Round(course * i,2)} рублей");
            }
        }
    }
}