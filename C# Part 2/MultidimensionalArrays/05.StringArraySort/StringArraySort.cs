using System;
class StringArraySort
{
    static void sort(string[] arr)
    {
        int index = 0;
        string tmp;
        string currentMinString = "";
        for (int i = 0; i < arr.Length; i++)
        {
            int currentMin = arr[i].Length;

            for (int j = i; j < arr.Length; j++)
            {
                if (currentMin > arr[j].Length)
                {
                    currentMinString = arr[j];
                    currentMin = arr[j].Length;
                    index = j;
                }
            }
            if(currentMin != arr[i].Length)
            {
                tmp = arr[i];
                arr[i] = currentMinString;
                arr[index] = tmp;
            }
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter array lenght");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];
        Console.WriteLine("Enter the array");
        for (int i = 0; i < n; i++)
        {
            array[i] = Console.ReadLine();
        }
        sort(array);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(array[i] + " ");
        }
    }
}

