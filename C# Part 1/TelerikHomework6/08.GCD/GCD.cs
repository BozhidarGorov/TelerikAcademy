using System;

class GCD
{
    static int GreatestCommonDevisor(int a, int b)
    {
        int Remainder;
        while (b != 0)
        {
            Remainder = a % b;
            a = b;
            b = Remainder;
        }
        return a;
    }
    static void Main()
    {
        int x, y;

        Console.WriteLine("This program allows calculating the GCD");
        Console.Write("Value 1: ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Value 2: ");
        y = int.Parse(Console.ReadLine());

        Console.Write("\nThe Greatest Common Divisor of ");
        Console.WriteLine("{0} and {1} is {2}", x, y, GreatestCommonDevisor(x, y));
    }
}

