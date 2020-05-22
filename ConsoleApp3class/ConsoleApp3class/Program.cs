using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3class
{
    class Program //声明一个类
    {
        static void Main(string[] args)
        {
            PhoneCustomer myCustomer = new PhoneCustomer();
            PhoneCustomer1 myCustomer2 = new PhoneCustomer1();
            Console.WriteLine(myCustomer.DayOfSendingBill);
            myCustomer.CustomerID = 999;
            Console.WriteLine(myCustomer.CustomerID);
            myCustomer2.FirstName = "Simon";
        }
    }
    class PhoneCustomer //声明一个类
    {
        public readonly  string DayOfSendingBill = "Monday";
        public int CustomerID;
        public string FirstName;
        public string LastName;
    }
    struct PhoneCustomer1 //声明一个结构
    {
        public const string DayOfSendingBill = "Monday";
        public int CustomerID;
        public string FirstName;
        public string LastName;
    }
}
