using System;

class SignWithoutCalc
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());
        if (first == 0 || second == 0 || third == 0)
        {
            Console.WriteLine("The result is 0");
        }
        if (first > 0 && second > 0 && third > 0 )
        {
            Console.WriteLine("The sign is +");
        }
        if ((first>0 && second>0 && third<0)||(first>0 && second<0 && third>0)||(first<0 && second>0 && third>0))
        {
            Console.WriteLine("The sign is -");
        }
        if ((first>0 && second < 0 && third < 0)||(first < 0 && second > 0 && third < 0)||(first < 0 && second <0 && third > 0))
        {
            Console.WriteLine("The sign is +");
        }
        if (first < 0 && second < 0 && third < 0)
        {
            Console.WriteLine("The sign is -");
        }
    }
}

