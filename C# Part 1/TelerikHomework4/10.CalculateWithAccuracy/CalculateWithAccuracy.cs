using System;

class CalculateWithAccuracy
{
    static void Main()
    {
        double sum = 1;
        double previusSum;
        double n = 2;
        double epsilon = 0.001;
        while (true)
        {
            previusSum = sum;
            if (n % 2 == 0)
            {
                sum = sum + (1 / n);
                Console.WriteLine(sum);
            }
            else
            {
                sum -= (1 / n);
                Console.WriteLine(sum);
            }
            if (Math.Abs(sum - previusSum) < epsilon)
            {
                break;
            }
            n++;
        }
        Console.WriteLine("The sum is {0}",sum);
    }
}

