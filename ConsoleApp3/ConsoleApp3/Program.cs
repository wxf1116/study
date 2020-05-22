using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Rectangle
    {
        public int Height = 88;
        public int Width = 88;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            Console.WriteLine(Program.IsSquare(rect));
            Console.WriteLine(IsPositive(rect.Height));
        }
        public static bool IsSquare (Rectangle rect)
        {
            return (rect.Height == rect.Width);
        }
        public static bool IsPositive (int Value)
        {
            if (Value < 0)
                return false;
            return true;
        }
    }
}
