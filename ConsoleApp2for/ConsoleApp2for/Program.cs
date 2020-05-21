using System;

namespace ConsoleApp2for
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 0; i<100; i+=10)
            {
                for (int j = i; j< i+10; j++)
                {
                    Console.WriteLine(" " + j);
                }
                Console.WriteLine();
            }
            */
            int[] arrayOfInts = { 1, 2, 3 };
            foreach ( int temp in arrayOfInts)
            {
                Console.WriteLine(temp);
            }
        }
    }
}
