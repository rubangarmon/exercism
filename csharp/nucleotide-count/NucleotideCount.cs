using System;
using System.Linq;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {

        var nucleoFrecu = new Dictionary<char, int>()
        {
            {'A', 0 },
            {'C', 0 },
            {'G', 0 },
            {'T', 0 }
        };

        foreach (var letter in sequence)
        {
            if (nucleoFrecu.ContainsKey(letter))
                nucleoFrecu[letter]++;
            else
                throw new ArgumentException("Nucleotide doesn't allow");
        }

        return nucleoFrecu;

    }
}