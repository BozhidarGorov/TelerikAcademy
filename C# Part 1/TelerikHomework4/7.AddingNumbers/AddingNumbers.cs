using System;

class AddingNumbers
{
    static void Main()
    {
        int sum = 0;
        int numbreOfNumbers = int.Parse(Console.ReadLine());
        for (int i = 0; i < numbreOfNumbers; i++)
        {
            int tmp = int.Parse(Console.ReadLine());
            sum += tmp;
        }
        Console.WriteLine("The final sum is {0}",sum);
    }
}

