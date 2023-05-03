namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введите h: ");
            double h = double.Parse(Console.ReadLine());

            

            for (double i = a; i < b; i +=h)
            {
                double y = Math.Round(SearchY(i), 3);
                Console.WriteLine($"f(x) = {i}, y = {y}");
            }
            
        }
        /// <summary>
        /// поиск Y
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static double SearchY(double x)
        {
            double y ;
            if (x < 1)
            {
                y =Math.Pow(Math.Pow(x, 2) - 1,2);
            }
            else if(x > 1)
            {
                y = 1 / Math.Pow(1 + x, 2);
            }
            else
            {
                y = 0;
            }
            return y;
        }
    }
}