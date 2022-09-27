using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        if (string.IsNullOrWhiteSpace(statement))
            return "Fine. Be that way!";
        else if (statement.IsQuestion())
            if (statement.IsYelling()) 
                return "Calm down, I know what I'm doing!";
            else
            return "Sure.";
        else if (statement.IsYelling())
            return "Whoa, chill out!";
        return "Whatever.";
    }

    private static bool IsYelling(this string statement) => 
        statement.Any(char.IsLetter) && statement.ToUpper() == statement;
    private static bool IsQuestion(this string statement) =>
        statement.EndsWith('?');
}