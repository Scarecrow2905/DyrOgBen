namespace DyrOgBen;

public class Animal
{
    public string name { get; set; }
    public int numberOfLegs { get; set; }

    private List<Animal> animals = new List<Animal>();

    public Animal(string name, int numberOfLegs)
    {
        this.name = name;
        this.numberOfLegs = numberOfLegs;
    }

    public void Add(Animal animal)
    {
        animals.Add(animal);
    }

    public void addAnimals()
    {
        animals.Add(new Animal("Donkey", 4));
        animals.Add(new Animal("Hawk", 2));
        animals.Add(new Animal("Spider", 8));

    }

    public void ShowList()
    {
        foreach (var animal in animals)
        {
            Console.WriteLine("Name: " + animal.name);
            Console.WriteLine("Number of legs: " + animal.numberOfLegs);
            Console.WriteLine("");
        }
    }

    public void getRandomAnimal()
    {
        var random = new Random();
        int index = random.Next(animals.Count);
        Console.WriteLine("Random animal: " + index);
        Console.WriteLine();

    }
    
    
    
    
    
    
}



