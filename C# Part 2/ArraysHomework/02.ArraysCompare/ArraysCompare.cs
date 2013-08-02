using System;

class ArraysCompare
{
    static void Main()
    {
        Console.WriteLine("Enter arrays lenght");
        int n = int.Parse(Console.ReadLine());
        int[] array1 = new int [n];
        int[] array2 = new int [n];

        for (int i = 0; i < n; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            array2[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            int test = (array1[i].CompareTo(array2[i]));
            if (test == -1)
            {
                Console.WriteLine("The [{0}] element of the First Array is smaller then the [{0}] of the second", i);
            }
            if (test == 0)
            {
                Console.WriteLine("The [{0}] are equal",i);
            }
            if (test == 1)
            {
                Console.WriteLine("The [{0}] element of the Second Array is smaller then the [{0}] of the first", i);
            }
        }
    }
}

