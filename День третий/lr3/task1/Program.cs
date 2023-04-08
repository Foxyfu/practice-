namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите B: ");
            int b = int.Parse(Console.ReadLine());

            ClassA A = new ClassA(a, b);
            A.Print(a, b);
        }
    }
}