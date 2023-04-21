using static task2.Zad2;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите х");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y");
            double y = Convert.ToDouble(Console.ReadLine());
            MathOperators MO = new MathOperators(Add);
            Console.WriteLine("Введите: \n 1 - Add\n 2 - Sub\n 3 - Div");
            int number = int.Parse(Console.ReadLine());
            try
            {
                switch (number)
                {
                    case 1:
                        MO = Add;
                        break;
                    case 2:
                        MO = Sub;
                        break;
                    case 3:
                        MO = Div;
                        break;
                    default: throw new Exception("Нет такого");
                }
                double rezult = MO(x, y);
                Console.WriteLine($"Ответ {rezult}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            ChallengeDelegate(x, y, MO);
        }

        static void ChallengeDelegate(double x, double y, MathOperators MO)
        {
            MO(x, y);
        }
    }

    class Zad2
    {
        public delegate double MathOperators(double x, double y);

        public static MathOperators Add = (double x, double y) => { return x + y; };
        public static MathOperators Sub = (double x, double y) => { return x - y; };
        public static MathOperators Div = (double x, double y) => { if (y != 0) return x / y; else throw new Exception("Деление на ноль"); };


    }
}