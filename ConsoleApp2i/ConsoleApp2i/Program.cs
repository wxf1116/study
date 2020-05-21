using System;

namespace Wrox.ProCSharp.Basics
{
    public class ScopeTest
    {
        /*
        public static int Main()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            return 0;
        }
        */

       /*
        public static int Main()
        {
            int j = 20;
            for (int i = 0; i < 0; i++)
            {
                int j = 30; //第一个变量j是在for循环前定义的，所以也在for循环作用域内，在Main()结束执行后j才超出作用域，第2个j(不合法)则在循环的作用域内，该作用域嵌套在Main()方法的作用域内。编译器无法分辨这两个变量，因此不允许声明第二个变量
                Console.WriteLine(j + i);
            }
            return 0; 
        }
       */
    }

    class ScopeTest2
    {
        static int j = 20;
        public static void Main()
        {
            int j = 30;
            Console.WriteLine(j);
            Console.WriteLine(ScopeTest2.j);
            return;
        }
    }
}

