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
        Dog myDog = new Dog(); //creates an instance (object) of the Dog class and assigns it to the variable myDog. new Dog() - calls the constructor of the Dog class 
        Cat myCat = new Cat(); //creates an instance (object) of the Cat class and assigns it to the variable myCat. new Cat() - calls the constructor of the Cat class 

        myDog.MakeSound(); // Should print "Bark"
        myCat.MakeSound(); // Should print "Meow"
    }
}
