namespace DyrOgBen;

public class GameManager
{
    private List<Animal> _animals;
    private Animal _currentAnimal;
    private int _guess;
    private bool _gameActive;

    private enum UserAnswer
    {
        Yes,
        No
    };

    public GameManager()
    {
        _animals = new List<Animal>();
        
        _animals.Add(new Animal("Donkey", 4, "Commonly used for carrying heavy loads. "));
        _animals.Add(new Animal("Hawk", 2, "A bird of prey knows for its keen eyesight. "));
        _animals.Add(new Animal("Spider", 8, "Spins something to catch it's prey"));
        _animals.Add(new Animal("Centipede", 10000, "Has many legs, but not as the name suggests"));
        _animals.Add(new Animal("Ant", 6, "Known for its strong work etchic and teamwork"));
        
        _currentAnimal = GetRandomAnimal();
        _guess = Guess();
        //_userAnswer = TryAgain();
    }
    
    // A simple method to show the whole list if needed
    public void ShowList()
    {
        foreach (var animal in _animals)
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
        int index = random.Next(_animals.Count);

        Animal randomAnimal = _animals[index];
        
        // Console.WriteLine("Random animal: " + randomAnimal.name);
        // Console.WriteLine("Number of legs: " + randomAnimal.numberOfLegs);
        //Console.WriteLine();

        return randomAnimal;
    }
    // A simple method used to replace all letters in the name for " * " 
    public string BlurAnimalName()
    {
        _currentAnimal = GetRandomAnimal();
        string nameToBlur = _currentAnimal.name;
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
        if (guess == _currentAnimal.numberOfLegs)
        {
            return true;
        }
        return false;
    }

    public bool TryAgain()
    {
        Console.WriteLine("Try again? Please write: Yes or No");
        string answer = Console.ReadLine().ToLower();
        
        if (answer == UserAnswer.Yes.ToString().ToLower())
        {
            return true;
        }

        if (answer == UserAnswer.No.ToString().ToLower())
        {
            return false;
        }

        Console.WriteLine("Incorrect input");
        return false;
    }
    // Bigger method where i pack the game logic and use the other methods
    public void StartGame()
    {
        Console.WriteLine("Guess the number of legs: ");
        _gameActive = true;
        
        while (_gameActive)
        {
            Console.WriteLine(BlurAnimalName());
            Console.WriteLine(_currentAnimal.hint);
            
            int guess = Guess();
            bool isCorrect = CheckIfCorrect(guess);

            if (isCorrect)
            {
                Console.WriteLine("Correct! The animal was: " + _currentAnimal.name);
                // TryAgain method here?
                // UserAnswer tryAgainAnswer = TryAgain();
            }
            else
            {
                Console.WriteLine("Wrong guess, please try again.");
                _gameActive = true;
            }
        }

        Console.WriteLine("Game over, closing program..");
        _gameActive = false;
    }
}