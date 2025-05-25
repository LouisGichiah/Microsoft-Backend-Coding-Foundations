using System;
using System.Collections.Generic;

// Interface declaration
public interface IPlayable
{
    void Play();
}

// Implementing the interface in two different classes
public class Guitar : IPlayable
{
    public void Play()
    {
        Console.WriteLine("The Guitar is playing");
    }
}

public class Piano : IPlayable
{
    public void Play()
    {
        Console.WriteLine("The Piano is playing");
    }
}

public class Program
{
    public static void Main()
    {
        // List of IPlayable objects demonstrating polymorphism
        List<IPlayable> instruments = new List<IPlayable>
        {
            new Guitar(),
            new Piano()
        };

        // Polymorphic behavior: each Play() calls the appropriate implementation
        foreach (IPlayable instrument in instruments)
        {
            instrument.Play();
        }
    }
}
