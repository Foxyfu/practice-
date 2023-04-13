namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите k: ");
                int k = int.Parse(Console.ReadLine());

                Console.Write("Введите d: ");
                int d = int.Parse(Console.ReadLine());

                AddLeftDigit(d, ref k);
                Console.WriteLine(k);
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

        static void AddLeftDigit(int d,ref int k)
        {
            for (int i = 0; i < k.ToString().Length; i++)
            {
                d *= 10;
            }
            k += d;
        }
    }
}