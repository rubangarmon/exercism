using System;
using System.Linq;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        var sumOfNums = (double) Enumerable.Range(1, max)
            .Aggregate(0, (acc, num) => acc + num);
        return Convert.ToInt32(Math.Pow(sumOfNums,2));    
    }

    public static int CalculateSumOfSquares(int max)
        => Enumerable.Range(1, max)
            .Aggregate(0, (acc, num ) => acc + (int)Math.Pow(num, 2));

    public static int CalculateDifferenceOfSquares(int max)
       => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}