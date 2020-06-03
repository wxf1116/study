using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyArray
{
    class Person
    {
        public string FirstName, LastName;
    }
    class Program
    {

        static void Main(string[] args)
        {
            Person[] beat =
            {
                new Person {FirstName = "J", LastName = "L"},
                new Person {FirstName = "P", LastName = "M"}
            };
            //Person[] les = beat;

            //Console.WriteLine(les[1].FirstName);

            //les[1].FirstName = "W";

            //Console.WriteLine(les[1].FirstName);
            //Console.WriteLine(beat[1].FirstName); //浅拷贝

            //Person[] les = (Person[])beat.Clone();

            //les[1].FirstName = "w";

            //Console.WriteLine(beat[1].FirstName); //还是浅拷贝

            Person[] les = new Person[2];
            Console.WriteLine(beat[0].FirstName);
            for (int i = 0; i < beat.Length; i++)
            {
                les[i] = beat[i];
            }

            Console.WriteLine(les[0].FirstName);

            les[0].FirstName = "W";
            Console.WriteLine(les[0].FirstName);
            Console.WriteLine(beat[0].FirstName);//还是浅拷贝

        }
    }
}
