namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите стоимость конфет за кг: ");
            int price = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++) { 
                Console.WriteLine($"Стоимость конфет за {i} кг, равна {i*price}");
            }
        }
    }
}