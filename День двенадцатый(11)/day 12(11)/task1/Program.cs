namespace task1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Vector[] vectors = new Vector[5];

            // заполняем массив объектами базового и производных классов
            vectors[0] = new Vector("Вектор 1");
            vectors[1] = new TwoDimensionalVector("(первый)", 3.0, 4.0);
            vectors[2] = new ThreeDimensionalVector("(первый)", 1.0, 2.0, 3.0);
            vectors[3] = new TwoDimensionalVector("(второй)", -1.0, 5.0);
            vectors[4] = new ThreeDimensionalVector("(Второй)", 4.0, -2.0, 0.0);

            // вызываем виртуальную функцию для каждого объекта в массиве
            foreach (Vector vector in vectors)
            {
                Console.WriteLine(vector);
            }
        }
    }
}



