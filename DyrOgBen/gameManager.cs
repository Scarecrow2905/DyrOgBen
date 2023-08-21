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
        
        animals.Add(new Animal("Donkey", 4, "Commonly used for carrying heavy loads. "));
        animals.Add(new Animal("Hawk", 2, "A bird of prey knows for its keen eyesight. "));
        animals.Add(new Animal("Spider", 8, "Spins something to catch it's prey"));
        animals.Add(new Animal("Centipede", 10000, "Has many legs, but not as the name suggests"));
        animals.Add(new Animal("Ant", 6, "Known for its strong work etchic and teamwork"));
        
        currentAnimal = GetRandomAnimal();
        guess = Guess();
    }
    
    // A simple method to show the whole list if needed
    public void ShowList()
    {
        foreach (var animal in animals)
        {
            Console.WriteLine("Name: " + animal.name);
            Console.WriteLine("Number of legs: " + animal.numberOfLegs);
            Console.WriteLine("");
        }
    }
    
    // Used to retrieve a random Animal object from the animals List
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
    // A simple method used to replace all letters in the name for " * " 
    public string BlurAnimalName()
    {
        currentAnimal = GetRandomAnimal();
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
    
    // Method that returns the guess from the user as an Integer
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
            // This might need another solution, like a throw-exception. 
            return -1;
        }
        
        return guess;
    }

    // Used to check if the guess corresponds to the current animal that was randomly retrieved
    public bool CheckIfCorrect(int guess)
    {

        if (guess == currentAnimal.numberOfLegs)
        {
            // Console.WriteLine("Correct!");
            return true;
        }

        // Console.WriteLine("Wrong, try again.");
        return false;
    }
    // Bigger method where i pack the game logic and use the other methods
    public void StartGame()
    {
        gameActive = true;
        
        Console.WriteLine(BlurAnimalName());
        Console.WriteLine(currentAnimal.hint);

        while (gameActive)
        {
            //Console.Clear();
            //Guess();
            int guess = Guess();
            bool isCorrect = CheckIfCorrect(guess);

            if (isCorrect)
            {
                Console.WriteLine("Correct! The animal was: " + currentAnimal.name);
                gameActive = false;
            }
            else
            {
                Console.WriteLine("Wrong guess, please try again.");
                gameActive = true;
            }
        }

        Console.WriteLine("Game over, closing program..");
        gameActive = false;

        // Method here with while that keeps the game running, a bool method for example
        
    }
}