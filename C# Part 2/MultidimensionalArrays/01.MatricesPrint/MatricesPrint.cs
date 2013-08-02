using System;

class MatricesPrint
{
    static void Main()
    {
        int[,] matrix1 = new int[4, 4];
        int[,] matrix2 = new int[4, 4];
        int[,] matrix3 = new int[4, 4];
        int count = 1;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matrix1[j, i] = count;
                count++;
            }
        }



        for (int i = 0; i < 4; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix2[j, i] = count;
                    count++;
                }
            }
            else
            {
                for (int j = 3; j >= 0; j--)
                {
                    matrix2[j, i] = count;
                    count++;
                }
            }
        }



        int helper = 1;
        for (int i = 3; i >= 0; i--)
        {
            for (int j = 0; j < helper; j++)
            {
                matrix3[i + j, j] = count;
                count++;
            }
            helper++;
            if (i == 0)
            {
                helper = 3;
                for (int k = 0; k < 3; k++)
                {
                    for (int l = k; l < helper; l++)
                    {
                        matrix3[l - k, 1 + l] = count++;
                    }
                }
            }
        }




        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(matrix3[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

