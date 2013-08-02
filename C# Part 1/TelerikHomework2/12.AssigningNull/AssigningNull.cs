using System;

class AssigningNull
{
    static void Main()
    {
        int? nullInteger = null;
        Console.WriteLine("This is the null-int ->{0}",nullInteger);
        nullInteger += 5;
        Console.WriteLine("This is the null-int after adding five->{0}",nullInteger);
        nullInteger = 5;
        Console.WriteLine("This is the null-int after assigning 5 to him ->{0}",nullInteger);
        double? nullDouble = null;
        Console.WriteLine("This is the null-double ->{0}",nullDouble);
        nullDouble += 5;
        Console.WriteLine("This is the null-double after adding 5 ->{0}",nullDouble);
        nullDouble = 2.01;
        Console.WriteLine("This is the null-double after assignig 2,01 to him ->{0}",nullDouble);
    }
}

