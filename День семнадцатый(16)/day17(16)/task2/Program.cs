using System.IO;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = Directory.CreateDirectory(Directory.GetCurrentDirectory()+ @"\New_folder");
        }


    }
}