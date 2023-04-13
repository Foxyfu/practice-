namespace task_5
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите n:");
            int n = int.Parse(Console.ReadLine());

            double result = CalculateF(n);
            Console.WriteLine($"f({n}) = {result:f2}");
        }

        public static double CalculateF(int n)
        {
            if (n == -2)
            {
                return 1.0;
            }
            else
            {
                return (n + 2) / ((n + 4) * CalculateF(n - 1));
            }
        }
    }
}