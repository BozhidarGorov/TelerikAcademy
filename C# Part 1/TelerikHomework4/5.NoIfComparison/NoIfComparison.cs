using System;

class NoIfComparison
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        while (first>second)
        {
            Console.WriteLine("{0} is greater then {1}",first,second);
            break;
        }
        while (second>first)
        {
            Console.WriteLine("{0} is greater then {1}",second,first);
            break;
        }
        while (first==second)
        {
            Console.WriteLine("The are equal");
            break;
        }

    }
}

