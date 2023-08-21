namespace DyrOgBen;

public class Animal
{
    public string name { get; }
    public int numberOfLegs { get; }
    public string hint { get; }

    private List<Animal> animals;

    public Animal(string name, int numberOfLegs, string hint)
    {
        this.name = name;
        this.numberOfLegs = numberOfLegs;
        this.hint = hint;
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



