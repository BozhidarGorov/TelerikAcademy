using System;

class NumberAddingAsArrays
{
    static byte[] Add(byte[]a,byte[]b)
    {
        if (a.Length > b.Length)
        {
            return Add(b, a);
        }

        
        byte[] result = new byte[b.Length+1];
        
        int i = 0, carry = 0;
        
        for (; i < a.Length; i++)
        {
            result[i] = (byte)(a[i] + b[i] + carry);

            carry = result[i]/10;
            result[i] %= 10;
        }

        for (i=a.Length; i < b.Length; i++)
        {
            result[i] = (byte)(b[i] + carry);

            carry = result[i] / 10;
            result[i] %= 10;
        }
        if (carry != 0) 
        { result[i] = 1; }
        else Array.Resize(ref result, result.Length - 1);

        return result;
    }
    static void Main()
    {
        byte[] first = { 7,0,7};
        byte[] second = { 7 ,4,7};
        byte[] result = Add(first, second);
        for (int i = result.Length-1; i >=0; i--)
        {
            Console.Write(result[i] + " " );
        }
    }
}

