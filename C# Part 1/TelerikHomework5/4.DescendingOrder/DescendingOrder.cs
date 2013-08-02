using System;

class DescendingOrder
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());
        int tmp;
        if (second > first)
        {
            tmp = second;
            second = first;
            first = tmp;
        }
        if (first > second)
        {
            if (third > first)
            {
                tmp = third;
                third = first;
                first = tmp;
                tmp = second;
                second= third;
                third = tmp;
            }
            if (third > second)
            {
                tmp = second;
                second = third;
                third = tmp;
            }
            Console.WriteLine("First {0}",first);
            Console.WriteLine("Second {0}",second);
            Console.WriteLine("Third {0}",third);
        }
    }
}

