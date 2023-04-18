namespace tsak_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите m: ");
            int m =int.Parse(Console.ReadLine());
            Student student = new Student("Ivan", 8);
            Console.WriteLine(student.ToString());

            Master master = new Master("programmer", "Evlampiy", 8.4);
            Console.WriteLine(master.ToString() + $" Степендия: {master.СountingScholarship(m)}");

        }
    }
}