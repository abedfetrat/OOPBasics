namespace OOPBasics.Polymorphism;

internal class InputTooShortError : UserError
{
    public override string UEMessage()
    {
        return "The input text was too short. This fired an error!";
    }
}
