using System;

public class SpaceAge
{
    private readonly int _seconds;
    private const double ONE_YEAR_EARTH_SECONDS = 31557600;
    public struct PlanetsInEarthSeconds
    {
        public const double Mercury = ONE_YEAR_EARTH_SECONDS * 0.2408467;
        public const double Venus = ONE_YEAR_EARTH_SECONDS * 0.61519726;
        public const double Earth = ONE_YEAR_EARTH_SECONDS;
        public const double Mars = ONE_YEAR_EARTH_SECONDS * 1.8808158;
        public const double Jupiter = ONE_YEAR_EARTH_SECONDS * 11.862615;
        public const double Saturn = ONE_YEAR_EARTH_SECONDS * 29.447498;
        public const double Uranus = ONE_YEAR_EARTH_SECONDS * 84.016846;
        public const double Neptune = ONE_YEAR_EARTH_SECONDS * 164.79132;
    }
    public SpaceAge(int seconds)
    {
        _seconds = seconds;
    }

    public double OnEarth()
    {
        return _seconds / PlanetsInEarthSeconds.Earth;
    }

    public double OnMercury()
    {
        return _seconds / PlanetsInEarthSeconds.Mercury;
    }

    public double OnVenus()
    {
        return _seconds / PlanetsInEarthSeconds.Venus;
    }

    public double OnMars()
    {
        return _seconds / PlanetsInEarthSeconds.Mars;
    }

    public double OnJupiter()
    {
        return _seconds / PlanetsInEarthSeconds.Jupiter;
    }

    public double OnSaturn()
    {
        return _seconds / PlanetsInEarthSeconds.Saturn;
    }

    public double OnUranus()
    {
        return _seconds / PlanetsInEarthSeconds.Uranus;
    }

    public double OnNeptune()
    {
        return _seconds / PlanetsInEarthSeconds.Neptune;
    }
}