using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3chuancan2
{
    class Program
    {
        static void SomeFunction(out int i)
        {
            i = 100;
        }
        static string FullName(string firstName, string lastNmae)
        {
            return firstName + "" + lastNmae;
        }
        static void TestMethod(int notOptionalNumber, int optionalNumber = 10)
        {
            System.Console.WriteLine(optionalNumber + notOptionalNumber);
        }
        static int Main()
        {
            int i;
            SomeFunction(out i); //out参数 变量可以不初始化
            Console.WriteLine(i);
            Console.WriteLine(FullName(lastNmae:"world", firstName:"hello")); //命名参数 通过命名改变传参顺序
            TestMethod(1, 50); //可选参数 必须为可选参数提供默认值
            return 0;
        }
    }
}
