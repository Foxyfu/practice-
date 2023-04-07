namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите месяц");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Введите день месяця");
            int day = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    Console.WriteLine($"До конца месяца {31-day} д.");
                    break;
                case 4: case 6: case 9: case 11:
                    Console.WriteLine($"До конца месяца {30 - day} д.");
                    break;
                case 2:
                    Console.WriteLine($"До конца месяца {28 - day} д.");
                    break;
                default:
                    Console.WriteLine("Нет такого месяца");
                    break;
            }
        }
    }
}