using System;

// Base class
public class Pool
{
    public int chlorineLevel;
    public int waterLevel;

    public Pool(int chlorine, int water)
    {
        chlorineLevel = chlorine;
        waterLevel = water;
    }

    public virtual void PoolInfo()
    {
        Console.WriteLine($"Pool Info - Chlorine Level: {chlorineLevel}, Water Level: {waterLevel}");
    }
}

// Derived class
public class Spa : Pool
{
    public int heatLevel;

    public Spa(int chlorine, int water, int heat) : base(chlorine, water)
    {
        heatLevel = heat;
    }

    // Overriding the base method to include heatLevel
    public override void PoolInfo()
    {
        Console.WriteLine($"Spa Info - Chlorine Level: {chlorineLevel}, Water Level: {waterLevel}, Heat Level: {heatLevel}");
    }
}

// Program entry
public class Program
{
    public static void Main()
    {
        Pool regularPool = new Pool(5, 100);
        Spa spaPool = new Spa(7, 80, 40);

        regularPool.PoolInfo(); // Output from base class
        spaPool.PoolInfo();     // Output from derived class
    }
}
