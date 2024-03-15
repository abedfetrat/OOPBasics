using System.Reflection.Metadata.Ecma335;

namespace OOPBasics.Inheritance;
// F 14. Här lägger vi till nya attribute som alla djur ska ha
public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
    public Animal(string name, int age, double weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
    }
    public abstract void DoSound();

    public virtual string Stats()
    {
        return $"Animal stats --> name: {Name} age: {Age} weight: {Weight}";
    }
}
