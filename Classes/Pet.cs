public abstract class Pet(string name)
{
    public string Name {get; set;} = name;

    public abstract string MakeSound();

    public override string ToString()
    {
        return $"My name is {Name}. I am a {GetType().Name} and I {MakeSound()}";
    }
}

public class Cat(string name): Pet(name)
{
    public override string MakeSound() => "Meow";
}

public class Dog(string name): Pet(name)
{
    public override string MakeSound() => "Woof";
}