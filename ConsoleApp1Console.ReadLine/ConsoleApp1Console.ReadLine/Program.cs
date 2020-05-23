using System;

namespace ConsoleApp1Console.ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("请输入姓名:");
            name = Console.ReadLine();
            Console.WriteLine("你好！{0}!", name);
        }
    }
}
