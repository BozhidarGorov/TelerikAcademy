using System;

class LargestNumberInArrayLessThenK
{
    static void Main()
    {
        Console.WriteLine("Enter array lenght");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        Console.WriteLine("Enter Array");
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter number for K");
        int K = int.Parse(Console.ReadLine());

        Array.Sort(array);
        int index = Array.BinarySearch(array,K);


        Console.WriteLine( "The largest Number less or equal to K is {0}, with index {1}",array[index],index);
    }
}

