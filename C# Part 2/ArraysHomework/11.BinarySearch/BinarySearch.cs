using System;

class BinarySearch
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

        Array.Sort(array);

        Console.WriteLine("Enter the element searched for");
        int elem = int.Parse(Console.ReadLine());

        int left =0 ;
        int right = n-1;
        int mid = (left + right ) / 2;
        while (right >= left)
        {
            mid = (left + right ) / 2;
            if (array[mid] < elem)
            {
                left = mid+1;
            }
            if (array[mid] > elem)
            {
                right = mid - 1;
            }
            if(array[mid] == elem)
            { break; }
            
        }
        Console.WriteLine("The index of the element is {0}",mid);
    }
}

