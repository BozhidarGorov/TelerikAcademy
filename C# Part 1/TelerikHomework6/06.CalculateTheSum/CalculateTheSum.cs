using System;

class CalculateTheSum
{
    static int Factoriel(int number)
    {
        int sum = 1;
        for (int i = 1; i <= number; i++)
        {
            sum *= i;
        }
        return sum;
    }
    static void Main()
    {
        double finalSum = 1;
        Console.WriteLine("Enter two integers for N and X where N!/X^N");
        int N = int.Parse(Console.ReadLine());
        int X = int.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            finalSum += Factoriel(N) / Math.Pow(X,N);
        }
        Console.WriteLine("The final sum is {0}",finalSum);
    }
}

