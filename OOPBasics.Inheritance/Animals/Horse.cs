namespace OOPBasics.Inheritance;

public class Horse : Animal
{
    private string _breed;

    public string Breed { get => _breed; set => _breed = value; }

    public Horse(int age, double weight, string breed) : base("horse", age, weight)
    {
        Breed = breed;
    }

    public override void DoSound()
    {
        Console.WriteLine("ehhhhhh");
    }

    public override string Stats()
    {
        return $"Animal stats --> name: {Name} age: {Age} weight: {Weight} breed: {Breed}";
    }
}
