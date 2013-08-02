using System;

class CharArrComp
{
    static void Main()
    {
        Console.WriteLine("Enter the array lenght.");
        int n = int.Parse(Console.ReadLine());
        char []array1 = new char[n];
        char []array2 = new char[n];
        int firscounter = 0;
        int secondcounter = 0;
        Console.WriteLine("Enter the two arrays.");
        for (int i = 0; i < n; i++)
        {
            array1[i] = char.Parse(Console.ReadLine());
            firscounter += (int)array1[i];
        }
        Console.WriteLine("Enter second array.");
        for (int i = 0; i < n; i++)
        {
            array2[i] = char.Parse(Console.ReadLine());
            secondcounter += (int)array2[i];
        }
        for (int i = 0; i < n; i++)
        {
            int test = (array1[i].CompareTo(array2[i]));
            Console.WriteLine("The {0} element of the first array is {1} elements differenet by ASCII code from the second,", i, test);
        }
        if (secondcounter > firscounter)
        {
            Console.WriteLine("The second array is bigger by ASCII code");
        }
        if (firscounter > secondcounter)
        {
            Console.WriteLine("The firs array is bigger by ASCII code");
        }
        if(firscounter== secondcounter)
        {
            Console.WriteLine("They are equal");
        }
    }
}

