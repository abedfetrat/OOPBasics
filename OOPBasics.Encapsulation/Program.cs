namespace OOPBasics.Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Person person = new Person();
           try
           {
               person.Age = 0;
               person.FName = "Abed";
               person.LName = "Fetrat";
           } catch (Exception ex)
           {
               Console.Error.WriteLine(ex.Message);
           } */

            try
            {
                PersonHandler persHandler = new PersonHandler();
                Person abed = persHandler.CreatePerson(28, "Abed", "Fetrat", 175, 70);

                Console.WriteLine("Before modify: " + abed.ToString());

                persHandler.SetHeight(abed, 200);
                persHandler.SetWeight(abed, 100);
                persHandler.SetAge(abed, 30);

                Console.WriteLine("After modify: " + abed.ToString());

                // Bör resultera i en exception då namnet är för lång
                persHandler.SetFName(abed, "thisisaverylongfirstname");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }
    }
}