using System;

class IsPrime
{
    static void Main()
    {
        int count = 0;
        int n = 37;
        for (int i = 1; i <= n; i++)
        {
            if (n%i==0)
            {
                count++;
            }
        }
        if (count==2)
        {
            Console.WriteLine("{0} is prime!!",n);
        }
        else
        {
            Console.WriteLine("{0} is not prime!!",n);
        }
    }
}

