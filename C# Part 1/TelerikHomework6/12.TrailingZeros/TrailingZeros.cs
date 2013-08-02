using System;

class TrailingZeros
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        int zeroCounter = 0;

        while (true)
        {
            int result = n / 5;
            if (result != 0)
            {
                zeroCounter = zeroCounter + result;
                n = result;
            }
            else
            {
                Console.WriteLine("Trailing zeros count: {0}", zeroCounter);
                break;
            }
        }
    }
}