using System;

namespace ConsoleApp2if
{
    /*
    class Program
    {
        static void Main(string[] args)
        {
            bool isZero;
            int i = 1;
            if(i == 0)
                {
                isZero = true;
                Console.WriteLine("i is Zero");
                }
            else
            {
                isZero = false;
                Console.WriteLine("i is No-zero");
            }
        }
    }
    */
    class MainEntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a string");
            string input;
            input = Console.ReadLine();
            if(input == "")
            {
                Console.WriteLine("You typed in an empty string.");
            }
            else if(input.Length < 5)
            {
                Console.WriteLine("The string had less than 5 characters");
            }
            else if(input.Length < 10)
            {
                Console.WriteLine("The string had at least 5 but less than 10 Characters.");
            }
            Console.WriteLine("The string was " + input);
        }
    }
}
