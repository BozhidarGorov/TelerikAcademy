using System;

class SelectionSort
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
        int index = 0,tmp;
        for (int i = 0; i < n; i++)
        {
            int currentMin = array[i];

            for (int j = i; j < n; j++)
            {
                if (currentMin > array[j])
                {
                    currentMin = array[j];
                    index = j;
                }   
            }
            if (currentMin != array[i])
            {
                tmp = array[i];
                array[i] = currentMin;
                array[index] = tmp;
            }
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i]+" ");
        }
    }
}

