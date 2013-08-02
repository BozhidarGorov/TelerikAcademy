using System;

class FindingIfBitIs1or0
{
    static void Main()
    {
        int numToCheck = 15;
        Console.WriteLine(Convert.ToString(numToCheck, 2).PadLeft(10, '0'));
        int mask = 1;
        Console.WriteLine(Convert.ToString(1 , 2).PadLeft(10,'0'));
        mask = mask << 3;
        Console.WriteLine(Convert.ToString(mask , 2).PadLeft(10,'0'));
        Console.WriteLine((numToCheck & mask) != 0);
        Console.WriteLine(Convert.ToString((numToCheck & mask) , 2).PadLeft(10,'0'));
    }
}

