namespace OOPBasics.Polymorphism;
internal class Program
{
    static void Main(string[] args)
    {
        List<UserError> errors = [];

        errors.Add(new NumericInputError());
        errors.Add(new TextInputError());
        errors.Add(new InputTooShortError());
        errors.Add(new TextInputTooLongError());
        
        foreach (UserError error in errors)
        {
            Console.WriteLine(error.UEMessage());
        }
    }
}