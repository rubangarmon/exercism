using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private readonly List<int> _list;
    public HighScores(List<int> list)
    {
        _list = list;
    }

    public List<int> Scores() => _list;
    public int Latest() => _list.LastOrDefault();
    public int PersonalBest() => _list.OrderByDescending(a => a).FirstOrDefault();
    public List<int> PersonalTopThree() => _list.OrderByDescending(a => a).Take(3).ToList();
}