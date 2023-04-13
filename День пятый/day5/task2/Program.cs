namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите х:");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine(F(x));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static double F(double x)
        {
            if (x >= 1)
            {
                return Math.Pow(x, 2) / (3 * x - 9);
            }
            else if (x > -5)
            {
                return x - 3;
            }
            else
            {
                throw new Exception("вышло за рамки диапазона");
            }
        }
    }
}