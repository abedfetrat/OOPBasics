namespace OOPBasics.Inheritance;

public class Hedgehog : Animal
{
    public int NumSpikes { get; set; }

    public Hedgehog(int age, double weight, int numSpikes) : base("hedgehog", age, weight)
    {
        NumSpikes = numSpikes;
    }

    public override void DoSound()
    {
        Console.WriteLine("ajajaj");
    }

    public override string Stats()
    {
        return $"Animal stats --> name: {Name} age: {Age} weight: {Weight} number of spikes: {NumSpikes}";
    }
}
