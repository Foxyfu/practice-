using static task1.Class1;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите R");
            double R = Convert.ToDouble(Console.ReadLine());

            CalcFigure CF;
            CF = Get_Length;
            Console.WriteLine($"Длина {CF(R):f3}");

            CF = Get_Area;
            Console.WriteLine($"Площадь {CF(R):f3}");

            CF = Get_Volume;
            Console.WriteLine($"Объём {CF(R):f3}");
        }
    }
}