using System;

class FirstBiggerNeighbour
{
    static bool TheBiggerNeighbour(int[] array, int index)
    {
        if (index == 0 || index == array.Length - 1)
        {
            Console.WriteLine("Has only one neighbour");
            return false;
        }
        else
        {
            if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                return true;
            }
            return false;
        }
    }
    static int IndexOfFirstBN(int[] array)
    {
        for (int i = 1; i < array.Length-1; i++)
        {
            if (TheBiggerNeighbour(array,i))
            {
                return i;
            }
        }
        return -1;
    }
    static void Main()
    {
        int[] array = { 1, 2, 3, 2, 3, 5, 6, 1, 2, 3, 52, 3, 3, 4 };
        Console.WriteLine(IndexOfFirstBN(array));
    }
}

