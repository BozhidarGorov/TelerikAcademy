using System;
using System.Collections.Generic;

class IsSetEqualToZero
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        List<int> currentNumb = new List<int>();
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < (1<<n); i++)
        {
            int sum = 0;
            for (int j = 0; j < n; j++)
            {
                int digit=(i >> j) & 1;
                sum +=  digit* numbers[j];
                if (digit==1)
                {
                    currentNumb.Add(numbers[j]);
                }
            }
            if (sum == )
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}

