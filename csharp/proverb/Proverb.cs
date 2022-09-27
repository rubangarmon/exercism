using System;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        if (subjects.Length == 0) return subjects;
        var proverd = new string[subjects.Length];
        if(subjects.Length > 1)
        {
            for (int i = 0; i < subjects.Length-1; i++)
            {
                proverd[i] = $"For want of a {subjects[i]} the {subjects[i + 1]} was lost.";
            }
        }
        proverd[subjects.Length-1] = $"And all for the want of a {subjects[0]}.";
        return proverd;
    }
}