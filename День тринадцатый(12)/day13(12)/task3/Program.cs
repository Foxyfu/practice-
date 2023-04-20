using static task3.Class1;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите text");
            string text = Console.ReadLine();
            Console.WriteLine("Введите букву");
            char letters =Convert.ToChar(Console.ReadLine());
            TextEditing TE;
            Console.WriteLine("Выберите: \n 1 - SearchIndex\n 2 - CaseChangeLower\n 3 - CaseChangeUpper");
            int number = int.Parse(Console.ReadLine());
            try
            {
                switch (number)
                {
                    case 1:
                        TE = SearchIndex;
                        break;
                    case 2:
                        TE = CaseChangeLower;
                        break;
                    case 3:
                        TE = CaseChangeUpper;
                        break;
                    
                    default: throw new Exception("Нет такого");
                }
                string rezult = TE(text, letters);
                Console.WriteLine($"Ответ {rezult}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}