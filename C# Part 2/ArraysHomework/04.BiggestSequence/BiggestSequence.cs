using System;
using System.Collections.Generic;
class BiggestSequence
{
    static void Main()
    {
        Console.WriteLine("Enter the array lenght.");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int count = 1;
        int biggestCount = 0;
        int elem  =0;
        for (int i = 0; i < n-1; i++)
        {

            if (array[i] == array[i+1])
            {
                count ++ ;
            }
            if (array[i] != array[i+1])
            {
                count = 1;
            }
            if (count > biggestCount)
            {
                elem = array[i];
                biggestCount = count;
            }
        }
        Console.WriteLine("The biggest sequence is from the number {0} and it is {1} long",elem,biggestCount);
    }
}
