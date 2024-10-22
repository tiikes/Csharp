using System;

    public interface INoiseCapable
    {
        void MakeNoise();
    }
    public abstract class Animal
{
    protected string name;

    public Animal(string name)
    {
        this.name = name;
    }

    public abstract void Eat();

    public abstract void Sleep();
}

public class Dog : Animal, INoiseCapable
{
    public Dog() : base("Dog") { }

    public Dog(string name) : base(name) { }

    public override void Eat()
    {
        Console.WriteLine($"{name} eats");
    }

    public override void Sleep()
    {
        Console.WriteLine($"{name} sleeps");
    }

    public void Bark()
    {
        Console.WriteLine($"{name} barks");
    }

    public void MakeNoise()
    {
        Bark();
    }
}

public class Cat : Animal, INoiseCapable
{
    public Cat() : base("Cat") { }

    public Cat(string name) : base(name) { }

    public override void Eat()
    {
        Console.WriteLine($"{name} eats");
    }

    public override void Sleep()
    {
        Console.WriteLine($"{name} sleeps");
    }

    public void Purr()
    {
        Console.WriteLine($"{name} purrs");
    }

    public void MakeNoise()
    {
        Purr();
    }
}


