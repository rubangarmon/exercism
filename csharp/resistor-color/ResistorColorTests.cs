// This file was auto-generated based on version 1.0.0 of the canonical data.

using System;
using Xunit;

public class ResistorColorTests
{
    [Fact]
    public void Black()
    {
        Assert.Equal(0, ResistorColor.ColorCode("black"));
    }

    [Fact]
    public void White()
    {
        Assert.Equal(9, ResistorColor.ColorCode("white"));
    }

    [Fact]
    public void Orange()
    {
        Assert.Equal(3, ResistorColor.ColorCode("orange"));
    }

    [Fact]
    public void Weird()
    {
        Assert.Throws<ArgumentException>(() => ResistorColor.ColorCode("any"));
    }

    [Fact]
    public void Colors()
    {
        Assert.Equal(new[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" }, ResistorColor.Colors());
    }
}