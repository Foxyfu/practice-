using System;
using static System.Formats.Asn1.AsnWriter;

namespace task1
{
    internal class Program
    {
        static int[] Сreature()
        {
            Console.Write("Введите размерность массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Random rnd = new Random();
                array[i] = rnd.Next(-100, 100);
            }
            return array;
        }

        static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static int Search(int[] array)
        {
            int score = 0; 
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    score += 1;
                }
            }
            return score;
        }

        static void Main(string[] args)
        {
            int[] myArray = Сreature();
            Console.WriteLine("Исходный массив:");
            Print(myArray);

            Console.WriteLine($"Кол-во отрицательных чисел {Search(myArray)}");
        }
    }
}