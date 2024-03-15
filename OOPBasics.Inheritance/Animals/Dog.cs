namespace OOPBasics.Inheritance;

public class Dog : Animal
{
    private string _breed;

    public string Breed { get => _breed; set => _breed = value; }
    
    public Dog(int age, double weight, string breed) : base("dog", age, weight)
    {
        Breed = breed;
    }

    public override void DoSound()
    {
        Console.WriteLine("woffwoff");
    }

    public override string Stats()
    {
        return $"Animal stats --> name: {Name} age: {Age} weight: {Weight} breed: {Breed}";
    }

    public string Pet() {
        return ":D";
    }
}
