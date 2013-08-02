using System;

class SayMyName
{
    static void PrintMyName(string name)
    {
        Console.WriteLine("Hello {0}",name);
    }

    static void Main()
    {
        Console.WriteLine("Please enter your name.");
        string myName = Console.ReadLine();
        PrintMyName(myName);
    }
}

