namespace OOPBasics.Inheritance;

// F 13. Här lägger vi till nya attribute som alla fåglar ska ha
public class Bird : Animal
{
    public double WingSpan { get; set; }

    public Bird(int age, double weight, double wingSpan) : base("bird", age, weight)
    {
        WingSpan = wingSpan;
    }

    public override void DoSound()
    {
        Console.WriteLine("chirp chirp chrip");
    }

    public override string Stats()
    {
        return $"Animal stats --> name: {Name} age: {Age} weight: {Weight} wingspan: {WingSpan}";
    }
}
