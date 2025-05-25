using System;
using System.Collections.Generic;

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animals make sounds");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

public class Program
{
    public static void Main()
    {
        List<Animal> animals = new List<Animal> 
        {
            new Dog(),
            new Cat()
        };

        foreach (Animal animal in animals)
        {
            animal.MakeSound(); // Call MakeSound on the current animal
        }
    }
}
