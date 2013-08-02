using System;

class FibonacciSum
{
    static int SumOfTheNFibonacci(int number)
    {
        int first = 0;
        int second = 1;
        int sum = 1;
        for (int i = 2; i < number; i++)
        {
            int tmp = second;
            second += first;
            first = tmp;
            sum += second;
        }
        return sum;
    }
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine(SumOfTheNFibonacci(N));
    }
}

