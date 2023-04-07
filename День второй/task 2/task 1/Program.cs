namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());
            double y = 0;
            if(x < Math.PI)
            {
                y = x + 2 * x * Math.Sin(3 * x);
            }
            else
            {
                y = Math.Cos(x) + 2;
            }
            Console.WriteLine(y);
        }
    }
}