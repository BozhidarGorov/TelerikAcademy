using System;

class TheCatalanNumbers
{
    static long Factoriel(int number,int start)
    {
        long  sum = 1;
        for (int i = start+1; i <= number; i++)
        {
            sum *= i;
        }
        return sum;
    }
    static void Main()
    {
        Console.WriteLine("Enter a digit N to get the N-th CatalanNumber");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine(Factoriel(2*N,N)/(Factoriel(N+1,1)));
    }
}

