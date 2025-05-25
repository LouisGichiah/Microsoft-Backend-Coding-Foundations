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
    public static void Main(string[] args)
    {
        Dog myDog = new Dog();
        Cat myCat = new Cat();
        
        myDog.MakeSound(); // Should print "Bark"
        myCat.MakeSound(); // Should print "Meow"
    }
}
