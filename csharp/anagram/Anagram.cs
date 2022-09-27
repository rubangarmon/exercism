using System;
using System.Collections.Generic;

public class Anagram
{
    private readonly string _baseword;
    public Anagram(string baseWord)
    {
        _baseword = baseWord;
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        var list = new List<string>();
        foreach (var item in potentialMatches)
        {
            if (_baseword.ToLower() != item.ToLower() 
                && IsAnagram(_baseword.ToLower(), item.ToLower()))
            {
                list.Add(item);
            }
        }
        return list.ToArray();
    }

    private bool IsAnagram(string originalWord, string secondWord)
    {
        if(originalWord.Equals(""))
        {
            return secondWord.Equals("");
        }
        if (secondWord.Contains(originalWord[0]))
        {
            var secondIndex = secondWord.IndexOf(originalWord[0]);
            return IsAnagram(
                originalWord.Substring(1,originalWord.Length - 1), 
                secondWord.Remove(secondIndex, 1)
                );
        }
        return false;
    }
}