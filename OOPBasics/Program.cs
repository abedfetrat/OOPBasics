namespace OOPBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            try
            {
                person.Age = 0;
                person.FName = "Abed";
                person.LName = "Fetrat";
            } catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            
        }
    }
}
