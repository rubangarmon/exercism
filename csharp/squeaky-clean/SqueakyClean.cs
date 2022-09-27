using System;
using System.Text;
using System.Linq;

public static class Identifier
{
    private static bool IsGreekLowercase(char c) 
    {
        var result = c >= 'α' && c <= 'ω';
        return result;
    } 

    public static string Clean(string identifier)
    {
        var stringBuilder = new StringBuilder();
        var isAfterDash = false;
        foreach (var c in identifier)
        {
            stringBuilder.Append(c switch
            {
                _ when IsGreekLowercase(c) => default,
                _ when isAfterDash => char.ToUpperInvariant(c),
                _ when char.IsWhiteSpace(c) => '_',
                _ when char.IsControl(c) => "CTRL",
                _ when char.IsLetter(c) => c,
                _ => default,
            });
            isAfterDash = c.Equals('-');
        }
        return stringBuilder.ToString();
    }
}
