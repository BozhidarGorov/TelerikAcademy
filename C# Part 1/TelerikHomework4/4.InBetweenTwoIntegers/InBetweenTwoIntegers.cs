using System;

class InBetweenTwoIntegers
{
    static void Main()
    {
        uint first = uint.Parse(Console.ReadLine());
        uint second = uint.Parse(Console.ReadLine());
        uint tmp;
        int count = 0;
        if (first > second)
        {
            tmp = first;
            first = second;
            second = tmp;
        }
        for (uint i = first; i <= second; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine("p({0},{1})={2}",first,second,count);
    }
}

