using System;
using System.Collections.Generic;

namespace ScheduleLibrary
{
    public class Schedule
    {
        private Dictionary<DateTime, string> _schedule = new Dictionary<DateTime, string>();

        public void AddEvent(DateTime date, string eventName)
        {
            if (_schedule.ContainsKey(date))
            {
                Console.WriteLine($"There's already an event scheduled on {date.ToShortDateString()}. Would you like to replace it? (y/n)");
                string response = Console.ReadLine().ToLower();

                if (response == "y")
                {
                    _schedule[date] = eventName;
                }
                else
                {
                    Console.WriteLine("Event not added.");
                }
            }
            else
            {
                _schedule.Add(date, eventName);
            }
        }

        public void RemoveEvent(DateTime date)
        {
            if (_schedule.ContainsKey(date))
            {
                _schedule.Remove(date);
                Console.WriteLine($"Event on {date.ToShortDateString()} has been removed.");
            }
            else
            {
                Console.WriteLine($"No event scheduled on {date.ToShortDateString()}.");
            }
        }

        public void DisplayEvents()
        {
            if (_schedule.Count == 0)
            {
                Console.WriteLine("No events scheduled.");
            }
            else
            {
                Console.WriteLine("Scheduled events:");
                foreach (KeyValuePair<DateTime, string> item in _schedule)
                {
                    Console.WriteLine($"{item.Key.ToShortDateString()} - {item.Value}");
                }
            }
        }
    }
}
