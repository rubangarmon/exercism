using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        return Enumerable.Range(0, max)
            .Where(num => 
                multiples.Any(fact => fact != 0 && num % fact == 0))
            .Sum();
    }
}