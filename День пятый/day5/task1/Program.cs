namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите х: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine($"A = {A(x):f2}");
                Console.WriteLine($"B = {B(x):f2}");
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

        static double A(int x)
        {
            return (2 * x) / Math.Sin(x) - 4 * x;;
        }

        static double B(int x)
        {
           return x - 3 + 1 / Math.Tan(x - 1);
        }
    }
}