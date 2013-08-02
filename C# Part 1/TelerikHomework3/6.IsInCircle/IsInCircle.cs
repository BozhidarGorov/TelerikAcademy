using System;

class IsInCircle
{
    static void Main()
    {
        int x = 3;
        int y = 4;
        int radius = 5;
        if (x*x +y*y < radius*radius)
        {
            Console.WriteLine("Yes the point is in the circle K(0,5)");   
        }
        else if (x * x + y * y == radius * radius)
        {
            Console.WriteLine("The point is on the perimiter of the circle K(0,5)");
        }
        else
        {
            Console.WriteLine("No the point is not in the circle K(0,5)");
        }
    }
}

