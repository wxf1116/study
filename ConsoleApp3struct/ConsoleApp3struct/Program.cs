using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3struct
{
    struct Dimen
    {
        public double Length;
        public double Width;

        public Dimen(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Diagona1
        {
            get
            {
                return Math.Sqrt(Length * Length + Width * Width);
            }
        }
        static void Main()
        {
            Dimen dimen = new Dimen(2, 2);
            Console.WriteLine(dimen.Diagona1);
        }
    }
}
