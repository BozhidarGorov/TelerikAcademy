using System;

class BiggerThanNeighbours
{
    static bool TheBiggerNeighbour(int[] array, int index)
    {
        if (index == 0 || index == array.Length-1)
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
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 3, 2, 1, 2, 4, 5, 3 };
        Console.WriteLine(TheBiggerNeighbour(array,4));
    }
}

