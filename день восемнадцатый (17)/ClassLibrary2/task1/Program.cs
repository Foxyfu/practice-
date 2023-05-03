using GeometryLibrary;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter triangle sides: ");

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            try
            {
                Triangle t = new Triangle(a, b, c);

                Console.WriteLine($"Perimeter: {t.Perimeter()}");
                Console.WriteLine($"Area: {t.Area()}");
                Console.WriteLine($"Type: {t.Type()}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\nEnter rectangle sides: ");

            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());

            try
            {
                Rectangle r = new Rectangle(l, w);

                Console.WriteLine($"Perimeter: {r.Perimeter()}");
                Console.WriteLine($"Area: {r.Area()}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}