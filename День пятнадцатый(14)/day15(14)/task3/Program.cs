namespace task3
{
    using System;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter N:");
            int N = int.Parse(Console.ReadLine());

            Thread t1 = new Thread(() => Method1(A, N));
            Thread t2 = new Thread(() => Method1(A, N));
            Thread t3 = new Thread(() => Method2(A, N));

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();
        }

        static void Method1(int A, int N)
        {
            int sum = A;
            for (int i = 1; i <= N; i++)
            {
                sum += A + i;
            }
            Console.WriteLine("Method1: Sum = " + sum + " (Thread ID: " + Thread.CurrentThread.ManagedThreadId + ")");
        }

        static void Method2(int A, int N)
        {
            int prod = A;
            for (int i = 1; i <= N; i++)
            {
                prod *= A + i;
            }
            Console.WriteLine("Method2: Product = " + prod + " (Thread ID: " + Thread.CurrentThread.ManagedThreadId + ")");
        }
    }

}