using System;

class SortingWithMethod
{
    static void SelectionSortDescending(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int index = GetPositonForDescending(i, array);
            int tmp = array[i];
            array[i] = MaximalNumber(i, array);
            array[index] = tmp;
        }
    }
    static int MaximalNumber(int start, int[] array)
    {
        int biggesNumber = array[start];
        for (int i = start; i < array.Length; i++)
        {
            if (biggesNumber <= array[i])
            {
                biggesNumber = array[i];
            }
        }
        return biggesNumber;
    }

    static int GetPositonForDescending(int start, int[] array)
    {
        int index = start, biggesNumber = array[start];
        for (int i = start; i < array.Length; i++)
        {
            if (biggesNumber <= array[i])
            {
                biggesNumber = array[i];
                index = i;
            }
        }
        return index;
    }
    static int GetPositonForAscending(int start, int[] array)
    {
        int index = start, smallestNumber = array[start];
        for (int i = start; i < array.Length; i++)
        {
            if (smallestNumber >= array[i])
            {
                smallestNumber = array[i];
                index = i;
            }
        }
        return index;
    }

    static int MinimalNumber(int start, int[] array)
    {
        int smallest = array[start];
        for (int i = start; i < array.Length; i++)
        {
            if (smallest >= array[i])
            {
                smallest = array[i];
            }
        }
        return smallest;
    }
    static void SelectionSortAscending(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int index = GetPositonForAscending(i, array);
            int tmp = array[i];
            array[i] = MinimalNumber(i, array);
            array[index] = tmp;
        }
    }
    static void Main()
    {
        int[] array = { 3, 1, 7, 14, 2, -2 };
        SelectionSortAscending(array);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}

