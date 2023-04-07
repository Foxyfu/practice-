namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write m: ");
            double m = double.Parse(Console.ReadLine());
            double z1 = Math.Sqrt(Math.Pow(3 * m + 2, 2)-24*m)/(3*Math.Sqrt(m)-2/ Math.Sqrt(m));
            double z2 = -Math.Sqrt(m);
            Console.WriteLine("Z1 = " + z1 + "  Z2 = " + z2);
        }
    }
}