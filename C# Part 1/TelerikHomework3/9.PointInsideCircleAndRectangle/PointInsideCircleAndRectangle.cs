using System;

class PointInsideCircleAndRectangle
{
    static void Main()
    {
        int xPoint = 0;
        int yPoint = 1;
        int xCenter = 1;
        int yCenter = 1;
        int radius = 3;
        bool inCircle = (xPoint - xCenter) * (xPoint - xCenter) + (yPoint - yCenter) * (yPoint - yCenter) < (radius * radius);
        bool inRectangle = (xPoint >= -1 && xPoint <= 5 && xPoint >= -1 && yPoint <= 1);
        if(inCircle && !inRectangle)
        {
            Console.WriteLine("The point is in the circle and out of the rectangle!!");
        }
        else
        {
            Console.WriteLine("The point is in the rectangle or out of the cirlce!!");
        }
    }
}


