using System;

class CountOfGivenNumber
{
    static int CountOfNumber(int number, int[] array)
    {
        int count = 0;
        foreach (int checedNumber in array)
        {
            if (number == checedNumber)
            {
                count++;
            }
        }
        return count;
    }
    static void Main()
    {
        int[] array = {1, 2, 3, 4, 5,5,5,3,2,1,4};
        Console.WriteLine(CountOfNumber(4,array));
    }
}

