using System;

namespace Wrox
{
    class ParameterTest
    {
        static void SomeFunction(int[] ints, int i)
        {
            ints[0] = 100;
            i = 100;
        }
        public static int Main()
        {
            int i = 0;
            int[] ints = { 0, 1, 2, 3, 6, 8 };
            Console.WriteLine("i is" + i);
            Console.WriteLine("ints is" + ints[0]);
            SomeFunction(ints, i);
            Console.WriteLine("i is" + i);
            Console.WriteLine("ints is" + ints[0]);
            return 0;
        }
    }
}