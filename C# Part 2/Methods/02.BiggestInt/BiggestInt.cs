using System;

class BiggestInt
{
    static int GetMax(int first, int second)
    {
        if (first > second)
        {
            return first;
        }
        return second;
    }
    static void Main()
    {
        Console.WriteLine("Enter the array");
        int[] array = new int[3];
        for (int i = 0; i < 3; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int max = array[0];
        for (int i = 1; i < 3; i++)
        {
            max = GetMax(max, array[i]);
        }
        Console.WriteLine("The biggest number is {0}",max);
    }
}
