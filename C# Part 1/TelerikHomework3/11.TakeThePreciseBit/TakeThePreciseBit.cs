using System;

class TakeThePreciseBit
{
    static void Main()
    {
        string number, position;
        number = Console.ReadLine();
        position = Console.ReadLine();
        int p;
        int intToExtractFrom;
        int.TryParse(number, out intToExtractFrom);
        int.TryParse(position, out p);
        Console.WriteLine(Convert.ToString(intToExtractFrom, 2).PadLeft(10, '0'));
        int mask = 1;
        Console.WriteLine(Convert.ToString(mask, 2).PadLeft(10, '0'));
        mask = mask << p;
        Console.WriteLine(Convert.ToString(mask, 2).PadLeft(10, '0'));
        Console.WriteLine(Convert.ToString((intToExtractFrom & mask), 2).PadLeft(10, '0'));
        if ((intToExtractFrom & mask) != 0)
        {
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}

