using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трех значное число");
            int number = Convert.ToInt32(Console.ReadLine());
            Task task1 = new Task(() => NumberGenerator(number));
            task1.Start();
            Task task2 = Task.Factory.StartNew(() => NumberGenerator(number));
            Task task3 = Task.Run(() => NumberGenerator(number));
            Console.ReadLine();
        }

        static void NumberGenerator(int number)
        {
            int a = number / 100;
            int b = number  / 10 % 10 ;
            int c = number % 10;

            Console.WriteLine($"Первое число {a}{b}{c}");
            Console.WriteLine($"Второе число {a}{c}{b}");
            Console.WriteLine($"Третье число {b}{a}{c}");
            Console.WriteLine($"Четвертое число {b}{c}{a}");
            Console.WriteLine($"пятое число {c}{b}{a}");
            Console.WriteLine($"шестое число {c}{a}{b}");
        }
    }
}