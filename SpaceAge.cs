using System;
using System.Collections.Generic;

public class SpaceAge(int seconds)
{
    private const double SiderealYear = 365.25;
    private readonly Dictionary<string, double> _earthYears = new()
    {
        {"Mercury", 0.2408467},
        {"Venus", 0.61519726},
        {"Mars", 1.8808158},
        {"Jupiter", 11.862615},
        {"Saturn", 29.447498},
        {"Uranus", 84.016846},
        {"Neptune", 164.79132},
    };

    public double OnEarth() =>
        TimeSpan.FromSeconds(seconds).TotalDays / SiderealYear;

    public double OnMercury() =>
        OnEarth() / _earthYears["Mercury"];

    public double OnVenus() =>
        OnEarth() / _earthYears["Venus"];

    public double OnMars() =>
        OnEarth() / _earthYears["Mars"];

    public double OnJupiter() =>
        OnEarth() / _earthYears["Jupiter"];

    public double OnSaturn() =>
        OnEarth() / _earthYears["Saturn"];

    public double OnUranus() =>
        OnEarth() / _earthYears["Uranus"];

    public double OnNeptune() =>
        OnEarth() / _earthYears["Neptune"];
}