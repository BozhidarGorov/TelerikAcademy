using System;

class CheckIfThirdRightToLeftIs7
{
    static void Main()
    {
        int n=123732;
        if (n/100%10==7)
        {
            Console.WriteLine("Yes the third integer of {0} from right to left is 7!!",n);
        }
        else
        {
            Console.WriteLine("No the third integer of {0} from right to left is not 7",n);
        }
    }
}

