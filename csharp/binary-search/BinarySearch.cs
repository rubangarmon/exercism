using System;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        return FindRE(input, value, 0, input.Length - 1);
    }

    private static int FindRE(int[] input, int value, int startIndex, int endIndex)
    {
        if (startIndex > endIndex)
            return -1;
        var middleIndex = startIndex + endIndex;
        if (input[middleIndex] == value)
        {
            return middleIndex;
        }
        else if (input[middleIndex] > value)
        {
            return FindRE(input, value, startIndex, middleIndex - 1);
        }
        return FindRE(input, value, middleIndex + 1, endIndex);
    }

    public static int Find2(int[] input, int value)
    {
        int minNum = 0;
        int maxNum = input.Length - 1;

        while (minNum <= maxNum)
        {
            int mid = (minNum + maxNum) / 2;
            if (value == input[mid])
            {
                return ++mid;
            }
            else if (value < input[mid])
            {
                maxNum = mid - 1;
            }
            else
            {
                minNum = mid + 1;
            }
        }
        return -1;

    }
}