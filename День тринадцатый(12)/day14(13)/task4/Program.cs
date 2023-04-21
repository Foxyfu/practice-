namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            First first = new First();
            Observer1 obs1 = new Observer1();
            Observer2 obs2 = new Observer2();
            first.OnMessage += obs1.OnMessage;
            first.OnMessage += obs1.OnMessage2;
            first.OnMessage += obs2.OnMessage;
            Console.WriteLine("=============");
            first.CallMessage("Вызов события");
            Console.WriteLine("\nУдаляем один обработчик");
            first.OnMessage -= obs1.OnMessage2;
            first.CallMessage("Вызов события ещё раз ");
        }
    }

    class First
    {
        public delegate void MessageHandler(string message);
        public event MessageHandler OnMessage;

        public void CallMessage(string message)
        {
            OnMessage(message);
        }
    }

    class Observer1
    {
        public Observer1()
        {
            Console.WriteLine("Наблюдатель первый готов");
        }
        public void OnMessage(string message)
        {
            Console.WriteLine("Первый обработчик готов");
        }

        public void OnMessage2(string message)
        {
            Console.WriteLine("Второй обработчик готов");
        }
    }

    class Observer2
    {
        public Observer2()
        {
            Console.WriteLine("Наблюдатель второй готов");
        }
        public void OnMessage(string message)
        {
            Console.WriteLine("Первый обработчик готов");
        }
    }
}