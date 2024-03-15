namespace OOPBasics.Polymorphism;

internal class TextInputTooLongError : UserError
{
    public override string UEMessage()
    {
        return "The input text was too long. This fired an error!";
    }
}
