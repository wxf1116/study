using System;
using System.ComponentModel;

namespace ConsoleApp2Break
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j <10; j++)
                {
                    Console.Write(j);
                    if (j == 7)
                    {
                        break; //当循环嵌套时 内部break只会退出这一个内部循环
                    }
                }
                Console.WriteLine("");
                if (i == 2)
                {
                    break;
                }
            }
        }
    }
}
