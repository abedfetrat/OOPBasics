namespace OOPBasics.Inheritance;

public class Swan : Bird
{
    public double NeckLength { get; set; }

    public Swan(int age, double weight, double wingSpan, double neckLength) : base(age, weight, wingSpan)
    {
        NeckLength = neckLength;
    }

    public override void DoSound()
    {
        Console.WriteLine("aaargh aaargh aaaaargh");
    }

    public override string Stats()
    {
        return $"Animal stats --> name: {Name} age: {Age} weight: {Weight} wingspan: {WingSpan} neck length: {NeckLength}";
    }
}
