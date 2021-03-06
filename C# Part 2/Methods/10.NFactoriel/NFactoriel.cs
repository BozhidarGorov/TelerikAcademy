﻿using System;

class NFactoriel
{
    static byte[] Add(byte[] a, byte[] b)
    {
        if (a.Length > b.Length)
        {
            return Add(b, a);
        }


        byte[] result = new byte[b.Length + 1];

        int i = 0, carry = 0;

        for (; i < a.Length; i++)
        {
            result[i] = (byte)(a[i] + b[i] + carry);

            carry = result[i] / 10;
            result[i] %= 10;
        }

        for (i = a.Length; i < b.Length; i++)
        {
            result[i] = (byte)(b[i] + carry);

            carry = result[i] / 10;
            result[i] %= 10;
        }
        if (carry != 0)
        { result[i] = 1; }
        else Array.Resize(ref result, result.Length - 1);

        return result;
    }
    static byte[] Multiply(byte[] arr, int N)
    {
        byte[] result = { 0 };
        for (int i = 0; i < N; i++)
        {
            result = Add(result, arr);
        }
        return result;
    }
    static void PrintNumber(byte[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--) Console.Write(arr[i]);

        Console.WriteLine();
    }
    static void Main()
    {
        byte[] factorial = { 1 };
        for (int i = 1; i <= 100; i++) PrintNumber(factorial = Multiply(factorial, i));
    }
}

