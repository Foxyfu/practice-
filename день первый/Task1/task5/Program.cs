namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write time: ");
            double min = double.Parse(Console.ReadLine());
            double clock = Math.Floor(min / 60);
            Console.WriteLine($"{clock} ч. {min%60} мин."); ;
        }
    }
}