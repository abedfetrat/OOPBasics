namespace OOPBasics.Inheritance;

public class Pelican : Bird
{
    public string FeatherColor { get; set; }

    public Pelican(int age, double weight, double wingSpan, string featherColor) : base(age, weight, wingSpan)
    {
        FeatherColor = featherColor;
    }

    public override void DoSound()
    {
        Console.WriteLine("quuawk quuawk quuawk");
    }

    public override string Stats()
    {
        return $"Animal stats --> name: {Name} age: {Age} weight: {Weight} wingspan: {WingSpan} feather color: {FeatherColor}";
    }
}
