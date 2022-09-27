using System;
using System.Linq;


public static class ResistorColor
{
    public static int ColorCode(string color) => Colors().Contains(color) ? Array.IndexOf(Colors(), color) : throw new ArgumentException();

    public static string[] Colors()
    {
        string[] colors = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
        return colors;
    }
}