using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Wrox.ProCSharp.StaticConstructorSample
{
    public class UserPreferences
    {
        public static readonly Color BackColor;
        static UserPreferences()
        {
            DateTime now = DateTime.Now;
            if (now.DayOfWeek == DayOfWeek.Saturday || now.DayOfWeek == DayOfWeek.Sunday)
            {
                BackColor = Color.Green;
            }
            else
            {
                BackColor = Color.Red;
            }
        }
        private UserPreferences()
        {
        }
        class MainEntryPoint
        {
            static void Main(string[] args)
            {
                Console.WriteLine("颜色" + UserPreferences.BackColor.ToString());
                Document dcmt = new Document();
                Console.WriteLine(dcmt.CreationDate);
                var captain = new { FirstName = "James", MiddleName = "T", LastName = "Kirk" };
                Console.WriteLine(captain.FirstName);
                var doctor = captain;
                Console.WriteLine(doctor.MiddleName);
            }
        }
        public class Document
        {
            public readonly DateTime CreationDate;
            public Document()
            {
                CreationDate = new DateTime(2020, 1, 1);
            }
        }
    }
}
