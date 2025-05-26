using System;
public interface IAnimal
{
    void Eat();
    void MakeSound();
}
public class Animal : IAnimal
{
    public virtual void Eat()
    {
        Console.WriteLine("Some generic animal food");
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic animal sound");
    }
}

public class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Kibble");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Tuna");
    }

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
        
        myDog.MakeSound(); // print "Bark"
        myCat.MakeSound(); // print "Meow"

        myDog.Eat(); // print "Kibble"
        myCat.Eat(); // print "Tuna"

    }
}
