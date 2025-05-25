using System;
using System.Collections.Generic;

public class Instrument
{
    public virtual void Play()
    {
        Console.WriteLine("Playing an Instrument");
    }
}

public class Piano : Instrument
{
    public override void Play()
    {
        Console.WriteLine("Playing the Piano");
    }
}

public class Guitar : Instrument
{
    public override void Play()
    {
        Console.WriteLine("Strumming the Guitar");
    }
}

class Program
{
    static void Main()
    {
        // Create a list of instruments using base class reference
        List<Instrument> band = new List<Instrument>
        {
            new Instrument(),
            new Piano(),
            new Guitar()
        };

        // Polymorphic behavior: each call to Play() uses the correct override
        foreach (Instrument instrument in band)
        {
            instrument.Play();
        }
    }
}
