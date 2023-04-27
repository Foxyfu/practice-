namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine($"Count: {list.Count}");
            Console.WriteLine($"Element at index 1: {list[1]}");
        }

    }
}