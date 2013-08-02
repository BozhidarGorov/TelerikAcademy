using System;

class QuickSort
{
    private static int partition(int[] array, int leftIndex, int rightIndex, int pivotIndex)
    {
        int pivotValue = array[pivotIndex];
 
        int temp = pivotValue;
        array[pivotIndex] = array[rightIndex];
        array[rightIndex] = temp;
 
        int storeIndex = leftIndex; 
 
        for (int i = leftIndex; i < rightIndex; i++)
        {
            if (array[i] < pivotValue)
            {
                temp = array[i];
                array[i] = array[storeIndex];
                array[storeIndex] = temp;
                storeIndex++;
            }
        }
 
        temp = array[storeIndex];
        array[storeIndex] = array[rightIndex];
        array[rightIndex] = temp;
 
        return storeIndex; 
    }
 
    private static void quickSort(int[] array, int leftIndex, int rightIndex)
    {
        if (rightIndex - leftIndex >= 1) 
        {
            Random randomIndex = new Random();
            int pivotIndex = randomIndex.Next(rightIndex - leftIndex + 1) + leftIndex;
 
            int pivotNextIndex = partition(array, leftIndex, rightIndex, pivotIndex);
 
            quickSort(array, leftIndex, pivotNextIndex - 1);
            quickSort(array, pivotNextIndex + 1, rightIndex);
        }
    }
 
    public static void quickSort(int[] array)
    {
        quickSort(array, 0, array.Length - 1);
    }
 
    static void Main(string[] args)
    {
        int[] array;
        int arrayLength;
               
        Console.Write("Array length = ");
        arrayLength = int.Parse(Console.ReadLine());
        array = new int[arrayLength];
               
        for (int i = 0; i < array.Length; i++)
        {
                Console.Write("array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
        }
       
        quickSort(array);
               
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
        


