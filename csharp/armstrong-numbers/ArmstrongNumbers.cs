using System;
using System.Linq;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        string strNumber = number.ToString();
        return number == strNumber.Aggregate(0.0, 
            (ac, digi) => ac += Math.Pow(Char.GetNumericValue(digi), strNumber.Length));
    }
}