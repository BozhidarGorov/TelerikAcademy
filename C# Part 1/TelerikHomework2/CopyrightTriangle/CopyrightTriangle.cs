using System;

class CopyrightTriangle
{
    static void Main()
    {
        string getInt = new string('©', 2);
        string space = new string(' ', 1);
        Console.WriteLine("Enter the rows of the copyright triangle!!");
        for (int i = 0; i < 3; i++)
        {
            getInt = new string('©', 2 * i + 1);
            space = new string(' ', 2-i);
            Console.Write(space);
            Console.WriteLine(getInt);
        }
    }
}
