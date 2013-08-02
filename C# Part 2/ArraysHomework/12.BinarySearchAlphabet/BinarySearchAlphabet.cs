using System;

class BinarySearchAlphabet
{
    static int binarySearch(int []array, int elem, int left, int right)
    {
        int mid = (right + left) / 2;
        while (right >= left)
        {
            mid = (left + right) / 2;
            if (array[mid] < elem)
            {
                left = mid + 1;
            }
            if (array[mid] > elem)
            {
                right = mid - 1;
            }
            if (array[mid] == elem)
            { return mid; }
        }
        return mid;
    }
    static void Main()
    {
        // 97 :122 ASCII (a..z)
        int[] alphabetArr = new int[26];
        for (int i = 0; i < 26; i++)
        {
            alphabetArr[i] = 97 + i;
        }

        string word = Console.ReadLine();
        for (int i = 0; i < word.Length; i++)
        {
            Console.Write(binarySearch(alphabetArr,word[i],0,26) + " ");
        }
    }
}

