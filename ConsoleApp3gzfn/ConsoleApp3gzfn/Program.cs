using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3gzfn
{
    public class MyNumber
    {
        private int number;
        public MyNumber(int number)
        {
            this.number = number;
        }
        static int Main()
        {
            ConsoleApp3gzfn.MyNumber num = new ConsoleApp3gzfn.MyNumber(25);
            System.Console.WriteLine(num.number);
            return 0;
        }
    }
}
