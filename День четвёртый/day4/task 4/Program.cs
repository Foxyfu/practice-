namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array2D array = new Array2D(4,5);
            array.GenerateArray(10, 20);
            Console.WriteLine(array);
            array += 5;
            Console.WriteLine(array);
        }
    }
}