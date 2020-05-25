using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abcreadonly
{
    public class Document
    {
        public readonly DateTime CreationDate;
        public Document()
        {
            CreationDate = new DateTime(2020, 11, 16);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document();
            Console.WriteLine(doc.CreationDate);
        }
    }
}
