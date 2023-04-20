namespace task4
{
    class Program
    {
        delegate int RandomInt();

        static void Main(string[] args)
        {
            RandomInt[] delegates = new RandomInt[5];

            for (int i = 0; i < delegates.Length; i++)
            {
                delegates[i] = new RandomInt(() => new Random().Next(1, 100));
            }

            Func<RandomInt[], double> averageDelegate = delegate (RandomInt[] dels)
            {
                int sum = 0;
                foreach (RandomInt del in dels)
                {
                    sum += del.Invoke();
                    Console.WriteLine(del.Invoke());
                }

                return (double)sum / dels.Length;
            };

            double average = averageDelegate(delegates);

            Console.WriteLine($"Average value of {delegates.Length} random integers: {average}");
            Console.ReadKey();
        }
    }
}


