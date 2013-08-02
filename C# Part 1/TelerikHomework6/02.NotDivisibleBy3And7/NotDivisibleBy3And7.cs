using System;

class NotDivisibleBy3And7
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i < N; i++)
        {
            if (!((i % 3==0) || (i % 7 == 0)))
            {
                Console.WriteLine(i);
            }
        }
    }
}

