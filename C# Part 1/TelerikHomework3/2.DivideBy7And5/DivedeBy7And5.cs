using System;

class DivedeBy7And5
{
    static void Main()
    {
        int n=70;
        if ((n%5==0) && (n%7==0))
        {
            Console.WriteLine("It is divided by 7 and 5 without remainder!!");
        }
        else
        {
            Console.WriteLine("It is not divided by 7 and 5 without remainder!!");
        }
    }
}

