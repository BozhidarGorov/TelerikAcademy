using System;

class MinAndMax
{
    static void Main()
    {
        int min, max;
        int N = int.Parse(Console.ReadLine());
        int []array = new int[N];
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        min = max =array[0];
        for (int i = 1; i < N; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            else if (array[i] < min)
            {
                min = array[i];
            }
        }
        Console.WriteLine("Max : {0}",max);
        Console.WriteLine("Min : {0}",min);
    }
}

