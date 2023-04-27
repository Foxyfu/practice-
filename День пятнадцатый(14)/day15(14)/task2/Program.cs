namespace task2
{
    using System;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(CalculateSum);
            Thread t2 = new Thread(CalculateSum);

            DateTime start = DateTime.Now;

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            DateTime end = DateTime.Now;
            TimeSpan elapsed = end - start;

            Console.WriteLine("Time elapsed: " + elapsed.TotalMilliseconds + "ms");
        }

        static void CalculateSum()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum = " + sum + " (Thread ID: " + Thread.CurrentThread.ManagedThreadId + ")");
        }
    }

}