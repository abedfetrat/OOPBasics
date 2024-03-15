namespace OOPBasics.Inheritance;

public class Flamingo : Bird
{
    public string Color { get; set; }

    public Flamingo(int age, double weight, double wingSpan, string color) : base(age, weight, wingSpan)
    {
        Color = color;
    }

    public override void DoSound()
    {
        Console.WriteLine("qwaak qwaaak quuuaaak");
    }

    public override string Stats()
    {
        return $"Animal stats --> name: {Name} age: {Age} weight: {Weight} wingspan: {WingSpan} color: {Color}";
    }
}
