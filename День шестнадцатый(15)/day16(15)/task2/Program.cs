namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new MyDictionary<string, int>();
            dictionary.Add("one", 1);
            dictionary.Add("two", 2);
            dictionary.Add("three", 3);
            Console.WriteLine($"Count: {dictionary.Count}");
            Console.WriteLine($"Value for key 'two': {dictionary["two"]}");
        }

    }
}