using System;

class ReversingDigits
{
    static int Reversing(int number)
    {
        int newNumber = 0;
        while (number != 0)
        {
            newNumber *= 10;
            newNumber += (number % 10);
            number /= 10;
        }
        return newNumber;
    }
    static void Main()
    {
        Console.WriteLine(Reversing(1025));
    }
}

