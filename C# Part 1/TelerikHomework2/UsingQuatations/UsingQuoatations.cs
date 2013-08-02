using System;

class Program
{
    static void Main()
    {
        string a = "The \"use\" of quoatations causes difficulties.";
        string b = @"The ""use"" of quoatations causes difficulties.";
        Console.WriteLine(b);
    }
}

