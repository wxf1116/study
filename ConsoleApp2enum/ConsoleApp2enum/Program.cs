using System;

namespace ConsoleApp2enum
{
    class Program
    {
        public enum TimeOfDay
        {
            Morning = 0,
            Afternoon = 1,
            Evening = 2
        }
        static int Main(string[] args)
        {
            WriteGreeting(TimeOfDay.Morning);
            return 0;
        }
        static void WriteGreeting(TimeOfDay timeOfDay)
        {
            switch (timeOfDay)
            {
                case TimeOfDay.Morning:
                    Console.WriteLine("Good Morning!");
                    break;
                case TimeOfDay.Afternoon:
                    Console.WriteLine("Good Afternoon!");
                    break;
                case TimeOfDay.Evening:
                    Console.WriteLine("Good Evening!");
                    break;
                default:
                    Console.WriteLine("Hello");
                    break;
            }
        }
    }
}
