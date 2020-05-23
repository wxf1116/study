using System;

class StringExample
{
    public static int Main()
    {
        string s1 = "a string";
        string s2 = s1;
        Console.WriteLine(s1);
        Console.WriteLine(s2);
        s1 = "another string";
        Console.WriteLine(s1);
        Console.WriteLine(s2);
        return 0;
    }
}
