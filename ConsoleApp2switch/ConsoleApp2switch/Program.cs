using System;

namespace ConsoleApp2switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int integerA = 1;
            switch (integerA)
            {
                case 1:
                    Console.WriteLine("integerA = 1");
                    break;
                case 2:
                    Console.WriteLine("integerA = 2");
                    break;
                case 3:
                    Console.WriteLine("integerA = 3");
                    break;
                default:
                    Console.WriteLine("integerA is not 1,2or3");
                    break;
            }
        }
    }
}
