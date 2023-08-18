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

    // public void Add(Animal animal)
    // {
    //     animals.Add(animal);
    // }
    //
    // public void addAnimals()
    // {
    //     animals.Add(new Animal("Donkey", 4));
    //     animals.Add(new Animal("Hawk", 2));
    //     animals.Add(new Animal("Spider", 8));
    //
    // }



    // Needs fixing: currently not showing correct output
    // Fixed: Was only showing the index instead of storing animals[index] into a variable.

    
    
    
    
    
    
}



