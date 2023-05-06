namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x ");
            double x = int.Parse(Console.ReadLine());
            double z;
            Task[] task1 = new Task[2]
            {
                new Task(() => { z = (Math.Pow(x,2) + 2 * x - 3 + (x + 1) * Math.Sqrt(Math.Pow(x,2) -9)) / Math.Pow(x,2) - 2 * x - 3 + (x + 1) * Math.Sqrt(Math.Pow(x,2) -9);
                                Console.WriteLine(Task.Factory);}),
                new Task(() => { Math.Sqrt((x + 3) / ( x - 3 ));
                                Console.WriteLine(); })
            };

            foreach (var t in task1)
            {
                t.Start();
            }
        }
    }
}