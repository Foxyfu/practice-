namespace task5
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> values = new List<int> { 1, 4, 61, 85 };
            int sumThreshold = 100;

            int sum = 0;
            long product = 1;

            Parallel.ForEach(values, (value, state) =>
            {
                // Проверка условия прерывания
                if (sum >= sumThreshold)
                {
                    state.Break();
                    return;
                }

                // Суммирование
                sum += value;

                // Произведение
                product *= value;

                Console.WriteLine($"Значение: {value}, Сумма: {sum}, Произведение: {product}");
            });

            Console.WriteLine("Вычисления завершены");
        }
    }

}