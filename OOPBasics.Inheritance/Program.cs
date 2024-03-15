namespace OOPBasics.Inheritance;
internal class Program
{
    static void Main(string[] args)
    {
        // F. 13 Om vi behöver ny attribute som alla fåglar ska ha lägger vi det i Bird klassen.

        // F. 14 Om vi behöver ny attribute som alla djur ska ha lägger vi det i Animal klassen.

        // Vi måste ha lista av typen Animal för att alla djur (som ärver av Animal) ska kunna lagras på samma ställe
        List<Animal> animals = [];

        animals.Add(new Bird(1, 0.3, 2));
        animals.Add(new Flamingo(3, 1.5, 40, "Pink"));
        animals.Add(new Pelican(4, 1, 60, "black"));
        animals.Add(new Swan(2, 2, 100, 30.8));
        animals.Add(new Dog(3, 10, "bulldog"));
        animals.Add(new Hedgehog(1, 1.3, 3000));
        animals.Add(new Horse(5, 800, "arabian"));
        animals.Add(new Wolf(4, 100, false));
        animals.Add(new Wolfman("Wolverine", 38, 130, true));

        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.Name);
            animal.DoSound();

            if (animal is IPerson)
            {
                IPerson person = (IPerson)animal;
                person.Talk();
            }
        }

        List<Dog> dogs = [];
        dogs.Add(new Dog(3, 10, "bulldog"));
        // Vi kan inte lägga till en horse i listan av dogs då den listan enbart kan innehålla objekt av typen Dog
        //dogs.Add(new Horse(5, 800, "arabian"));

        Console.WriteLine();

        // Vi anropar Stats funktionen på varje animal. Då vi har fyllt listan av animals av olika animal sorter/subtyper
        // anropas Stats funktionen i respektiv subtyp/klass efersom vi har overridat med egen funktionalitet 
        // än det som finns i basklassen Animal.
        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.Stats());
        }

        Console.WriteLine();

        // Skriver ut stats för enbart hundar
        foreach (Animal animal in animals)
        {
            if (animal is Dog)
            {
                Console.WriteLine(animal.Stats());
                // Vi kan inte komma åt Pet funktionen i Dog klassen då denna animal objekt är av bastypen Animal,
                // vilket inte innehåller denna funktion
                //animal.Pet();

                // Vi måste först casta den till en Dog
                Dog dog = (Dog)animal;
                dog.Pet();
            }
        }

    }
}