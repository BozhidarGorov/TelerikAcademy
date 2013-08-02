using System;

class SubsetSum
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

        int max = array[0], maxEnd = array[0];
        int longSequence = 1, currentSequence = 1;
        int start = 0, startTemp = 0;

        for (int i = 0; i < n; i++)
			{
                if (array[i] + maxEnd > array[i])
                {
                    maxEnd += array[i];
                    currentSequence++;
                }
                else
                {
                    maxEnd = array[i];
                    startTemp = i;
                    currentSequence = 1;
                }
                if (maxEnd > max)
                {
                    max = maxEnd;
                    longSequence = currentSequence;
                    start = startTemp;
                }
		    }
        for (int i = start; i < start + longSequence; ++i)
        {
            Console.Write("{0} ", array[i]);
        }
    }
}

