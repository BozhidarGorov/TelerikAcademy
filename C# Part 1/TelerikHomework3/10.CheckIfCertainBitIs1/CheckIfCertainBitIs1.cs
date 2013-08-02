using System;

class CheckIfCertainBitIs1
{
    static void Main()
    {
        string number, position;
        number = Console.ReadLine();
        position = Console.ReadLine();
        int p;
        int numToCheck;
        int.TryParse(number, out numToCheck);
        int.TryParse(position, out p);
        Console.WriteLine(Convert.ToString(numToCheck, 2).PadLeft(10, '0'));
        int mask = 1;
        Console.WriteLine(Convert.ToString(1, 2).PadLeft(10, '0'));
        mask = mask << p;
        Console.WriteLine(Convert.ToString(mask, 2).PadLeft(10, '0'));
        Console.WriteLine((numToCheck & mask) != 0);
        Console.WriteLine(Convert.ToString((numToCheck & mask), 2).PadLeft(10, '0'));
    }
}

