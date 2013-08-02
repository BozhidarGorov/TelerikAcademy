using System;

class MostFrequentNumber
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
        int count = 1;
        int biggestNumber = array[0];
        for (int i = 0; i < n; i++)
        {
            int currentCount = 1;
            for (int j = i+1; j < n; j++)
            {
                if (array[i] == array[j])
                {
                    currentCount++;
                }
                if (array[i] == array[j] && currentCount>=count)
                {
                    count++;
                    biggestNumber = array[i];
                }
            }   
        }
        Console.WriteLine("{0} ({1} times)",biggestNumber,count);
    }
}

