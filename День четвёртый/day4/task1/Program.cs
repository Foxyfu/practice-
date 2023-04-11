namespace task1
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("Введите х: ");
            double x = double.Parse(Console.ReadLine());  //Ввод х

            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine()); //Ввод n

            double newX = Function(x, n); //Вызов методы

            double result = Math.Pow(newX,2) / 2 + Math.Pow(newX, 4) / 4 + Math.Pow(newX, 6) / 6;
            Console.WriteLine("Отвтет: " + Math.Round(result,2));
        } 
        static double Function(double x, double n)  //Метод который вычесляет функция 
        {
            return Math.Pow(x,n)/n;  
        }
    }
}