using System;
using ScheduleLibrary;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Schedule schedule = new Schedule();

            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add event");
                Console.WriteLine("2. Remove event");
                Console.WriteLine("3. View schedule");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter date (mm/dd/yyyy): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());

                        Console.Write("Enter event name: ");
                        string eventName = Console.ReadLine();

                        schedule.AddEvent(date, eventName);
                        break;

                    case "2":
                        Console.Write("Enter date of event to remove (mm/dd/yyyy): ");
                        DateTime dateToRemove = DateTime.Parse(Console.ReadLine());

                        schedule.RemoveEvent(dateToRemove);
                        break;

                    case "3":
                        schedule.DisplayEvents();
                        break;

                    case "4":
                        keepRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
