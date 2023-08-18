namespace DyrOgBen;

public class GameManager
{
    private List<Animal> animals;
    private Animal currentAnimal;
    private int guess;
    private bool gameActive;

    public GameManager()
    {
        animals = new List<Animal>();
        
        animals.Add(new Animal("Donkey", 4));
        animals.Add((new Animal("Hawk", 2)));
        animals.Add(new Animal("Spider", 8));
        animals.Add((new Animal("Centipede", 10000)));
        
        currentAnimal = GetRandomAnimal();
        guess = Guess();
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
    
    public Animal GetRandomAnimal()
    {
        var random = new Random();
        int index = random.Next(animals.Count);

        Animal randomAnimal = animals[index];
        
        // Console.WriteLine("Random animal: " + randomAnimal.name);
        // Console.WriteLine("Number of legs: " + randomAnimal.numberOfLegs);
        //Console.WriteLine();

        return randomAnimal;
    }

    public string BlurAnimalName()
    {
        // currentAnimal = GetRandomAnimal();
        string nameToBlur = currentAnimal.name;
        string blurredName = "";
        
        foreach (char c in nameToBlur)
        {
            if (char.IsLetter(c))
            {
                blurredName += "*";
            }
            else
            {
                blurredName += c;
            }
        }

        return blurredName;
    }

    public int Guess()
    {
        string? input = Console.ReadLine();
        int guess;

        if (int.TryParse(input, out guess))
        {
            Console.WriteLine("You guessed: " + guess);
        }
        else
        {
            Console.WriteLine("Invalid input, it must be a number. Please try again.");
            // This might need another solution, as a throw-exception. 
            return -1;
        }
        
        return guess;
    }

    public bool CheckIfCorrect()
    {
        
        if (guess == currentAnimal.numberOfLegs)
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Wrong, try again.");
            return false;
        }

        return true;
    }
    
    public void StartGame()
    {
        gameActive = true;
        
        BlurAnimalName();
        Console.WriteLine(BlurAnimalName());
        Console.WriteLine("Guess the number: ");

        while (gameActive == true)
        {
            Console.Clear();
            Guess();
            CheckIfCorrect();
        }

        gameActive = false;

        // Method here with while that keeps the game running, a bool method for example
        
    }
}