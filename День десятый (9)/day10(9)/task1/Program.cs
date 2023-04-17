namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass ts = new TestClass();

            Console.WriteLine($"IxF0: {ts.IxF0(10):f2}, IxF1: {ts.IxF1():f2}");
            Console.WriteLine($"F0: {ts.F0(10)}, F1: {ts.F1()}");
            Console.WriteLine($"F0: {((Iz)ts).F0(10)}, F1: {((Iz)ts).F1()}");


        }
    }
}