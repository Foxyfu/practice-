namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write v0: ");
            int v0 = int.Parse(Console.ReadLine());

            Console.WriteLine("Write t: ");
            int t = int.Parse(Console.ReadLine());

            Console.WriteLine("Write a: ");
            int a = int.Parse(Console.ReadLine());

            double S = v0 * t + (a * t * t) / 2; // расстояние
            double v = v0 + a * t; // скорость

            Console.WriteLine($"Расстояние S = {S}");
            Console.WriteLine($"Скорость v = {v}");
        }
    }
}