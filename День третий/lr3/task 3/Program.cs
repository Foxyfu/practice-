namespace task_3
{
    internal class Program
    {
        static void Main()
        {
            Polynomial p1 = new Polynomial(2, 3, 1);
            Polynomial p2 = new Polynomial(-1, 5, 2);

            Console.WriteLine("Введите х:");
            int x = int.Parse(Console.ReadLine());

            // Вычисление значения многочлена для заданного аргумента
            Console.WriteLine($"Значение многочлена p1 при x= {x}: {p1.Evaluate(x)}");

            // Сложение многочленов
            Polynomial p3 = p1 + p2;
            Console.Write("p1 + p2 = ");
            p3.Print();

            // Вычитание многочленов
            Polynomial p4 = p1 - p2;
            Console.Write("p1 - p2 = ");
            p4.Print();

            // Умножение многочленов
            Polynomial p5 = p1 * p2;
            Console.Write("p1 * p2 = ");
            p5.Print();
        }
    }
}