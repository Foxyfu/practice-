using static task3.MyInfo;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string newName = Console.ReadLine();
            MyInfo MI = new MyInfo("Александр");
            MI.Notify += DisplayMessage;
            MI.Name = newName;
        }

        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

    }

    class MyInfo
    {
        public delegate void MessageHandler(string message);
        public event MessageHandler Notify;

        private string _name;

        public string Name 
        { 
            get { return _name; }
            set { _name = value; Notify.Invoke($"Имя изменилось на {value}"); }
        } 

        public MyInfo(string name) { _name = name; }
    }
}