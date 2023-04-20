namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector[] vectors = new Vector[]
            {
                new TwoDimensionalVector("первый", 4, 3),
                new ThreeDimensionalVector("второй",1, 2, 3),
                new TwoDimensionalVector("третий", 4, 7),
                new ThreeDimensionalVector("четвёртый", 3, 8, 3)
            };

            double length = 0;

            foreach (var vector in vectors)
            {
                Console.WriteLine(vector);
                length += vector.GetLength();
            }

            Console.WriteLine($"Сумма длин: {length:f2}");
        }
    }
}