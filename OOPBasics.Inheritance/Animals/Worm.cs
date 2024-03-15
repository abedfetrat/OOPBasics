namespace OOPBasics.Inheritance;

public class Worm : Animal
{
    public bool IsPoisonus { get; set; }
    public Worm(int age, double weight, bool isPoisonus) : base("worm", age, weight)
    {
        IsPoisonus = isPoisonus;
    }

    public override void DoSound()
    {
        Console.WriteLine("............");
    }

    public override string Stats()
    {
        return $"Animal stats --> name: {Name} age: {Age} weight: {Weight} is poisonus: {IsPoisonus}";
    }
}
