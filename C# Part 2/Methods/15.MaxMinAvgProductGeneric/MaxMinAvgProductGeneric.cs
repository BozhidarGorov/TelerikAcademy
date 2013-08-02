using System;
using System.Collections.Generic;
class MaxMinAvgProductGeneric
{
    static T FindMax<T>(params T[] arr)
    {
        dynamic biggestNum = arr[0];
        dynamic length = arr.Length;
        for (int i = 0; i < length; i++)
        {
            if (length > 0)
            {
                if (arr[i] > biggestNum)
                {
                    biggestNum = arr[i];
                }
            }
            else
            {
                return default(T);
            }
        }
        return biggestNum;
    }

    static T FindMin<T>(params T[] arr)
    {
        dynamic smallest = arr[0];
        int length = arr.Length;
        for (int i = 0; i < length; i++)
        {
            if (length > 0)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                }
            }
            else
            {
                return default(T);
            }
        }
        return smallest;
    }

    static T FindAvg<T>(params T[] arr)
    {
        dynamic counter = 0;
        dynamic sum = 0;
        dynamic sumAvg = 0;
        foreach (var number in arr)
        {
            sum = sum + number;
            counter++;
        }
        sumAvg = sum / counter;
        return sumAvg;
    }

    static T FindSum<T>(params T[] arr)
    {
        dynamic sum = 0;
        foreach (var number in arr)
        {
            sum += number;
        }
        return sum;
    }
    static T FindProduct<T>(params T[] arr)
    {
        dynamic product = 1;
        foreach (var number in arr)
        {
            product *= number;
        }
        return product;
    }
    static void Main()
    {

        decimal min = FindMin(6.1m, 3.11111m, 2.543m);
        decimal max = FindMax(6.1m, 3.11111m, 2.543m);
        decimal sum = FindSum(6.1m, 3.11111m, 2.543m);
        decimal average = FindAvg(6.1m, 3.11111m, 2.543m);
        decimal product = FindProduct(6.1m, 3.11111m, 2.543m);

        Console.WriteLine("Min: {0}.\nMax: {1}.\nSum: {2}.\nAverage: {3}.\nProduct: {4}.", min, max, sum, average, product);
    }
}

