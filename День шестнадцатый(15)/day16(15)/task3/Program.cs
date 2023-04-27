namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new MyDictionary<string, int>();
            dictionary.Add("one", 1);
            dictionary.Add("two", 2);
            dictionary.Add("three", 3);
            KeyValuePair<string, int>[] array = dictionary.GetArray();
            foreach (KeyValuePair<string, int> pair in array)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
        }
    }
}