using System;

class BiggestSum
{
    static void Main()
    {
        Console.WriteLine("Enter a digit for K");
        int K = int.Parse(Console.ReadLine());
        Console.Write("Array length: ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Element[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        int sum = 0;
        for (int i = arrayLength-1; i >= arrayLength- K; i--)
        {
            sum += array[i];
        }
        Console.WriteLine("The sum is {0}",sum);
    }
}

