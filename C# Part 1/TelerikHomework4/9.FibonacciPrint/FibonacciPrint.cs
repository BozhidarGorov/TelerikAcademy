using System;

class FibonacciPrint
{
    static void Main()
    {
        ulong first = 0;
        Console.WriteLine("{0}",first);
        ulong second = 1;
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("{0}",second);
            ulong tmp = second;
            second += first;
            first = tmp;
        }
    }
}

