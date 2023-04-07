namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите X: ");
            double x = double.Parse(Console.ReadLine());
            double A = 0;
            double B = Math.PI/2;
            double M = 20;
            double H = (B - A)/M;
            for (; A <= B;A+=H)
            {
                double y = Math.Sin(A+x) - Math.Cos(A+x);
                Console.WriteLine("Y= " + y);
            }
        }
    }
}