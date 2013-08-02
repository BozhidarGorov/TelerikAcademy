using System;

class RisingSequence
{
    static void Main()
    {
        Console.Write("Array length: ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Element[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int counter = 1;
        int maxCounter = 1;
        int index = 0;
        int startIndex = 0;
        for (int i = 1; i < arrayLength; i++)
        {
            if (array[i] > array[i - 1])
            {
                counter++;
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    startIndex = index;
                }
            }
            else
            {
                counter = 1;
                index = i;
            }
        }

        int endIndex = (startIndex + maxCounter) - 1;
        Console.WriteLine("Maximal sequence of increasing elements:");
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}


