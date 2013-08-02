using System;

class StringMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter N and K for N,K");
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());

        string[,] matrix = new string[N, K];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < K; j++)
            {
                matrix[i, j] = Console.ReadLine(); 
            }
        }

        int maxCount = 1;
        int currentCount = 1;
        string maxSymbol = matrix[0, 0];
        string currentSymbol = matrix[0, 0];


        for ( int i = 0; i < N; i++)
        {
            for (int j = 0; j < K; j++)
            {
                currentCount = 0;
                int currentJ = j;
                while ((currentJ < K)&&(matrix[i, j] == matrix[i, currentJ]))
                {
                    currentCount++;
                    currentSymbol = matrix[i, j];
                    currentJ++;
                }
                if(currentCount > maxCount)
                {
                    maxCount =currentCount;
                    maxSymbol = currentSymbol;
                }
                int currentI = i;
                currentCount = 0;
                while ( (currentI < N)&&(matrix[i, j] == matrix[currentI, j]))
                {
                    currentCount++;
                    currentSymbol = matrix[i, j];
                    currentI++;
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    maxSymbol = currentSymbol;
                }
                currentI = i;
                currentJ = j;
                currentCount = 0;
                while ((currentI < N) && (currentJ < K)&&(matrix[i, j] == matrix[currentI, currentJ]))
                {
                    currentCount++;
                    currentSymbol = matrix[i, j];
                    currentI++;
                    currentJ++;
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    maxSymbol = currentSymbol;
                }
            }
        }
        Console.WriteLine("The symbol is {0} , and it has {1} neighbors",maxSymbol,maxCount);
    }
}

