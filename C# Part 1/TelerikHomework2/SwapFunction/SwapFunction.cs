using System;

class SwapFunction
{
    static void Main()
    {
        int a = 5, b = 10,tmp;
        Console.WriteLine("Initial initialization. \na={0},b={1}", a,b );
        tmp = a;
        a = b;
        b = tmp;
        Console.WriteLine("First swap. \na={0},b={1}", a, b);
        a = b + a;
        b = a - b;
        a = a - b;
        Console.WriteLine("Second swap. \na={0},b={1}", a, b);
    }
}
