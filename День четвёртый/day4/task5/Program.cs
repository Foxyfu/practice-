namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Record first = new Record("Вова", "7153040", "11.04.2004");
            Record second = new Record("Попа", "7159040", "20.04.2004");
            Record third = new Record("Боба", "7532040", "13.10.2004");
            Notebook notebook = new Notebook();
            notebook.AddRecord(first);
            notebook.AddRecord(second);
            notebook.AddRecord(third);
            Console.WriteLine("Найдём людей по 3 цифрам номера 715: ");
            var peoples = notebook.GetRecordByPhone("715");
            foreach(var people in peoples)
            {
                Console.WriteLine(people);
            }
            Console.WriteLine("--------");
            Console.WriteLine("Найдём человека по номеру 7153040: ");
            peoples = notebook.GetRecordByPhone("7153040");
            foreach (var people in peoples)
            {
                Console.WriteLine(people);
            }
            Console.WriteLine("--------");
            Console.WriteLine("Найдём человека по дню рождению сегодня: ");
            peoples = notebook.GetRecordByBirthday();
            foreach (var people in peoples)
            {
                Console.WriteLine(people);
            }
            Console.WriteLine("--------");
            Console.WriteLine("Найдём человека по дню рождения 13.10.2004: ");
            peoples = notebook.GetRecordByBirthday("13.10.2004");
            foreach (var people in peoples)
            {
                Console.WriteLine(people);
            }
            Console.WriteLine("--------");
            Console.WriteLine("Найдём человека по дню рождения на следующей неделе (сегодня - 11.04.2023): ");
            peoples = notebook.GetRecordByBirthdayOnNextWeek();
            foreach (var people in peoples)
            {
                Console.WriteLine(people);
            }
            Console.WriteLine("--------");
        }
    }
}