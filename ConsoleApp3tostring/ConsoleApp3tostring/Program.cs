using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wrox
{
    class MainEntryPoint
    {
        static void Main(string[] args)
        {
            Money cash1 = new Money();
            cash1.Amount = 40M;
            Console.WriteLine("cash1.ToString() returns:" + cash1.ToString());
        }
        public class Money
        {
            //private decimal amount;
            public decimal Amount
            {
                get;
                set;
            }
            public override string ToString()
            {
                return "$" + Amount.ToString();
            }
        }
    }
}
