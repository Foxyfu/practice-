namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a:");
            double a = int.Parse(Console.ReadLine());

            Console.Write("Введите b:");
            double b = int.Parse(Console.ReadLine());

            Console.Write("Введите c:");
            double c = int.Parse(Console.ReadLine());
            
            if ((a + b) < c) 
            {
                Console.WriteLine("Такого треугольника не существует.");
            }
            else if (a+c < b)
            {
                Console.WriteLine("Такого треугольника не существует.");
            }
            else if ((c+b) < a) 
            {
                Console.WriteLine("Такого треугольника не существует.");
            }
            else
            {
                Console.WriteLine("Такой треугольник существует");
            }
            
        }
    }
}