using System;

class MaximalSum3x3
{
    static void Main()
    {
        Console.WriteLine("Enter N and K for N,K >= 3");
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        int[,] matrix = new int[N, K];
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < K; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int maxSum = matrix[1, 1] + matrix[0, 0] + matrix[0, 1] + matrix[0, 2]
            + matrix[1, 2] + matrix[2, 2] + matrix[2, 1] + matrix[2, 0] + matrix[1, 0];
        for (int i = 1; i < N-1; i++)
        {
            for (int j = 1; j < K-1; j++)
            {
                int curentSum = matrix[i, j] + matrix[i - 1, j - 1] + matrix[i - 1, j] + matrix[i - 1, j + 1]
                    + matrix[i, j + 1] + matrix[i + 1, j + 1] + matrix[i + 1, j] + matrix[i + 1, j - 1] + matrix[i, j - 1];
                if (curentSum > maxSum)
                {
                    maxSum = curentSum;
                }            
            }

        }
        Console.WriteLine("The maximal sum is {0}",maxSum);
    }
}

