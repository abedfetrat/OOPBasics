namespace OOPBasics.Inheritance;

public class Wolfman : Wolf, IPerson
{
    public string NickName { get; set; }
    public Wolfman(string nickName, int age, double weight, bool isHungry) : base(age, weight, isHungry)
    {
        NickName = nickName;
    }

    public void Talk()
    {
        Console.WriteLine($"I'm half wolf and half man, I'm called {NickName}");
    }

    public override string Stats()
    {
        return $"Animal stats --> name: {Name} age: {Age} weight: {Weight} is hungry: {IsHungry} nickname: {NickName}";
    }
}
