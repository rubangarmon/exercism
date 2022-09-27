using System;
using System.Linq;

public static class ResistorColorDuo
{
    private static string[] colorsValues = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
    public static int Value(string[] colors)
    {
        string numberString = "";
        for (int iColor=0 ; iColor < colors.Length; ++iColor)
        {
            if (iColor == 2) break;
            if (colorsValues.Contains(colors[iColor])) 
            {
                numberString += Array.IndexOf(colorsValues, colors[iColor]);
            }

        }
        int.TryParse(numberString, out int defaultInt);
        return defaultInt;
    }
}
