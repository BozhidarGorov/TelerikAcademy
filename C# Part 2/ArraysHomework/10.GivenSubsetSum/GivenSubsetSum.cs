using System;

class GivenSubsetSum
{
    static void Main()
    {
        Console.WriteLine("Enter array lenght");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter the array");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter the sum S");
        int S = int.Parse(Console.ReadLine());

        int start = 0;
        int end = 0;
        for (int i = 0; i < n; i++)
        {
            int sum = array[i];
            for (int j = i+1; j < n; j++)
            {
                sum += array[j];
                if (sum == S)
                {
                    start = i;
                    end = j;
                    for (int k = start; k <=end; k++)
                    {
                        Console.Write(array[k]+ " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

