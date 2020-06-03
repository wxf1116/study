using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abcstruct
{
    struct Dimensions
    {
        public double Length;
        public double Width;

        public Dimensions(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Diagonal
        {
            get
            {
                return Math.Sqrt(Length * Length + Width * Width);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dimensions dimen = new Dimensions(2.1, 2.2);
            Console.WriteLine(dimen.Diagonal);
        }
    }
}
