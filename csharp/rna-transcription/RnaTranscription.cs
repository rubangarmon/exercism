using System;
using System.Collections.Generic;
using System.Linq;
public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        var dicRna = new Dictionary<char, char>()
        {
            { 'G', 'C' },
            { 'C', 'G' },
            { 'T', 'A' },
            { 'A', 'U' },
        };

        var rnaArray = nucleotide.Select(n => dicRna[n]).ToArray();
        return new string(rnaArray);
    }
}