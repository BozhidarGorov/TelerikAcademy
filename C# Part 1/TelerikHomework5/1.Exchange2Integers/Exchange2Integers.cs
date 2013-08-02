using System;

class Exchange2Integers
{
    static void Main()
    {
        Console.Write("First :");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Second :");
        int second = int.Parse(Console.ReadLine());
        if (first > second)
        {
            int tmp = first;
            first = second;
            second = tmp;
        }
        Console.WriteLine("First {0}",first);
        Console.WriteLine("Second {0}",second);
    }
}

