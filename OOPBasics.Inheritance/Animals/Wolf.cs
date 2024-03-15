namespace OOPBasics.Inheritance;

public class Wolf : Animal
{
    public bool IsHungry { get; set; }

    public Wolf(int age, double weight, bool isHungry) : base("wolf", age, weight)
    {
        IsHungry = isHungry;
    }

    public override void DoSound()
    {
        Console.WriteLine("auuuuuuuhhhhh");
    }

    public override string Stats()
    {
        return $"Animal stats --> name: {Name} age: {Age} weight: {Weight} is hungry: {IsHungry}";
    }
}
