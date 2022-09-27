using System;
using System.Collections.Generic;

public class Robot
{
    public string Name { get; private set; }
    private Random randomGenerator = new Random();
    private static List<string> usedRobotnames = new List<string>();

    public Robot()
    {
        Name = GetName();
    }

    public void Reset()
    {
        Name = GetName();
    }

    private string GetName()
    {
        string name = GenerateRobotName();
        while (usedRobotnames.Contains(name))
        {
            name = GenerateRobotName();
        }
        usedRobotnames.Add(name);
        return name;
    }

    private string GenerateRobotName()
    {
        var letters = "";
        for (int i = 0; i < 2; i++)
        {
            letters += (char)randomGenerator.Next('A', 'Z');
        }
        return letters + randomGenerator.Next(100, 999);
    }
}