using System;
using System.Threading;

class CompareFloatingPointNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        float epsilon = 0.000001f,a,b;
        string firstFloat, secondFloat;
        Console.WriteLine("Enter two float numebers to be compared!!!");
        firstFloat = Console.ReadLine();
        secondFloat = Console.ReadLine();
        if (float.TryParse(firstFloat, out a) && float.TryParse(secondFloat, out b))
        {
            if (epsilon <= Math.Abs(a - b))
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
        else
        {
            Console.WriteLine("Please enter floats");
        }
    }
}

