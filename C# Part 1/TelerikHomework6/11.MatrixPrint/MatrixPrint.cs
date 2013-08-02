using System;

class MatrixPrint
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            for (int j = i; j < N+i; j++)
            {
                Console.Write("{0}  ",j);
            }
            Console.WriteLine();
        }
    }
}

