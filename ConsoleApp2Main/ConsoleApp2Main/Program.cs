﻿using System;
/*
 namespace Wrox
{
    class Client
    {
        static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Main()
        {
            int i = Add(5, 10);
            Console.WriteLine(i);
            return 0;
        }
    }
}
*/

namespace Wrox
{

    class ArgsExample
{
        public static int Main(string[] args)
    {
        for(int i = 0; i < args.Length; i++)
        {
            Console.WriteLine(args[i]);
        }
        return 0;
    }
}
}