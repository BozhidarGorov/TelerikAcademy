using System;

class Polynomial
{
    static decimal[] Addition(decimal[] firstPoly, decimal[] secondPoly)
    {
        decimal[] result = new decimal[Math.Max(firstPoly.Length, secondPoly.Length)];
        int minLenght = 0,smallerPoly = 0;
        if (firstPoly.Length > secondPoly.Length)
        {
            minLenght = secondPoly.Length;
            smallerPoly = 2;
        }
        else
        {
            minLenght = firstPoly.Length;
            smallerPoly = 1;
        }

        for (int i = 0; i < minLenght; i++)
        {
            result[i] = firstPoly[i] + secondPoly[i];
        }

        for (int i = minLenght; i < result.Length; i++)
        {
            if (smallerPoly == 1)
            {
                result[i] = firstPoly[i];
            }
            else
            {
                result[i] = secondPoly[i];
            }
        }
        return result;
    }
    static decimal[] Substract(decimal[] firstPoly, decimal[] secondPoly)
    {
        decimal[] result = new decimal[Math.Max(firstPoly.Length, secondPoly.Length)];
        int minLenght = 0, smallerPoly = 0;
        if (firstPoly.Length > secondPoly.Length)
        {
            minLenght = secondPoly.Length;
            smallerPoly = 2;
        }
        else
        {
            minLenght = firstPoly.Length;
            smallerPoly = 1;
        }

        for (int i = 0; i < minLenght; i++)
        {
            result[i] = firstPoly[i] - secondPoly[i];
        }
        for (int i = minLenght; i < result.Length; i++)
        {
            if (smallerPoly == 1)
            {
                result[i] = firstPoly[i];
            }
            else
            {
                result[i] = secondPoly[i];
            }
        }
        return result;
    }

    static decimal[] Multiplication(decimal[] firstPoly, decimal[] secondPoly)
    {
        decimal[] result = new decimal[firstPoly.Length + secondPoly.Length];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = 0;
        }
        for (int i = 0; i < firstPoly.Length; i++)
        {
            for (int j = 0; j < secondPoly.Length; j++)
            {
                result[i + j] += firstPoly[i] * secondPoly[j];
            }
        }
        return result;
    }
    static void PrintPolinomial(decimal[] polinomial)
    {
        for (int i = polinomial.Length - 1; i >= 0; i--)
        {
            if (polinomial[i] != 0 && i != 0)
            {
                if (polinomial[i - 1] >= 0)
                {
                    Console.Write("{1}x^{0} +", i, polinomial[i]);
                }
                else
                {
                    Console.Write("{1}x^{0} ", i, polinomial[i]);
                }
            }
            else if (i == 0)
            {
                Console.Write("{0}", polinomial[i]);
            }
        }

        Console.WriteLine();
    }
    static void Main()
    {
        decimal[] first = { 4, 0, 2 };
        decimal[] second = { 12, 4, 0 };
        PrintPolinomial(first);
        PrintPolinomial(second);
        PrintPolinomial(Addition(first, second));
        PrintPolinomial(Substract(first, second));
        PrintPolinomial(Multiplication(first, second));
    }
}

