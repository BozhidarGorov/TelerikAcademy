using System;

class BiggestOfFive
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());
        int fourth = int.Parse(Console.ReadLine());
        int fifth = int.Parse(Console.ReadLine());
        int biggest = first;
        if (biggest < second)
        {
            biggest = second;
        }
        if (biggest < third)
        {
            biggest = third;
        }
        if (biggest < fourth)
        {
            biggest = fourth;
        }
        if (biggest < fifth)
        {
            biggest = fifth;
        }
        Console.WriteLine("The biggest is {0}",biggest);
    }
}

