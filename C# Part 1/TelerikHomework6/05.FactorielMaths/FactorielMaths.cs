﻿using System;

class FactorielMaths
{
    static int Factoriel(int number)
    {
        int sum = 1;
        for (int i = 1; i <= number; i++)
        {
            sum *= i;
        }
        return sum;
    }
    static void Main()
    {
        Console.WriteLine("Enter an integer for N and K where 1<N<K");
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        Console.WriteLine((Factoriel(N)*Factoriel(K))/Factoriel(K-N));
    }
}

