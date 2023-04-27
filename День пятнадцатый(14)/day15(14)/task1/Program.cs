namespace task1
{
    using System;
    using System.Threading;

    class Program
    {
        static AutoResetEvent firstDone = new AutoResetEvent(false);
        static AutoResetEvent secondDone = new AutoResetEvent(false);

        static void Main(string[] args)
        {
            Thread t1 = new Thread(FirstThread);
            Thread t2 = new Thread(SecondThread);
            Thread t3 = new Thread(ThirdThread);

            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Normal;
            t3.Priority = ThreadPriority.Lowest;

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();
        }

        static void FirstThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("First thread: " + i);
                firstDone.Set();
                secondDone.WaitOne();
            }
        }

        static void SecondThread()
        {
            for (int i = 10; i < 20; i++)
            {
                firstDone.WaitOne();
                Console.WriteLine("Second thread: " + i);
                secondDone.Set();
            }
        }

        static void ThirdThread()
        {
            for (int i = 20; i < 30; i++)
            {
                secondDone.WaitOne();
                Console.WriteLine("Third thread: " + i);
                firstDone.Set();
            }
        }
    }

}