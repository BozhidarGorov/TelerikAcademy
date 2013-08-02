using System;

class BiggestOfThree
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());
        if (first > second)
        {
            if (first > third)
            {
                Console.WriteLine("First is the biggest");
            }
            if (third > first)
            {
                Console.WriteLine("Third is the biggest");
            }
        }
        if (second > first)
        {
            if (second > third)
            {
                Console.WriteLine("Second is the biggest");
            }
            if (third > second)
            {
                Console.WriteLine("Third is the biggest");
            }
        }
    }
}

