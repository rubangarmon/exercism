using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        var numbers = GetNumbers(phoneNumber);
        return (numbers.Item1 == 212, numbers.Item2 == 555, numbers.Item3.ToString());
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) 
        => phoneNumberInfo.IsFake;

    private static (int, int, int) GetNumbers(string phoneNumber) 
    {
        var numbers = phoneNumber.Split("-");
        return (int.Parse(numbers[0]), int.Parse(numbers[1]), int.Parse(numbers[2]));
    } 
}
