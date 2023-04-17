namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Train[] train = new Train[8];
            for(int i = 0; i < train.Length ; i++)
            {
                Console.WriteLine("Введите пунтк назначения: ");
                train[i].Destination = Console.ReadLine();
                Console.WriteLine("Введите номер поезда");
                train[i].Number = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите время отправления");
                train[i].Time = DateTime.Parse( Console.ReadLine());
            }

            Array.Sort(train, (x, y) => x.Number.CompareTo(y.Number));

            for (int i = 0; i < train.Length; i++)
            {
                Console.WriteLine($"Пунтк назначения: {train[i].Destination}");
                Console.WriteLine($"Номер поезда: {train[i].Number}");
                Console.WriteLine($"Время отправления: {train[i].Time:g}");
            }

           

            Console.WriteLine("Введите номер поезда для поиска: ");
            int trainNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < train.Length; i++)
            {
                if (train[i].Number == trainNumber)
                {
                    Console.WriteLine($"Пунтк назначения: {train[i].Destination}");
                    Console.WriteLine($"Номер поезда: {train[i].Number}");
                    Console.WriteLine($"Время отправления: {train[i].Time:g}");
                }
            }
        }
    }
}