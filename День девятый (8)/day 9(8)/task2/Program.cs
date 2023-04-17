namespace task2
{
    enum EmployeePosition
    {
        Manager = 160,
        Developer = 176,
        Designer = 144
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Должности и количество отработанных часов в месяц:");
            Console.WriteLine("Менеджер: " + (int)EmployeePosition.Manager);
            Console.WriteLine("Разработчик: " + (int)EmployeePosition.Developer);
            Console.WriteLine("Дизайнер: " + (int)EmployeePosition.Designer);
            Console.ReadLine();
        }
    }
}